using System;
using System.Collections.Generic;

#nullable disable

namespace gameStore.Models
{
    public partial class Kosar
    {
        public int Id { get; set; }
        public int VasarloId { get; set; }
        public int JatekId { get; set; }
        public int Darab { get; set; }
    }
}
