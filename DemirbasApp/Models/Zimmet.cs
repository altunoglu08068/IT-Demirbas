using System;


namespace DemirbasApp.Models
{
    public class Zimmet
    {
        public int Id { get; set; } // Zimmet ID
        public int CihazId { get; set; }
        public Cihaz Cihaz { get; set; } = null!;
        public DateTime VerilmeTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
    }
}