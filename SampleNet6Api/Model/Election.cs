using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleNet6Api.Model
{
    [Table("Election", Schema = "bits")]
    public partial class Election
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime ActiveDateFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime ActiveDateTo { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ElectionName { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime ElectionDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ElectionShortDescription { get; set; }
        public int ElectionTypeId { get; set; }
        public int ElectionStatusTypeId { get; set; }
        public int TableTeamCount { get; set; }
        public int ScanningTableCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        public int BallotCardCount { get; set; }
    }
}
