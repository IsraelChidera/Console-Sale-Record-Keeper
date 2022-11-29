using RecordKeeperApp.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            
            

            while (true)
            {
                try
                {
                    _amount = Convert.ToInt32(Console.ReadLine());
                    if (_amount > minimumAmount && _amount>0)
                    {
                        Console.WriteLine("Amount =====> {0}", _amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. You can only pay installmental for products higher than" +
                            " N10000");
                        Console.Write("\nAmount to pay: ");
                        _amount = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Invalid inputs. Try again");
                    Console.Write("\nAmount to pay: ");                    
                }                
            }
            


        }
    }
}
