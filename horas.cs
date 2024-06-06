using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using static AgendamentoServicos.Global;

namespace AgendamentoServicos
{
    public partial class Horarios : Form
    {
        private Dictionary<DayOfWeek, Tuple<TimeSpan, TimeSpan>> horarios = new Dictionary<DayOfWeek, Tuple<TimeSpan, TimeSpan>>();

        public Horarios()
        {
            InitializeComponent();
            InicializarHorarios();
            CarregarComboBoxHorarios();
        }

        private void InicializarHorarios()
        {
            horarios.Add(DayOfWeek.Sunday, Tuple.Create(new TimeSpan(10, 0, 0), new TimeSpan(14, 0, 0)));
            horarios.Add(DayOfWeek.Monday, Tuple.Create(new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0)));
            horarios.Add(DayOfWeek.Tuesday, Tuple.Create(new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0)));
            horarios.Add(DayOfWeek.Wednesday, Tuple.Create(new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0)));
            horarios.Add(DayOfWeek.Thursday, Tuple.Create(new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0)));
            horarios.Add(DayOfWeek.Friday, Tuple.Create(new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0)));
            horarios.Add(DayOfWeek.Saturday, Tuple.Create(new TimeSpan(9, 0, 0), new TimeSpan(16, 0, 0)));

            // Inicialize a matriz de horários
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    horariosPorDia[i, j] = new List<string>();
                }
            }
        }

        private void CarregarComboBoxHorarios()
        {
            foreach (var kvp in horarios)
            {
                ComboBox cbOpen = null;
                ComboBox cbClose = null;

                switch (kvp.Key)
                {
                    case DayOfWeek.Sunday:
                        cbOpen = comboBoxSundayOpen;
                        cbClose = comboBoxSundayClose;
                        break;
                    case DayOfWeek.Monday:
                        cbOpen = comboBoxMondayOpen;
                        cbClose = comboBoxMondayClose;
                        break;
                    case DayOfWeek.Tuesday:
                        cbOpen = comboBoxTuesdayOpen;
                        cbClose = comboBoxTuesdayClose;
                        break;
                    case DayOfWeek.Wednesday:
                        cbOpen = comboBoxWednesdayOpen;
                        cbClose = comboBoxWednesdayClose;
                        break;
                    case DayOfWeek.Thursday:
                        cbOpen = comboBoxThursdayOpen;
                        cbClose = comboBoxThursdayClose;
                        break;
                    case DayOfWeek.Friday:
                        cbOpen = comboBoxFridayOpen;
                        cbClose = comboBoxFridayClose;
                        break;
                    case DayOfWeek.Saturday:
                        cbOpen = comboBoxSaturdayOpen;
                        cbClose = comboBoxSaturdayClose;
                        break;
                }

                if (cbOpen != null && cbClose != null)
                {
                    for (int i = 0; i < 24; i++)
                    {
                        cbOpen.Items.Add(new TimeSpan(i, 0, 0).ToString(@"hh\:mm"));
                        cbClose.Items.Add(new TimeSpan(i, 0, 0).ToString(@"hh\:mm"));
                    }
                }
            }
        }

        private void Horarios_Load(object sender, EventArgs e)
        {

        }

        //Salvar horarios
        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBoxesAbertura = { comboBoxSundayOpen, comboBoxMondayOpen, comboBoxTuesdayOpen, comboBoxWednesdayOpen, comboBoxThursdayOpen, comboBoxFridayOpen, comboBoxSaturdayOpen };
            ComboBox[] comboBoxesFechamento = { comboBoxSundayClose, comboBoxMondayClose, comboBoxTuesdayClose, comboBoxWednesdayClose, comboBoxThursdayClose, comboBoxFridayClose, comboBoxSaturdayClose };

            for (int i = 0; i < 7; i++)
            {
                if (TimeSpan.TryParse(comboBoxesAbertura[i].SelectedItem?.ToString(), out TimeSpan horaAbertura) &&
                    TimeSpan.TryParse(comboBoxesFechamento[i].SelectedItem?.ToString(), out TimeSpan horaFechamento))
                {
                    if (horaFechamento < horaAbertura)
                    {
                        MessageBox.Show("A hora de fechamento deve ser maior que a hora de abertura.");
                    }
                    else
                    {
                        DateTime dataAtual = DateTime.Now.Date; // Data fixa (por exemplo, data atual)
                        DateTime horaAberturaDateTime = dataAtual.Add(horaAbertura);
                        DateTime horaFechamentoDateTime = dataAtual.Add(horaFechamento);

                        List<string> horarios = GerarHorarios(horaAberturaDateTime, horaFechamentoDateTime);

                        Global.HorariosGlobal[i] = new List<HorariosDias>();
                        Global.HorariosGlobal[i].Add(new HorariosDias(horaAberturaDateTime, horaFechamentoDateTime, horarios));

                        for (int hora = 0; hora < 24; hora++)
                        {
                            horariosPorDia[hora, i].Clear();
                        }

                        horariosPorDia[horaAbertura.Hours, i].AddRange(horarios);
                    }
                }
            }
        }

        //Listar os horarios
        private void button2_Click(object sender, EventArgs e)
        {
            listBoxHorarios.Items.Clear();
            ComboBox[] comboBoxesAbertura = { comboBoxSundayOpen, comboBoxMondayOpen, comboBoxTuesdayOpen, comboBoxWednesdayOpen, comboBoxThursdayOpen, comboBoxFridayOpen, comboBoxSaturdayOpen };
            ComboBox[] comboBoxesFechamento = { comboBoxSundayClose, comboBoxMondayClose, comboBoxTuesdayClose, comboBoxWednesdayClose, comboBoxThursdayClose, comboBoxFridayClose, comboBoxSaturdayClose };

            string[] dias = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };

            for (int i = 0; i < 7; i++)
            {
                if (TimeSpan.TryParse(comboBoxesAbertura[i].SelectedItem?.ToString(), out TimeSpan horaAbertura) &&
                    TimeSpan.TryParse(comboBoxesFechamento[i].SelectedItem?.ToString(), out TimeSpan horaFechamento))
                {
                    if (horaFechamento < horaAbertura)
                    {
                        MessageBox.Show("A hora de fechamento deve ser maior que a hora de abertura.");
                    }
                    else
                    {
                        DateTime dataAtual = DateTime.Now.Date; // Data fixa (por exemplo, data atual)
                        DateTime horaAberturaDateTime = dataAtual.Add(horaAbertura);
                        DateTime horaFechamentoDateTime = dataAtual.Add(horaFechamento);

                        List<string> horarios = GerarHorarios(horaAberturaDateTime, horaFechamentoDateTime);

                        foreach (string horario in horarios)
                        {
                            listBoxHorarios.Items.Add($"{dias[i]}: {horario}");
                        }
                    }
                }
            }
        }


        private List<string> GerarHorarios(DateTime horaAbertura, DateTime horaFechamento)
        {
            List<string> horarios = new List<string>();

            for (DateTime hora = horaAbertura; hora < horaFechamento; hora = hora.AddMinutes(30))
            {
                horarios.Add(hora.ToString("HH:mm"));
            }

            horarios.Add(horaFechamento.ToString("HH:mm"));

            return horarios;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu_barbeiro mb = new menu_barbeiro();
            mb.Show();
            this.Hide();
        }

        private void comboBoxWednesdayOpen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBoxHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSundayClose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMondayClose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTuesdayOpen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
