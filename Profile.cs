using System;
using System.Dynamic;
namespace Task{
    public class Profile
    {
        public string UserId{get;set;}
        public string EmailAddress{get;set;}
        public string FirstName{set; get;}
        public string LastName{get;set;}
        public string PhoneNumber{get;set;}
        public string Address{get;set;}  
        public int Age{get;set;}
        public bool Gender{get;set;} 
        public void Display()
        {
            Console.WriteLine($"User Id: {UserId}\n EmailAddress: {EmailAddress}\n FistName: {FirstName}\n LastName: {LastName}\n PhoneNumber: {PhoneNumber}\n Address:{Address}\n Age:{Age}\n Gender:{Gender}");
        }
    }
}
