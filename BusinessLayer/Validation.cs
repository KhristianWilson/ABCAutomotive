using ABCAutomotive.Types;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;

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

        #endregion

        #region Object Validating 

        public static bool validStudent(Student student)
        {
            if(student.balanceDue > 0)
            {
                throw new ConstraintException("Student maintains a balance higher then $0.00");
            }
            if(student.status == StudentStatus.Inactive)
            {
                throw new ConstraintException("Student is inactive");
            }
            return true;
        }

        public static bool validReserve(Resource resource)
        {
            if(resource.resourceStatus == ResourceStatus.NotAvailable)
            {
                throw new ConstraintException("Resource is not available");
            }
            if (resource.reserveStatus == ReserveStatus.Reserved)
            {
                throw new ConstraintException("resource is reserved");
            }
            return true;
        }

        #endregion

        #region Status Checks

        public static bool validDelete(Student student)
        {
            if (student.balanceDue > 0)
            {
                throw new ConstraintException("Cannot delete student owning more then 0.00");
            }
            return true;
        }

        public static bool ownsBalnce(Student student)
        {
            if (student.balanceDue <= 0)
            {
                throw new ConstraintException("Student has no outstanding fees");
            }
            return true;
        }

        public static bool activeResource(Resource resource)
        {
            if(resource.resourceStatus != ResourceStatus.Available)
            {
                throw new ConstraintException("Resource is not available");
            }
            return true;
        }

        public static bool checkreserved(Student student, Resource resource)
        {
            if(resource.reserveStatus == ReserveStatus.Reserved)
            {
                if(resource.reserveingStudent != student.studentid)
                {
                    throw new ConstraintException("Resource is reserved by another student");
                }
            }
            return true;
        }

        public static bool validResourceCheckout(List<LoansLookup> loans, BindingList<LoanItem> cart, Resource resource)
        {
            foreach(LoansLookup loan in loans)
            {
                if(loan.ResourceType == resource.resourceType)
                {
                    throw new ConstraintException("Student already has loan for type " + resource.resourceType);
                }
            }
            foreach (LoanItem loan in cart)
            {
                if (loan.resourceType == resource.resourceType)
                {
                    throw new ConstraintException("Cart already contains resource type " + resource.resourceType);
                }
            }
            return true;
        }

        #endregion

    }
}
