using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorkFlowApplication.Models
{
    public class EntityModel
    {
        [Key]
        public int EntityID { get; set; }
        public int EntityOwner { get; set; }
        public string EntityCriteria { get; set; }
        public string ActionRequired { get; set; }
        public string ExitCriteria { get; set; }
        public DateTime? EntityCreatedDate { get; set; }
        public DateTime? EntityCloseDate { get; set; }
        public int EntityAge { get; set; }
        public int EntityApproved { get; set; }
    }
}