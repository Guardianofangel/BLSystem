﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLSystem.Models
{
    [Table("Uddannelse")]
    public partial class Uddannelse
    {
        [Key]
        [Column("Uddannelse_id")]
        public int UddannelseId { get; set; }
        [Required]
        [Column("Uddannelse_navn")]
        [StringLength(50)]
        public string UddannelseNavn { get; set; }
    }
}