﻿using System.ComponentModel.DataAnnotations;

namespace APIB2.Data
{
    public class HangHoa
    {
        [Key]
        public Guid MaHh { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenHh { get; set; }
        public string MoTa { get; set; }

        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
    }
}
