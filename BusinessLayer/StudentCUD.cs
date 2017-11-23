using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;

namespace ABCAutomotive.BusinessLayer
{
    public static class StudentCUD
    {
        public static bool Delete(int studentID)
        {
            if (Validation.checkLength(studentID.ToString(), 8, SizeOperator.MustBeEqualTo)) 
            {
                return StudentSQL.Delete(studentID);
            }
            else
            {
                throw new ArgumentException("Invalid Student ID structure");
            }
        }

        public static bool Update(Student student)
        {
            if (student.IsClean)
            {
                return StudentSQL.Update(student);
            }
            else
            {
                throw new ArgumentException("Student must have all infomation");
            }
        }

        public static bool Insert(Student student)
        {
            if (student.IsClean)
            {
                bool returnvalue = StudentSQL.Insert(student);
                student._trusted = true;
                return returnvalue;
            }
            else
            {
                throw new ArgumentException("Student must have all infomation");
            }
        }
    }
}
