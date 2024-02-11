using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Doğukan";
person1.LastName = "Atar";
person1.DateOfBirthYear = 2002;
person1.tcNo = 12345678910;

PttManager pttmanager = new PttManager(new PersonManager());
pttmanager.GiveMask(person1);