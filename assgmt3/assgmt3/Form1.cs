using assgmt3.model;
using System.Text.RegularExpressions;
namespace assgmt3
{
    public partial class Form1 : Form
    {
        public Form1(string a)
        {
            InitializeComponent();
            lbladmin.Text = a;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            
            
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                errorProvider1.SetError(txt_name, "name is required");
            }
            Regex x = new Regex(@"^1-9");
            if (x.IsMatch(txt_name.Text))
            {
               
                
                errorProvider1.SetError(txt_name, "name is not in proper format");
            }
            else 
            {
                d1.Text = d1.Value.ToString();
                product c = new product { name = txt_name.Text, Id = int.Parse(txt_id.Text), coast = int.Parse(txt_coast.Text), price = int.Parse(txt_price.Text), number = int.Parse(txtt_number.Text), date = d1.Text,is_available=chkav.Checked };
                MessageBox.Show("the product  " + txt_name.Text + "  is successfuly saved");
                c.save();
                dd.DataSource = product.GetProducts();

            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
            errorProvider1.Clear();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}