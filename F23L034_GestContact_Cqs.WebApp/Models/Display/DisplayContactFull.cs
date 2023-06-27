namespace F23L034_GestContact_Cqs.WebApp.Models.Display
{
#nullable disable
    public class DisplayContactFull
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime DateNaiss { get; set; }
#nullable enable
        public string? Tel { get; set; }
    }
}
