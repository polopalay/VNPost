using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace VNPost.Models.Entity
{
    public class Parcel
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Items { get; set; }
        [Required]
        public string PointAway { get; set; }
        [Required]
        public string Destination { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        [Required]
        public string CustomerInfo { get; set; }
        public string OtherInfo { get; set; }
    }
}
