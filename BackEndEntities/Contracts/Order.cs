using System;
using System.Collections.Generic;
using System.Text;
using static BackEndEntities.Contracts.ContractEnums;

namespace BackEndEntities.Contracts
{
    public class Order : IEquatable<Order>
    {
        public long id;
        public long petId;
        public int quantity;
        public string shipDate;
        public OrderStatus status;
        public bool complete;

        public bool Equals(Order other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return id == other.id && petId == other.petId && quantity == other.quantity && shipDate == other.shipDate && status == other.status && complete == other.complete;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Order)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = id.GetHashCode();
                hashCode = (hashCode * 397) ^ petId.GetHashCode();
                hashCode = (hashCode * 397) ^ quantity;
                hashCode = (hashCode * 397) ^ (shipDate != null ? shipDate.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)status;
                hashCode = (hashCode * 397) ^ complete.GetHashCode();
                return hashCode;
            }
        }
    }
}
