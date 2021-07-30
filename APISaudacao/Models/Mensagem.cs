using System;

namespace APISaudacao.Models
{
    public class Mensagem
    {
        public string Saudacao { get; set; }
        public string Horario { get; init; } = $"{DateTime.Now:HH:mm:ss}";
        public string InicioTrabalho { get; init; } = new TimeOnly(09, 30).ToString();
        public string ProximoFeriado { get; init; } = new DateOnly(2021, 09, 07).ToString();
    }
}