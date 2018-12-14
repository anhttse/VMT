using System;
using System.Collections.Generic;

namespace VMT.Models
{
    public partial class HangHoa
    {
        public HangHoa()
        {
            VanChuyen = new HashSet<VanChuyen>();
        }

        public int Id { get; set; }
        public string Ref { get; set; }
        public string Ten { get; set; }
        public decimal? Gia { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<VanChuyen> VanChuyen { get; set; }
    }
}
