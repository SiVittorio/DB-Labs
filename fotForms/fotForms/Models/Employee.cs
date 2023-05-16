using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotForms.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string f_name { get; set; }
        public string m_name { get; set; }
        public string l_name { get; set; }
        public SqlDateTime reg_date { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}
