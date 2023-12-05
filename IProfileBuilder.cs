using System;
namespace Task
{
    public interface IProfileBuilder
    {
        void addUserId();
        void addEmailAddress();
        void addFirstName();
        void addLastName();
        void addAddress();
        void addGender();
        void addAge();
        void addPhoneNumber();     
        Profile GetProfile();
    }
    
}