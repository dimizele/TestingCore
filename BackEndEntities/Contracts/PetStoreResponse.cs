using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndEntities.Contracts
{
    public class PetStoreResponse : IEquatable<PetStoreResponse>
    {
        public int code;
        public string type;
        public string message;

        public bool Equals(PetStoreResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return code == other.code && type == other.type && message == other.message;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PetStoreResponse)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = code;
                hashCode = (hashCode * 397) ^ (type != null ? type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (message != null ? message.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
