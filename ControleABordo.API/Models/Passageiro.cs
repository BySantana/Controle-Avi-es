namespace ControleABordo.API.Models
{
    public class Passageiro
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Years { get; set; }
        public long Phone { get; set; }
        public int VooId { get; set; }
        public Voo? Voo { get; set; }
    }
}
