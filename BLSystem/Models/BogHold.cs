// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLSystem.Models
{
    [Table("BogHold")]
    public partial class BogHold
    {
        [Key]
        [Column("BogHold_id")]
        public int BogHold_Id { get; set; }
        [Column("Bog_id")]
        public int Bog_Id { get; set; }
        [Column("Hold_id")]
        public int Hold_Id { get; set; }

        [ForeignKey(nameof(Bog_Id))]
        [InverseProperty("BogHolds")]
        public virtual Bog Bog { get; set; }
        [ForeignKey(nameof(Hold_Id))]
        [InverseProperty("BogHolds")]
        public virtual Hold Hold { get; set; }
    }
}