using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

        public List<Applicant> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().OrderBy(a => a.Name).ToList();
                    
                case ByAttribute.Surname:
                    return GetAllApplicants().OrderBy(a => a.Surname).ToList();

                case ByAttribute.DoB:
                    return GetAllApplicants().OrderBy(a => a.DoB).ToList();

                case ByAttribute.Course:
                    return GetAllApplicants().OrderBy(a => a.Course).ToList();
                    break;
            }

            //if we are here - something went wrong
            return null;
        }

        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().Where(a => a.Name.ToLower().StartsWith(value.ToLower())).ToList();
                case ByAttribute.Surname:
                    return GetAllApplicants().Where(a => a.Surname.ToLower().StartsWith(value.ToLower())).ToList();
            }

            //if we are here - something went wrong
            return null;
        }

    }
}
