using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoServicos
{
    public class HorariosDias
    {
        public DateTime HoraAbertura { get; set; }
        public DateTime HoraFechamento { get; set; }
        public List<string> HorariosList { get; set; }

        public HorariosDias(DateTime horaAbertura, DateTime horaFechamento, List<string> horariosList)
        {
            HoraAbertura = horaAbertura;
            HoraFechamento = horaFechamento;
            HorariosList = horariosList;
        }
    }
}
