using System;

namespace salaries
{

    class Money
    {

        public double Salary { get; set; }

        public int Experience { get; set; }

        public double Bonus { get; set; }

        public void GetExp()
        {

            Console.Write("Enter salary:");
            this.Salary = double.Parse(Console.ReadLine());
            Console.Write("Enter bonus:");
            this.Bonus = double.Parse(Console.ReadLine());
            Console.Write("What is the experience of the worker?");
            this.Experience = int.Parse(Console.ReadLine());

            if (Experience <= 20)
            {
                for (int i = 1; i <= Experience; i++)
                {
                    Console.WriteLine(Salary);

                    Salary = Salary + Salary * Bonus / 100;
                }
                Console.WriteLine("You have earned {0} for this period of time", Salary * Experience);

            }
        }




    }
}






