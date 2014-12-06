﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;

namespace BarcodeReader2
{
    public partial class Form1 : Form
    {
        private const double    SUGAR = 90,
                                FAT = 70,
                                SATURATES = 20,
                                SALT = 6,
                                KCAL = 2000,
                                KJ = 8374;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DEBUG CODE - Loads a local HTML file, as the webserver is slow
            //String HTMLDOC = System.IO.File.ReadAllText("C:\\test.html");
            //HtmlAgilityPack.HtmlDocument hDoc = new HtmlAgilityPack.HtmlDocument();
            //hDoc.LoadHtml(HTMLDOC);
            double iout;
            if (textBox1.Text.Length != 13 || !double.TryParse(textBox1.Text, out iout))
            {
                MessageBox.Show("Please enter a valid 13 digit EAN code.", "Error", MessageBoxButtons.OK);
                return;
            }

            lstatus.Text = "Loading webpage...";

            // UNCOMMENT FOR RELEASE VERSION
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument hDoc = hw.Load("http://www.ean-search.org/perl/ean-info.pl?ean=" + textBox1.Text);
            lstatus.Text = "Ready";
            if (hDoc.DocumentNode.InnerText == "Excessive use. Please come back tomorrow.Please use the XML-API for automated access.\n")
            {
                MessageBox.Show("Website error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hDoc.DocumentNode.SelectSingleNode("//title").InnerText == "No additional information")
            {
                MessageBox.Show("Sorry, we don't have that product in our database.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Finds the title
            l_title.Text = hDoc.DocumentNode.SelectSingleNode("//span[@data-title='true']").InnerText;

            // Finds the picture
            pictureBox1.ImageLocation = hDoc.DocumentNode.SelectSingleNode("//a[@class='toZoomImage']").GetAttributeValue("href", "");

            // Find nutritional data
            double temp = 0;
            foreach (HtmlNode hNode in hDoc.DocumentNode.SelectNodes("//th[@scope='row']"))
            {
                switch (hNode.InnerText)
                {
                    case "Energy":
                        l_energy.Text = RemoveUnits(hNode.NextSibling.InnerText, true);
                        if (double.TryParse(l_energy.Text, out temp))
                            l_energyGDA.Text = Math.Round((temp / KCAL) * 100) + "%";
                        break;

                    case "Fat":
                        l_fat.Text = RemoveUnits(hNode.NextSibling.InnerText, false);
                        if (double.TryParse(l_fat.Text, out temp))
                            l_fatGDA.Text = Math.Round((temp / FAT) * 100) + "%";
                        break;

                    case "Saturates":
                        l_saturates.Text = RemoveUnits(hNode.NextSibling.InnerText, false);
                        if (double.TryParse(l_saturates.Text, out temp))
                            l_saturatesGDA.Text = Math.Round((temp / SATURATES) * 100) + "%";
                        break;

                    case "Sugars":
                        l_sugars.Text = RemoveUnits(hNode.NextSibling.InnerText, false);
                        if (double.TryParse(l_sugars.Text, out temp))
                            l_sugarsGDA.Text = Math.Round((temp / SUGAR) * 100) + "%";
                        break;

                    case "Salt":
                        l_salt.Text = RemoveUnits(hNode.NextSibling.InnerText, false);
                        if (double.TryParse(l_salt.Text, out temp))
                            l_saltGDA.Text = Math.Round((temp / SALT) * 100) + "%";
                        break;

                    default:
                        break;
                }
            }
        }

        private static string RemoveUnits(string s, bool energy)
        {
            if (energy)
            {
                if (s.Contains("kJ") || s.Contains("kcal"))
                {
                    string output;

                    if (s.Contains("kJ") && s.Contains("kcal"))
                    {
                        output = System.Text.RegularExpressions.Regex.Replace(s, @"(kJ).*$", String.Empty);
                    }
                    else
                    {
                        if (s.Contains("kJ"))
                            output = s.Substring(0, s.Length - 2);
                        else
                            return s.Substring(0, s.Length - 4);
                    }

                    double i;

                    if (double.TryParse(output, out i))
                        return Math.Round(i * 0.238845897).ToString();
                    else
                        return "Not Applicable";
                }
                else
                {
                    return "Not Applicable";
                }
            }
            else
            {
                if (s.EndsWith("g"))
                    return s.Substring(0, s.Length - 1);
                else
                    return "Not Applicable";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
