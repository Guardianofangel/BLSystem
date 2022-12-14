// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLSystem.Models
{
    [Table("UnderviserHold")]
    public partial class UnderviserHold
    {
        [Key]
        [Column("UnderviserHold_id")]
        public int UnderviserHoldId { get; set; }
        [Column("Underviser_id")]
        public int UnderviserId { get; set; }
        [Column("Hold_id")]
        public int HoldId { get; set; }

        [ForeignKey(nameof(HoldId))]
        [InverseProperty("UnderviserHolds")]
        public virtual Hold Hold { get; set; }
        [ForeignKey(nameof(UnderviserId))]
        [InverseProperty("UnderviserHolds")]
        public virtual Underviser Underviser { get; set; }
    }
}