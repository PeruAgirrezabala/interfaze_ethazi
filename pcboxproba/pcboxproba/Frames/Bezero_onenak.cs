using pcboxproba.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace pcboxproba.Frames
{
    public partial class Bezero_onenak : Form
    {


        public  string[] enpresak;
        public Bezero_onenak()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using(var db = new PcBoxDbContext())
            {

               var  mejoresClientes = db.res_partners.Where(b=>b.is_company==true && b.id!=1).OrderByDescending(c=>c.customer_rank).Select(b=>b.name).ToArray();
                enpresak = mejoresClientes;
                if( mejoresClientes != null)
                {

                    label1.Text = mejoresClientes[0].ToString();

                    label2.Text = mejoresClientes[1].ToString();

                    label3.Text = mejoresClientes[2].ToString();

                }

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ornitzaile_ezpezifiko form7 = new Ornitzaile_ezpezifiko();
            form7.label9.Text = enpresak[0].ToString();
            form7.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ornitzaile_ezpezifiko form7 = new Ornitzaile_ezpezifiko();
            form7.label9.Text = enpresak[1].ToString();
            form7.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ornitzaile_ezpezifiko form7 = new Ornitzaile_ezpezifiko();
            form7.label9.Text = enpresak[2].ToString();
            form7.Show();
            Visible = false;
        }

        private void atzera_button_Click(object sender, EventArgs e)
        {
            Main form3 = new Main();
            form3.Show();
            Visible=false;
        }
    }
}
