using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace VNPost.Models.Entity
{
    public class Location
    {
        public int Id { get; set; }
        public int DistricId { get; set; }
        [ForeignKey("DistricId")]
        public District District { get; set; }
        public int ParcelId { get; set; }
        [ForeignKey("ParcelId")]
        public Parcel Parcel { get; set; }
        public string Description { get; set; }
    }
}
