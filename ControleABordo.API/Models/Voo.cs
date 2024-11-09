using ControleABordo.API.Utils.Enums;

namespace ControleABordo.API.Models
{
    public class Voo
    {
        public int Id { get; set; }
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public ECompanhiasAereas CompanhiaAerea { get; set; }
        public DateTime Date { get; set; }
        public IList<Passageiro> Passageiros { get; set; } = [];
    }
}
