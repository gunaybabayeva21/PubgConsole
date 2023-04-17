using Pubg.Enum;
using Pubg.Enum1;
using Pubg.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubg.Models
{
    internal class Weapon
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public BullentType BullentType { get; set; }
        public FireType FireType { get; set; }

        public Stack<Bullent> Bullents { get; } = new Stack<Bullent>();


        public Weapon(string name, BullentType bullentType, int capacity)
        {
            _id++;
            Id = _id;
            Capacity = capacity;
            BullentType = bullentType;
            Name = name;

        }

        public (int count, BullentType bullentType) Fire()
        {
            Bullents.Pop();
            return (Bullents.Count, BullentType);
        }


        public Bullent PullTrigger()
        {
            if (Bullents.Count == 0)
            {
                Console.WriteLine("Gulle yoxdur");
                
            }

            return Bullents.Peek();


        }

        public void  Fill()
        {
            if (Capacity == Bullents.Count)
            {
                throw new Exception("capacity doldu");
            }
            for (int i = Bullents.Count; i < Capacity; i++)
            {
                Bullents.Push(new Bullent(BullentType));

            }
            Console.WriteLine("Dolduruldu");

        }

      public (int Count, Bullent bullent) Fire(FireType fireType) 
      {
            Bullent? bullent;
            switch (fireType) 
            {
                case FireType.tekli:
                    if (Bullents.TryPop(out bullent))
                    {
                        return (Bullents.Count, bullent);
                    }
                    throw new BullentNotException();

                case FireType.ikili:
                    if(Bullents.TryPop(out bullent))
                    {
                        return (Bullents.Count,bullent);
                    }
                    throw new BullentNotException();

                case FireType.hamisi:
                    if(!(Bullents.TryPop(out bullent)))
                    {
                        throw new BullentNotException();
                    }
                    while(Bullents.TryPop(out bullent)) { }
                    return (Bullents.Count,bullent);

                    default: throw new BullentNotException();

            }
        
      }

    }
    
}
