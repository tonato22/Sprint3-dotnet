namespace CheckInOutMotosApi.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}