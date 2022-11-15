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
    public partial class Produktu_erosienak : Form
    {
        public Produktu_erosienak()
        {
            InitializeComponent();
        }

        private void Produktu_erosienak_Load(object sender, EventArgs e)
        {
            using (var db = new PcBoxDbContext())
            {
                var purchase_data_dictionary = db.purchase_order_lines
                .Include("res_partner")
                .GroupBy(x => x.name)
                .OrderByDescending(x => x.Sum(b => b.product_uom_qty))
                .Take(5)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));


                if (purchase_data_dictionary != null)
                {
                    if (purchase_data_dictionary.Count > 0)
                    {
                        var grafikoa = grafikoaren_kontrola1.Controls
                        .OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var grafiko in grafikoa)
                        {
                            grafiko.Titles[0].Text = "Gehien erositako produktuak";
                            grafiko.DataSource = purchase_data_dictionary;
                            grafiko.Series[0].YValueMembers = "Value";
                            grafiko.Series[0].XValueMember = "Key";
                            grafiko.DataBind();
                        }
                    }
                }
            }
        }
    }
}
