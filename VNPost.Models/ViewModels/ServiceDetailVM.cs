using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ServiceDetailVM
    {
        public ServiceDetailVM(Service service, List<ServiceDetail> serviceDetails)
        {
            Service = service;
            ServiceDetails = serviceDetails;
        }
        public Service Service { get; set; }
        public List<ServiceDetail> ServiceDetails { get; set; }
    }
}
