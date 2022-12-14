// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLSystem.Models
{
    [Table("Bog")]
    public partial class Bog
    {
        public Bog()
        {
            BogHolds = new HashSet<BogHold>();
            UnderviserBogs = new HashSet<UnderviserBog>();
        }

        [Key]
        [Column("Bog_id")]
        public int Bog_Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        [Required]
        [StringLength(30)]
        public string Forfatter { get; set; }
        public int Udgivelsesår { get; set; }
        [Column("ISBN")]
        public double ISBN { get; set; }
        [Required]
        [StringLength(256)]
        public string Billede { get; set; }

        [InverseProperty(nameof(BogHold.Bog))]
        public virtual ICollection<BogHold> BogHolds { get; set; }
        [InverseProperty(nameof(UnderviserBog.Bog))]
        public virtual ICollection<UnderviserBog> UnderviserBogs { get; set; }
    }
}