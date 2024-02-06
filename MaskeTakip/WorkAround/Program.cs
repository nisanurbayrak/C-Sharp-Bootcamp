using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Nisa";
person1.LastName = "Bayrak";
person1.NationalIdentity = 1243;
person1.DateOFBirthYear = 2001;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

