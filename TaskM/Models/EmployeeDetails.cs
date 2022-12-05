using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskM.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int Id { get; set; }
        public string Project { get; set; }
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MID { get; set; }
        public string EmployeeName { get; set; }
    }
}
