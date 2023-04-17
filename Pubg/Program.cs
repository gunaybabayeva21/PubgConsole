using Pubg.Enum;
using Pubg.Enum1;
using Pubg.Models;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Weapon weapon;
        Bullent bullent;
        FireType fireType;


        List<Weapon> weapons = new List<Weapon>();

        Console.WriteLine("1.Creat Weapon");
        Console.WriteLine("2.Remove Weapon");
        Console.WriteLine("3.Get Weapon By Capacity");
        Console.WriteLine("4.Get weapon");
        Console.WriteLine("5.Select Weapson");
        Console.WriteLine();
        Console.WriteLine("----------------------");

        while (true)
        {
            Console.WriteLine("\n Enter command");
            int command = int.Parse(Console.ReadLine());
            switch (command)
            {
                case 1:
                   
                    Console.Write("Weapon's name: ");
                    string name = Console.ReadLine();

                    Console.Write("Weapon's capacity: ");
                    int capacity = int.Parse(Console.ReadLine());

                    Console.Write("Weapon's bullentType: ");
                    BullentType bullentsType = (BullentType)int.Parse(Console.ReadLine());
                    Weapon weapon1 = new Weapon(name, bullentsType, capacity);
                    weapons.Add(weapon1);
                    Console.WriteLine("------Weapon created!!!------");
                    break;

                case 2:
                    Console.WriteLine("Remove Weapon: ");
                    int Id = int.Parse(Console.ReadLine());
                    Weapon weaponIdRemove = weapons.Find(x => x.Id == Id);
                    if (weaponIdRemove != null)
                    {
                        weapons.Remove(weaponIdRemove);
                    }
                    else
                    {
                        Console.WriteLine("There is no weapon whit this Id ");

                    }
                    break;

                case 3:

                    Console.WriteLine("Get Weapon By Capacity :");
                    int Capacity = int.Parse(Console.ReadLine());
                    Weapon weapon3 = weapons.Find(n => n.Capacity > Capacity);
                    if (weapon3 != null)
                    {
                        
                            Console.WriteLine(weapon3.Name);
                    
                    }
                    else
                    {
                        Console.WriteLine("Weapon not found");
                    }
                    break;

                case 4:
                    Console.WriteLine("Get Weapons: ");
                    foreach (Weapon weapons1 in weapons)
                    {
                        Console.WriteLine($"{weapons1.Id}  {weapons1.Name} {weapons1.Capacity}  {weapons1.BullentType}  {weapons1.FireType}");
                    }
                    break;


                case 5:
                    Console.WriteLine("Select Weapon: ");
                   // int select = int.Parse(Console.ReadLine());
                    Console.WriteLine("Id:");
                    int id = int.Parse(Console.ReadLine());
                    weapon = weapons.Find(n => n.Id == id);
                    if (weapon == null)
                    {
                        throw new Exception();
                    }
                    int Select = int.Parse(Console.ReadLine());

                    switch (Select)
                    {
                        case 1:
                            Console.WriteLine("Fill:");
                            weapon.Fill();
                            break;
                        case 2:
                            Console.WriteLine("Fire: ");
                            weapon.Fire();
                            break;
                        case 3:
                            Console.WriteLine("PullTrigger:");
                            weapon.PullTrigger();
                            break;
                    }
                    break;

            }

        }
    }

}