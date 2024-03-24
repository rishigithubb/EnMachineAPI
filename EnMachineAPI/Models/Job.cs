using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnMachineAPI.Models
{
    public class JobList
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string AssignEngineerName { get; set; }
        public string PhoneNumber { get; set; }
        public string JobStatus { get; set; }
        public DateTime JobCreated { get; set; }
            

    }

}