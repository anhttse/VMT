using System;
using System.Collections.Generic;

namespace VMT.Models
{
    public partial class VanChuyen
    {
        public decimal Id { get; set; }
        public string Ref { get; set; }
        public int? HangHoaId { get; set; }
        public string HangHoaRef { get; set; }
        public int? XeId { get; set; }
        public string XeRef { get; set; }
        public string BienSoXe { get; set; }
        public int SoChuyen { get; set; }
        public DateTime? NgayVanChuyen { get; set; }
        public string GhiChu { get; set; }

        public virtual HangHoa HangHoa { get; set; }
        public virtual Xe Xe { get; set; }
    }
}
