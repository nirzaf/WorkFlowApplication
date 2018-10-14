using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkFlowApplication.Models
{
    public class WorkFlow
    {
        public int Work_Flow_ID { get; set; }
        [Key]
        public string Work_FlowName { get; set; }
        public string Work_Flow_Primary_Owner { get; set; }
        public string Work_Flow_Entry_Criteria { get; set; }
        public int Total_Entities { get; set; }
        public int Work_Flow_Status { get; set; }
    }
}