using Pubg.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubg.Models
{
    internal class Bullent
    {
        private static int _id;
        public int Id { get; }
        public BullentType BullentType { get; }
        public Bullent(BullentType bullentType)
        {
            _id++;
            Id = _id;
            BullentType = bullentType;
        }
    }
    

}
