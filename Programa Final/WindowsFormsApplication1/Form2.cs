using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int a;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox2.Text);

            if ((a == 061136) && (textBox1.Text == "emorel") || 
                (a == 141225) && (textBox1.Text == "llluberes") ||
                (a == 121242) && (textBox1.Text == "agonzalez"))
            {

                Form1 abrir = new Form1();
                abrir.Show();

            }
            else {

                MessageBox.Show("Lo sentimos, el Nombre de Usuario o la Contraseña es incorrecto. Favor de verificar los datos ya mencionados e intentar nuevamente o intentar más tarde");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
