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
    public partial class main_container : Form
    {
        public main_container()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form2 form =new Form2();
            form.MdiParent = this;
            form.Show();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form9 form = new form9();
            form.Show();
            
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
         
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
