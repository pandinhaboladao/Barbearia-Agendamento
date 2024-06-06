using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        private int linhas;
        private int colunas;
        private int proxima_linha; //Variavel para mudar para a proxima linha

        public Form2()
        {
            InitializeComponent();
            InitializeServicos(10, 2); //10 linhas e 2 colunas
        }

        private void InitializeServicos(int numLinhas, int numColunas)
        {
            linhas = numLinhas;
            colunas = numColunas;
            Global.servicos = new string[linhas, colunas];
            proxima_linha = 0; //Começa na linha 0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mensagem para quando chegar ao limite de serviços
            if (proxima_linha >= linhas)
            {
                MessageBox.Show("Este é o limite de serviços", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string servico = textBoxServico.Text;
            string preco = textBoxPreco.Text;

            //Adicionando os valores na prox linha disponivel
            Global.servicos[proxima_linha, 0] = servico;
            Global.servicos[proxima_linha, 1] = preco;
            proxima_linha++; //Indo para a prox linha

            textBoxServico.Clear();
            textBoxPreco.Clear();

            //Exibindo a tabela na listbox
            //Limpando listbox antes de add os servicos
            listBox1.Items.Clear();

            //Adicionado
            for (int i = 0; i < proxima_linha; i++)
            {
                string agendamento = $"{Global.servicos[i, 0]} R$ {Global.servicos[i, 1]}";
                listBox1.Items.Add(agendamento);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu_barbeiro menu_Barbeiro = new menu_barbeiro();
            menu_Barbeiro.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
