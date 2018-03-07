﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TalentAcquisition.Core.Domain
{
    public class Interview
    {
        public Interview()
        {
            TeamMembers = new HashSet<Employee>();
        }
        [Key]
        public int InterviewID { get; set; }
        public int JobRequisitionID { get; set; }
        public int JobApplicationID { get; set; }
        public int OfficePositionID { get; set; }
        public string SchedulingFinalNote { get; set; }
        public DateTime ProposedDate1 { get; set; }
        public DateTime ProposedDate2 { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public virtual InterviewDetail InterviewDetails {get;set;}
        public virtual ICollection<Employee> TeamMembers { get; set; }
    }

}