using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndEntities.Contracts
{
    public class ContractEnums
    {
        public enum PetStatus
        {
            available,
            pending,
            sold
        }

        public enum OrderStatus
        {
            placed,
            approved,
            delivered
        }
    }
}
