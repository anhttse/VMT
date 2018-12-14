using System;
using System.Collections.Generic;

namespace VMT.Models
{
    public partial class Xe
    {
        public Xe()
        {
            VanChuyen = new HashSet<VanChuyen>();
        }

        public int Id { get; set; }
        public string Ref { get; set; }
        public string BienSoXe { get; set; }
        public string HangXe { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<VanChuyen> VanChuyen { get; set; }
    }
}
