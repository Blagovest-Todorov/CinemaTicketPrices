using System;

namespace CinemaPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose from Options : Weekday or Weekend or Holiday");
            string dayType = Console.ReadLine();
            

            if (dayType != "Weekday" && dayType != "Weekend" && dayType != "Holiday")
            {
                Console.WriteLine("Please write a correct dayFormat");
            }
            else   // then the dayFormat is correct and we enter the new check  !
            {
               
                Console.Write("Please enter a integer number of your age : ");
                int age = int.Parse(Console.ReadLine());

                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error in ages , please enter a proper ageformat!");
                }
                else   // Then the age is correct age and by case we can calulate the priceTicket
                {
                    int priceTicket = 0;
                    if (dayType == "Weekday")
                    {
                        if (age >= 0 && age <= 18)
                        {
                            priceTicket = 12;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            priceTicket = 18;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            priceTicket = 12;
                        }

                    }
                    else if (dayType == "Weekend")
                    {
                        if (age >= 0 && age <= 18)
                        {
                            priceTicket = 15;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            priceTicket = 20;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            priceTicket = 15;
                        }

                    }
                    else if (dayType == "Holiday")
                    {
                        if (age >= 0 && age <= 18)
                        {
                            priceTicket = 5;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            priceTicket = 12;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            priceTicket = 10;
                        }
                    }
                    Console.WriteLine($"The Price of the ticket is : {priceTicket} $");
                    Console.WriteLine("Thank you for purchasing a ticket from us and have a nice day !");
                }   

            }            
        }
    }
}
