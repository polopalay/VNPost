using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ParcelViewModel
    {
        public int Id { get; set; }
        public string Items { get; set; }
        public string PointAway { get; set; }
        public string Destination { get; set; }
        public Status Status { get; set; }
        public string CustomerInfo { get; set; }
        public string OtherInfo { get; set; }
        public Location Location { get; set; }
    }
}
