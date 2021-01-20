using System;

namespace salaries
{
    public class Money
    {
        public Money()
        {
            this.Bonus = 100;
        }
        public double Salary { get; set; }

        public int Experience { get; set; }
       
        public int Bonus { get; set; }

        public void GetExp()
        {

            Console.Write("Enter salary:");
            this.Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus:");
            this.Bonus = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the experience of the worker?");
            this.Experience = Convert.ToInt32(Console.ReadLine());
     
            if (Experience <= 20)
                
            {
                for (int i = 0; i <= Experience; i++)
                    
                {
                    this.Salary = this.Salary + 5 % 100;
                    Console.WriteLine(this.Salary + this.Bonus);    
                }
                Console.WriteLine("Your salaries for {0} years are:", Experience);
            }
            else if( Experience >= 21 && Experience <=40)
            {
                for (int i = 0; i <=Experience; i++)

                {
                    this.Salary = this.Salary + 6 % 100;
                    Console.WriteLine(this.Salary + this.Bonus);
                }
                Console.WriteLine("Your salaries for {0} years are:", Experience);
            }

            Console.WriteLine("You have total earns of {0}лв for this experience", (Salary + Bonus) * Experience);



          
           

                
    
           
         


            
        }


          
        
        }





    }

