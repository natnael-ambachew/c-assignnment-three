using assgmt3.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assgmt3
{
    public partial class form9 : Form
    {
        public form9()
        {
            InitializeComponent();
        }

        private void form9_Load(object sender, EventArgs e)
        {
       foreach(var item in product.GetProducts())
            {
                UserControl1 p=new UserControl1();
                p.product=item.name;
                p.price = item.price;
                flowLayoutPanel1.Controls.Add(p);   

            }

        }
    }
}
