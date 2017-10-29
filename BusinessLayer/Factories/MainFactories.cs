using System;
using System.Data;

namespace ABCAutomotive.BusinessLayer
{
    public static class StudentFactory
    {

        public static Student Create()
        {
            return new Student();
        }

        public static Student Create(string studentid)
        {
            if (string.IsNullOrEmpty(studentid))
            {
                throw new ArgumentException("Student ID Is Empty");
            }

            //DataTable EmpTable = EmployeeSQL.Retrieve(studentid);
            //return Repackage(EmpTable.Rows[0]);
            return new Student();
        }

        private static Student Repackage(DataRow myRow)
        {
            Student myStudent = new Student();

            myStudent._trusted = true;

            return myStudent;
        }
    }
}
