using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndEntities.Contracts
{
    public class Category : IEquatable<Category>
    {
        public long id;
        public string name;

        public bool Equals(Category other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return id == other.id && name == other.name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Category)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (id.GetHashCode() * 397) ^ (name != null ? name.GetHashCode() : 0);
            }
        }
    }
}
