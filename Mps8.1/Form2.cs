using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mps8._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "adm" && textBox2.Text == "mps1234")
            {
               
                Form3 outra = new Form3(); outra.ShowDialog();

                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");

            }
        }
    }
}
	

