using System;
namespace HDI.ExamProject.DashboardData.Dto
{
    public class ServiceRepairsDto
    {
        public Guid ServiceRepairId { get; set; }
        public string ServiceRepairName { get; set; }
        public long RepairCount { get; set; }
    }
}

