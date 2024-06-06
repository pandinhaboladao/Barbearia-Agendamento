using System.Collections;
using AgendamentoServicos;

namespace AgendamentoServicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAgenda(31); //31 dias
            InitializeDateTimePicker();
        }

        private void InitializeAgenda(int dias)
        {
            Global.agenda = new ArrayList(dias);
            for (int i = 0; i < dias; i++)
            {
                Global.agenda.Add(new ArrayList());
            }
        }

        private void InitializeDateTimePicker()
        {
            // Defina o DateTimePicker para exibir o dia atual por padrão
            dateTimePickerData.Value = DateTime.Today;
            // Adicione um manipulador de evento para o evento ValueChanged do DateTimePicker
            dateTimePickerData.ValueChanged += dateTimePickerData_ValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxServicos();
        }

        private void ComboBoxServicos()
        {
            //Adicionando os serviços no combobox
            if (Global.servicos != null)
            {
                // Itera sobre as linhas da matriz Global.servicos
                for (int i = 0; i < Global.servicos.GetLength(0); i++)
                {
                    // Verifica se há um serviço e preço na linha atual
                    if (!string.IsNullOrEmpty(Global.servicos[i, 0]) && !string.IsNullOrEmpty(Global.servicos[i, 1]))
                    {
                        // Combina o serviço e o preço em uma única string
                        string servico_lista = $"{Global.servicos[i, 0]} - R${Global.servicos[i, 1]}";

                        comboBoxServico.Items.Add(servico_lista);
                    }
                }
            }
        }

        private void ComboBoxHorarios(DayOfWeek diaSemana)
        {
            // Limpe o ComboBox antes de adicionar os novos horários
            comboBoxHora.Items.Clear();

            if (Global.HorariosGlobal[(int)diaSemana] != null)
            {
                // Encontre os horários disponíveis para o dia da semana selecionado
                foreach (var horariosDia in Global.HorariosGlobal[(int)diaSemana])
                {
                    if (horariosDia != null)
                    {
                        // Adicione os horários disponíveis ao ComboBox
                        foreach (var horario in horariosDia.HorariosList)
                        {
                            if (horario != null)
                            {
                                comboBoxHora.Items.Add(horario);
                            }
                        }
                    }
                }
            }
        }

        private void dateTimePickerData_ValueChanged(object sender, EventArgs e)
        {
            ComboBoxHorarios(dateTimePickerData.Value.DayOfWeek);
        }

        private void buttonConfirmar_Click_1(object sender, EventArgs e)
        {
            // Verifica se as ComboBoxes de Hora e Serviço estão selecionadas
            if (comboBoxHora.SelectedItem == null || comboBoxServico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a hora e o serviço.");
                return;
            }

            // Pegando a data selecionada no DateTimePicker
            DateTime dataSelecionada = dateTimePickerData.Value;
            int dia = dataSelecionada.Day - 1; // dia - 1 para começar no índice 0

            // Coletando os dados dos controles do formulário
            string colunaData = dataSelecionada.ToString("dd/MM/yyyy"); // Formato da data
            string colunaHora = comboBoxHora.SelectedItem.ToString();
            string colunaServico = comboBoxServico.SelectedItem.ToString();
            string colunaNome = textBoxNome.Text.Trim();
            string colunaContato = textBoxContato.Text.Trim();

            // Verifica se os campos de nome e contato estão preenchidos
            if (string.IsNullOrEmpty(colunaNome) || string.IsNullOrEmpty(colunaContato))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Adicionando os valores a um array
            string[] info = new string[5];
            info[0] = colunaData;
            info[1] = colunaHora;
            info[2] = colunaServico;
            info[3] = colunaNome;
            info[4] = colunaContato;

            // Adicionando os valores à agenda global
            ArrayList diaAgendar = (ArrayList)Global.agenda[dia];
            diaAgendar.Add(info);

            // Limpando os campos do formulário
            textBoxNome.Clear();
            textBoxContato.Clear();

            // Adicionando as informações ao DataGridView
            dataGridViewAgenda.Rows.Add(colunaData, colunaHora, colunaServico, colunaNome, colunaContato);

            // Mostrando uma mensagem de confirmação com a data selecionada
            MessageBox.Show($"Agendamento confirmado para {colunaData}.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServico_TextUpdate(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void comboBoxServico_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
