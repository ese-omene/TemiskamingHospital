﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HospitalProjectTeamThree.Data;
using System.ComponentModel;

namespace HospitalProjectTeamThree.Models
{
    public class LiveWaitTime
    {
        [Key]
        public int WaitUpdateId { get; set; }
        public DateTime DateandTime { get; set; }
        public enum WaitTimeDesc { [Description("LOW")] low, [Description("MEDIUM")] medium, [Description("HIGH")] high }
        public WaitTimeDesc CurrentWaitTime { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}