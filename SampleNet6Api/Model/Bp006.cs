using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleNet6Api.Model
{
    [Keyless]
    [Table("BP006", Schema = "bits")]
    public partial class Bp006
    {
        public double? BatchNum { get; set; }
        [StringLength(255)]
        public string? BatchDate { get; set; }
        [StringLength(255)]
        public string? Blank { get; set; }
        [StringLength(255)]
        public string? ReceiveDate { get; set; }
        [StringLength(255)]
        public string? Blank2 { get; set; }
        [StringLength(255)]
        public string? Blank3 { get; set; }
        [StringLength(255)]
        public string? CreatedBy { get; set; }
        public double? Unprocessed { get; set; }
        [StringLength(255)]
        public string? Blank4 { get; set; }
        [StringLength(255)]
        public string? Blank5 { get; set; }
        public double? Accepted { get; set; }
        public double? Rejected { get; set; }
        [StringLength(255)]
        public string? Blank6 { get; set; }
        [StringLength(255)]
        public string? Blank7 { get; set; }
        [StringLength(255)]
        public string? Read { get; set; }
    }
}
