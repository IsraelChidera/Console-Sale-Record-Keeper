using RecordKeeperApp.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperApp.App.PartialClasses
{
    internal class RecordCollectionTwo
    {
    }

    public partial class CollectRecord:IRecordCollection
    {
        public void CollectRecords()
        {

            int minimumAmount = (int)PaymentMade.minimumPayment;
            int minimumLength = (int)PaymentMade.minuimumNameLength;

            Console.Write("\nName of buyer: ");
            _name = Console.ReadLine();

            while (true)
            {
                try
                {
                    if (_name?.Length >= minimumLength)
                    {
                        Console.WriteLine("Buyer's name =====> {0}", _name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Name is too short, Try again!");
                        _name = Console.ReadLine();
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a correct format");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }

            Console.Write("\nAmount to pay: ");
            _amount = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    if (_amount > minimumAmount)
                    {
                        Console.WriteLine("Amount =====> {0}", _amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. You can only pay installmental for products higher than" +
                            " N10000");
                        _amount = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid inputs. Try again");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid amount");
                    Console.WriteLine(e.ToString());
                    Console.Write("Amount owed: ");
                    _amount = Convert.ToInt32(Console.ReadLine());
                }
            }
            


        }
    }
}
