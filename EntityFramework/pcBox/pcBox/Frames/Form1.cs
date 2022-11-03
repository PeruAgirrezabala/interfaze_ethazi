using pcBox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcBox
{
    public partial class pcBox : Form
    {
        public pcBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new PcBoxContext())
            {
                var saleOrderData = db.sale_order.GroupBy(b=>b.id).ToDictionary(g=>g.Key,g=>g.Sum(b=> b.amount_total));
                if(saleOrderData != null)
                {
                    if (saleOrderData.Count > 0)
                    {

                        var kontrolak = Form1.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var Kontrola in kontrolak)
                        {

                            Kontrola.DataSource = saleOrderData;
                            Kontrola.Series[0].YValueMembers = "Value";
                            Kontrola.Series[0].XValueMember = "Key";
                            Kontrola.DataBind();
                        }
                    }
                }
            }
        }


    }
}
