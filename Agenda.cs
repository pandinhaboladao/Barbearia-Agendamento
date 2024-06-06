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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            AtualizarDataGridView(e.Start);
        }

        private void AtualizarDataGridView(DateTime data)
        {
            dataGridViewAgenda.Rows.Clear();
            int dia = data.Day - 1;

            ArrayList dia_agendar = (ArrayList)Global.agenda[dia];

            foreach (string[] agendamento in dia_agendar)
            {
                dataGridViewAgenda.Rows.Add(agendamento[0], agendamento[1], agendamento[2], agendamento[3], agendamento[4]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_barbeiro mb = new menu_barbeiro();
            mb.Show();
            this.Hide();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // Inicializar DataGridView
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            // Configurações adicionais de estilo (opcional)
            dataGridViewAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAgenda.MultiSelect = false;
            dataGridViewAgenda.ReadOnly = true;
        }
    }
}
