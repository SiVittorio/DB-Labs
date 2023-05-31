using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotForms.Models
{
    public class EmployeeInfo
    {
        public EmployeeInfo() { }

        public EmployeeInfo(int employeeId, int jobId, int rankId, int sciJobId, int mainWorkId)
        {
            EmployeeId = employeeId;
            JobId = jobId;
            RankId = rankId;
            SciJobId = sciJobId;
            MainWorkId = mainWorkId;
        }

        public int EmployeeId { get; set; }
        public int JobId { get; set; }
        public int RankId { get; set; }
        public int SciJobId { get; set; }
        public int MainWorkId { get; set; }

    }
}
