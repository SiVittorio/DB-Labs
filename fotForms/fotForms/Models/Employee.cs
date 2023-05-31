using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotForms.Models
{
    public class Employee
    {
        public Employee() { }

        public Employee(string f_name, string? m_name, string l_name, string email, string phone)
        {
            this.F_name = f_name;
            this.Mid_name = m_name;
            this.L_name = l_name;
            this.Email = email;
            this.Phone = phone;
        }

        public Employee(int id, string f_name, string? mid_name, string l_name, SqlDateTime reg_date, string email, string phone)
        {
            Id = id;
            F_name = f_name;
            Mid_name = mid_name;
            L_name = l_name;
            Reg_date = reg_date;
            Email = email;
            Phone = phone;
        }

        public int Id { get; set; }
        public string F_name { get; set; }
        public string? Mid_name { get; set; }
        public string L_name { get; set; }
        public SqlDateTime Reg_date { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
    }
}
