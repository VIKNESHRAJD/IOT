using System;
using System.Text;

namespace YourNamespace
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Create a StringBuilder to store selected items
            StringBuilder selectedItems = new StringBuilder("your cabinet is:<br />");

            // Loop through the CheckBoxList items
            foreach (var item in CheckBoxList1.Items)
            {
                var listItem = (System.Web.UI.WebControls.ListItem)item;
                if (listItem.Selected)
                {
                    selectedItems.Append($"__{listItem.Text}<br />");
                }
            }

            // Display the selected items
            Literal1.Text = selectedItems.ToString();
        }
    }
}
