using System;

namespace DemirbasApp.Models
{
    public class Cihaz
    {
        public int Id { get; set; }
        public DateTime AlimTarihi { get; set; }

        // null olmasın diye boş yazıyla başlatıyorum.
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string SeriNo { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
    }
}