using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendamentoServicos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Global.usuario &&
                textBox2.Text == Global.senha)
            {
                menu_barbeiro mb = new menu_barbeiro();
                mb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("O usuário ou a senha está errada");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu_barbeiro mb = new menu_barbeiro();
            mb.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
