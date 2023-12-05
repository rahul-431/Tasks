using System;
namespace Task
{
    public class ProfileA:IProfileBuilder
    {
        Profile profile=new Profile();

        public void addAddress()
        {
            profile.Address="hetauda";
            // throw new NotImplementedException();
        }

        public void addAge()
        {
        
        }

        public void addEmailAddress()
        {
            profile.EmailAddress="rahulmijar11@gmail.com";
            // throw new NotImplementedException();
        }

        public void addFirstName()
        {
            profile.FirstName="Rahul";
            // throw new NotImplementedException();
        }

        public void addGender()
        {
            // thr/ow new NotImplementedException();
        }

        public void addLastName()
        {
            profile.LastName="Mijar";
            // throw new NotImplementedException();
        }

        public void addPhoneNumber()
        {
            // throw new NotImplementedException();
        }

        public void addUserId()
        {
            profile.UserId="101";
            // throw new NotImplementedException();
        }

        public Profile GetProfile()
        {
            return profile;
            // throw new NotImplementedException();
        }
    }
}