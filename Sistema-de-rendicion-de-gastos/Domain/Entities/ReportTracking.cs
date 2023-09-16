﻿namespace Domain.Entities
{
    public class ReportTracking : BaseEntity
    {
        public required int EmployeeId { get; set; }

        public required int ReportId { get; set; }

        public Report? Report { get; set; }

        public required int ReportOperationId { get; set; }

        public ReportOperation? ReportOperation { get; set; }

        public DateTime? DateTracking { get; set; }
    }
}
