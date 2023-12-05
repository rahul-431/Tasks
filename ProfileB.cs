using System;
namespace Task
{
    public class ProfileB:IProfileBuilder
    {
        Profile profile=new Profile();

        public void addAddress()
        {
            profile.Address="Ktm";
            // throw new NotImplementedException();
        }

        public void addAge()
        {
            profile.Age=20;
        }

        public void addEmailAddress()
        {
            profile.EmailAddress="animesh@gmail.com";
            // throw new NotImplementedException();
        }

        public void addFirstName()
        {
            profile.FirstName="Animesh";
            // throw new NotImplementedException();
        }

        public void addGender()
        {
            profile.Gender=true;
            // throw new NotImplementedException();
        }

        public void addLastName()
        {
            profile.LastName="Dahal";
            // throw new NotImplementedException();
        }

        public void addPhoneNumber()
        {
            profile.PhoneNumber="9865410868";
            // throw new NotImplementedException();
        }

        public void addUserId()
        {
            profile.UserId="01001";
            // throw new NotImplementedException();
        }

        public Profile GetProfile()
        {
            return profile;
            // throw new NotImplementedException();
        }
    }
}