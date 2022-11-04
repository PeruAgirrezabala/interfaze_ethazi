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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupbox1_Load(object sender, EventArgs e)
        {
            using(var db = new PcBoxDbContext())
            {

                var mejoresClientes = db.res_partners.Where(b=>b.is_company==true && b.id!=1).OrderBy(c=>c.supplier_rank).ToArray();
                if (mejoresClientes!=null)
                {
                    Label[] bezeroakLabelArray = new Label[5];
                    bezeroakLabelArray.Append(label1);
                    bezeroakLabelArray.Append(label2);
                    bezeroakLabelArray.Append(label3);
                    bezeroakLabelArray.Append(label4);
                    bezeroakLabelArray.Append(label5);
                    for (int i = 0; i < bezeroakLabelArray.Length; i++)
                    {
                        bezeroakLabelArray[i].Text=mejoresClientes[i].ToString();

                    }
                }
            }
        }


    }
}
