using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Department
{
    public class Department
    {
        private static int id;
        public int StaffID {  get; set; }
        public  int DepartmentID { get; }
        public string Departmentname { get; set; }
        public string BuildName {  get; set; }
        public int FloorNumber {  get; set; }
        public int capacity {  get; set; }
        public string description {  get; set; }
        public Department()
        {
            id++;
            DepartmentID = id;
        }
    }
}
