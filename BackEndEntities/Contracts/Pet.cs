using System;
using System.Collections.Generic;
using System.Text;
using static BackEndEntities.Contracts.ContractEnums;

namespace BackEndEntities.Contracts
{
    public class Pet : IEquatable<Pet>
    {
        public long id;
        public Category category;
        public string name;
        public List<string> photoUrls;
        public List<Tag> tags;
        public PetStatus status;

        public readonly string PetEndPoint = $"/{nameof(Pet)}";

        public bool Equals(Pet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return id == other.id && Equals(category, other.category) && name == other.name && Equals(photoUrls, other.photoUrls) && Equals(tags, other.tags) && status == other.status;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Pet)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = id.GetHashCode();
                hashCode = (hashCode * 397) ^ (category != null ? category.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (name != null ? name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (photoUrls != null ? photoUrls.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (tags != null ? tags.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)status;
                return hashCode;
            }
        }
    }
}
