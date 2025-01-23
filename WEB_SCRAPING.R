{
  "nbformat": 4,
  "nbformat_minor": 0,
  "metadata": {
    "colab": {
      "provenance": []
    },
    "kernelspec": {
      "name": "ir",
      "display_name": "R"
    },
    "language_info": {
      "name": "R"
    }
  },
  "cells": [
    {
      "cell_type": "code",
      "source": [
        "install.packages(\"robotstxt\")"
      ],
      "metadata": {
        "colab": {
          "base_uri": "https://localhost:8080/"
        },
        "id": "KysCJRLh4wy2",
        "outputId": "18ca80e5-dc38-4126-8491-fde94d7ccf04"
      },
      "execution_count": 2,
      "outputs": [
        {
          "output_type": "stream",
          "name": "stderr",
          "text": [
            "Installing package into ‘/usr/local/lib/R/site-library’\n",
            "(as ‘lib’ is unspecified)\n",
            "\n",
            "also installing the dependencies ‘listenv’, ‘parallelly’, ‘future’, ‘globals’, ‘spiderbar’, ‘future.apply’\n",
            "\n",
            "\n"
          ]
        }
      ]
    },
    {
      "cell_type": "code",
      "execution_count": 3,
      "metadata": {
        "colab": {
          "base_uri": "https://localhost:8080/",
          "height": 254
        },
        "id": "aqhL_8zq3wJN",
        "outputId": "1efc6107-e338-4827-80a9-27531f15793e"
      },
      "outputs": [
        {
          "output_type": "display_data",
          "data": {
            "text/plain": [
              "{html_document}\n",
              "<html lang=\"en\">\n",
              "[1] <head>\\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8 ...\n",
              "[2] <body>\\n<div id=\"__next\"><main class=\"__variable_516daa\"><!--$--><!--/$-- ..."
            ]
          },
          "metadata": {}
        },
        {
          "output_type": "display_data",
          "data": {
            "text/plain": [
              "character(0)"
            ],
            "text/html": [],
            "text/markdown": "",
            "text/latex": ""
          },
          "metadata": {}
        },
        {
          "output_type": "display_data",
          "data": {
            "text/plain": [
              "character(0)"
            ],
            "text/html": [],
            "text/markdown": "",
            "text/latex": ""
          },
          "metadata": {}
        },
        {
          "output_type": "display_data",
          "data": {
            "text/plain": [
              "character(0)"
            ],
            "text/html": [],
            "text/markdown": "",
            "text/latex": ""
          },
          "metadata": {}
        },
        {
          "output_type": "display_data",
          "data": {
            "text/plain": [
              "character(0)"
            ],
            "text/html": [],
            "text/markdown": "",
            "text/latex": ""
          },
          "metadata": {}
        },
        {
          "output_type": "display_data",
          "data": {
            "text/plain": [
              "     Athletes sport event medals"
            ],
            "text/html": [
              "<table class=\"dataframe\">\n",
              "<caption>A data.frame: 0 × 4</caption>\n",
              "<thead>\n",
              "\t<tr><th scope=col>Athletes</th><th scope=col>sport</th><th scope=col>event</th><th scope=col>medals</th></tr>\n",
              "\t<tr><th scope=col>&lt;chr&gt;</th><th scope=col>&lt;chr&gt;</th><th scope=col>&lt;chr&gt;</th><th scope=col>&lt;chr&gt;</th></tr>\n",
              "</thead>\n",
              "<tbody>\n",
              "</tbody>\n",
              "</table>\n"
            ],
            "text/markdown": "\nA data.frame: 0 × 4\n\n| Athletes &lt;chr&gt; | sport &lt;chr&gt; | event &lt;chr&gt; | medals &lt;chr&gt; |\n|---|---|---|---|\n\n",
            "text/latex": "A data.frame: 0 × 4\n\\begin{tabular}{llll}\n Athletes & sport & event & medals\\\\\n <chr> & <chr> & <chr> & <chr>\\\\\n\\hline\n\\end{tabular}\n"
          },
          "metadata": {}
        },
        {
          "output_type": "stream",
          "name": "stdout",
          "text": [
            "'data.frame':\t0 obs. of  4 variables:\n",
            " $ Athletes: chr \n",
            " $ sport   : chr \n",
            " $ event   : chr \n",
            " $ medals  : chr \n"
          ]
        }
      ],
      "source": [
        "library(rvest)\n",
        "library(dplyr)\n",
        "library(robotstxt)\n",
        "library(stringr)\n",
        "\n",
        "\n",
        "l <-\"https://olympics.com/en/news/asian-games-2023-hangzhou-india-medals-tally-winners-table\"\n",
        "\n",
        "\n",
        "\n",
        "web<-read_html(l)\n",
        "View(web)\n",
        "\n",
        "\n",
        "Athletes<- web%>%html_nodes(\".kBHfZA:nth-child(4) td:nth-child(2) .text--body\")%>% html_text()\n",
        "View(Athletes)\n",
        "\n",
        "sport<- web%>%html_nodes(\".kBHfZA:nth-child(4) td:nth-child(3) .text--body\")%>% html_text()\n",
        "View(sport)\n",
        "\n",
        "event<- web%>%html_nodes(\".kBHfZA:nth-child(4) td:nth-child(4) .text--body\")%>% html_text()\n",
        "View(event)\n",
        "\n",
        "medals<- web%>%html_nodes(\".kBHfZA:nth-child(4) td:nth-child(5) .text--body\")%>% html_text()\n",
        "View(medals)\n",
        "\n",
        "games = data.frame(Athletes,sport,event,medals)\n",
        "View(games)\n",
        "\n",
        "write.csv(games,\"asian_games.csv\")\n",
        "\n",
        "str(games)"
      ]
    }
  ]
}