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
            var matches = Regex.Match(phone, "^[0-9]{10,12}$");
            return matches.Success;
        }

        public static bool validStudent(StudentLookup student)
        {
            if(student.Balance > 0)
            {
                throw new ConstraintException("Student Maintains A Balance Higher Then $0.00");
            }
            if(student.Status == StudentStatus.Inactive)
            {
                throw new ConstraintException("Student Is Inactive");
            }
            return true;
        }

        public static bool validReserve(ResourceLookup resource)
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

        #endregion

    }
}
