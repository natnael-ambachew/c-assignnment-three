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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        { }
                 private string p_name;

        public string product
        {
            get { return p_name; }
            set { p_name = product; lbl_n.Text = value; }
        }
        private int pricee;

        public int price
        {
            get { return pricee; }
            set { pricee = price; lbl_p.Text = value.ToString(); }
        }
    } 
    }
        


