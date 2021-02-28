using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class LeftVM
    {
        public LeftVM(List<Columnist> columnists, int fatherId, int sonId)
        {
            Columnists = columnists;
            FatherId = fatherId;
            SonId = sonId;
        }

        public List<Columnist> Columnists { get; set; }
        public int FatherId { get; set; }
        public int SonId { get; set; }
    }
}
