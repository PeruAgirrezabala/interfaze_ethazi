using pcboxproba.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcboxproba.Frames
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string[] enpresak;
        private void Form8_Load(object sender, EventArgs e)
        {

                using (var db = new PcBoxDbContext())
                {

                    var mejoresProveedores = db.res_partners.Where(b => b.is_company == true && b.id != 1).OrderBy(c => c.supplier_rank).Select(b => b.name).ToArray();
                    enpresak = mejoresProveedores;
                    if (mejoresProveedores != null)
                    {

                        label1.Text = mejoresProveedores[0].ToString();

                        label2.Text = mejoresProveedores[1].ToString();

                        label3.Text = mejoresProveedores[2].ToString();

                    }


                }
            }

        private void atzera_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.label9.Text = enpresak[0].ToString();
            form5.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.label9.Text = enpresak[1].ToString();
            form5.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.label9.Text = enpresak[2].ToString();
            form5.Show();
            Visible = false;
        }
    }
}
