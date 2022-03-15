﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class MembershipType
    {
        [Key]
        public byte Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;
        public short SingUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}
