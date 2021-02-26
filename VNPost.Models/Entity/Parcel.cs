using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Parcel
    {
        public int Id { get; set; }
        public string Items { get; set; }
        public string PointAway { get; set; }
        public string Destination { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        public string CustomerInfo { get; set; }
        public string OtherInfo { get; set; }
    }
}
