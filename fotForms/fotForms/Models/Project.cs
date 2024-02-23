using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotForms.Models
{
    public class Project
    {
        public Project() { }
        public Project(string name, string code, string clientName, string clientEmail, bool isFinished, DateTime beginDate, DateTime? endDate)
        {
            Name = name;
            Code = code;
            ClientName = clientName;
            ClientEmail = clientEmail;
            IsFinished = isFinished;
            BeginDate = beginDate;
            EndDate = endDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public bool IsFinished { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set;}
    }
}
