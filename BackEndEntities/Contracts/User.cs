using SupportClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndEntities.Contracts
{
    public class User : IEquatable<User>
    {
        public long id;
        public string username;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public string phone;
        public int userStatus;

        public readonly string UserEndPoint = $"/{nameof(User)}";

        public User(int userStatus = 0)
        {
            id = RandomDataGenerator.RandomLongNumber();
            username = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            firstName = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            lastName = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            email = RandomDataGenerator.RandomEmailAddress();
            password = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            phone = RandomDataGenerator.RandomStringOnlyNumbers(RandomDataGenerator.RandomNumber(9, 15));
            this.userStatus = userStatus;
        }

        public User(long id, string username, string firstName, string lastName, string email, string password, string phone, int userStatus)
        {
            this.id = id;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.userStatus = userStatus;
        }

        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return id == other.id && username == other.username && firstName == other.firstName && lastName == other.lastName && email == other.email && password == other.password && phone == other.phone && userStatus == other.userStatus;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = id.GetHashCode();
                hashCode = (hashCode * 397) ^ (username != null ? username.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (firstName != null ? firstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (lastName != null ? lastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (email != null ? email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (password != null ? password.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (phone != null ? phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ userStatus;
                return hashCode;
            }
        }
    }
}
