using EFCF.Context;
using System;
using EFCF.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUD
    {
        public void AddNewDept()
        {
            using (var context = new EmployeeManagement())
            {
                var dept = new Dept()
                {
                    Deptno = 10,
                    Dname = "IT"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            }
        }
        public void UpdateDept()
        {
            var context = new EmployeeManagement();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            seldept.Dname = "CS";
            context.SaveChanges();
        }
        public void DeleteDept()
        {
            var context = new EmployeeManagement();                 
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);

            context.Depts.Remove(seldept);
            context.SaveChanges();

        }
        /*
          public void AddEmp()
        {
            using (var context = new EmployeeManagement())
            {
               

                var emp = new Emp()
                {
                    Empno = 2,
                    Empname = "kiruba",
                    Deptno = 10
                };
                context.Emps.Add(emp);
                context.SaveChanges();


            }
        }
        public void UpdateEmp()
        {
            var context = new EmployeeManagement();
            var selectedEmp = context.Emps.FirstOrDefault(d => d.Deptno == 10);
            selectedEmp.Empname = "CS";
            context.SaveChanges();
        }
        public void DeleteEmp()
        {
            var context = new EmployeeManagement();

            var selectedEmp = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            context.Depts.Remove(selectedEmp);
            context.SaveChanges();
        } 
         */



    }
}
