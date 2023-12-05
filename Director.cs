using System;
using System.Security.Principal;
namespace Task
{
    public class Director
    {
        public void construct(IProfileBuilder builder)
        {
            builder.addUserId();
            builder.addPhoneNumber();
            builder.addEmailAddress();
            builder.addPhoneNumber();
            builder.addFirstName();
            builder.addLastName();
            builder.addGender();
            builder.addAge();
        }
    }
}