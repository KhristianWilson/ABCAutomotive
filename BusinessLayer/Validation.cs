using ABCAutomotive.Types;
using System.Data;
using System.Text.RegularExpressions;

namespace ABCAutomotive.BusinessLayer
{
    public static class Validation
    {

        #region Input Validating

        public static bool checkLength(string s, int length, SizeOperator sizechoice)
        {
            if (sizechoice == SizeOperator.CanBeLessThan)
            {
                if (s.Length > length)
                {
                    return false;
                }
            }
            else
            {
                if (s.Length != length)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool checkPostalCode(string postalCode)
        {
            var matches = Regex.Match(postalCode, @"^([a-zA-Z]\d[a-zA-Z]( )?\d[a-zA-Z]\d)$");
            return matches.Success;
        }

        public static bool checkPhoneNumber(string phone)
        {
            var matches = Regex.Match(phone, (@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$"));
            return matches.Success;
        }

        public static bool validStudent(Student student)
        {
            if(student.balanceDue > 0)
            {
                throw new ConstraintException("Student Maintains A Balance Higher Then $0.00");
            }
            if(student.status == StudentStatus.Inactive)
            {
                throw new ConstraintException("Student Is Inactive");
            }
            return true;
        }

        public static bool validReserve(Resource resource)
        {
            if(resource.resourceStatus == ResourceStatus.NotAvailable)
            {
                throw new ConstraintException("Resource Is Not Available");
            }
            if (resource.reserveStatus == ReserveStatus.Reserved)
            {
                throw new ConstraintException("Resource Is Reserved");
            }
            return true;
        }

        public static bool validDelete(Student student)
        {
            if (student.balanceDue > 0)
            {
                throw new ConstraintException("Cannot Delete Student Owning More then 0.00");
            }
            return true;
        }

        #endregion

    }
}
