using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cookpad.Models;

namespace Cookpad
{
    public partial class Form1 : Form
    {
        private String erroreak, mezua;
        private int number;
        
        


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 2022;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new CookpadDbContext())
            {
                var botoaData = db.Botoa
                    .Include("Errezeta")
                    .Where(b => b.Urtea == comboBox1.Text)
                    .GroupBy(b => b.Errezeta.Izena)
                    .ToDictionary(g => g.Key, g => g.Count());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (nantxt.Text.Length != 9)
            {
                erroreak = erroreak + "NaN-a egoki sartu behar duzu.";
            }
            if (String.IsNullOrEmpty(izenatxt.Text))
            {
                erroreak = erroreak + "Izena bete egin behar duzu.";
            }
            if(String.IsNullOrEmpty(emailatxt.Text) && !(emailatxt.Text.Contains("@")))
            {
                erroreak = erroreak + "Egiaztatu emailak gutxienez @ bat duela eta ez dagoela hutsik";
            }
            if (String.IsNullOrEmpty(ezizenatxt.Text))
            {
                erroreak = erroreak + "Ezizena bete egin behar duzu.";
            }
            if(!(int.TryParse(errezetatxt.Text,out number))){
                erroreak = erroreak + "egiaztatu errezeta id-a ez dagoela hutsik eta zenbakia dela";
            }
            else
            {
                erroreak = izenatxt.Text + " zure botoa jaso dugu, eskerrik asko";

            }
            MessageBox.Show(erroreak);
            erroreak = "";
        }
    }
}
