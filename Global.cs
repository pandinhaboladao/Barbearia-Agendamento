using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoServicos
{
    internal class Global
    {
        //Matriz para a agenda
        public static ArrayList agenda;

        //Matriz para os serviços
        public static string[,] servicos;

        //Lista para os horários
        public static List<HorariosDias>[] HorariosGlobal = new List<HorariosDias>[7];
        //Lista para os horários por dia
        public static List<string>[,] horariosPorDia = new List<string>[24, 7];

        //Login
        public static string usuario;
        public static string senha;

    }
}
