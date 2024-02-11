using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignManager : IApplicantService
    {
        void IApplicantService.ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        List<Person> IApplicantService.Getlist()
        {
            throw new NotImplementedException();
        }
    }
}
