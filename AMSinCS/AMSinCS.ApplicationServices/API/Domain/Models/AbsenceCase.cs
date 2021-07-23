using AMSinSC.DataAccess.Entities;
using System;

namespace AMSinCS.ApplicationServices.API.Domain.Models
{
    public class AbsenceCase
    {
        public int Id { get; set; }

        public User User { get; set; }

        public User HeadTeacher { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public PartDayType PartDayType { get; set; }

        public string AbsenceReason { get; set; }

        public string UserComment { get; set; }

        public ActionStatus IsCoverRequired { get; set; }

        public ActionStatus IsCoverProvided { get; set; }

        public string CoverSupervisorComment { get; set; }

        public ActionStatus IsApprovedByHeadTeacher { get; set; }

        public ActionStatus IsAbsencePaid { get; set; }

        public string HeadTeacherComment { get; set; }

        public string HrSupervisorComment { get; set; }

        public ActionStatus IsCaseResolved { get; set; }

        public DateTime ResolvedDate { get; set; }
    }
}
