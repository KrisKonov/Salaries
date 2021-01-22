using System;

namespace salaries
{

    class Money
    {


       public double Doo { get; set; }
        public double dzpo { get; set; }

        public double zdravno { get; set; }

        public double ddfl { get; set; }


        public double Salary { get; set; }

        public int Experience { get; set; }

        public double Bonus { get; set; }

        public double taxes{ get; set; }

        

        public void GetExp()
        {

            Console.Write("Enter salary:");
            this.Salary = double.Parse(Console.ReadLine());
            Console.Write("Enter bonus:");
            this.Bonus = double.Parse(Console.ReadLine());
            Console.Write("What is the experience of the worker?");
            this.Experience = int.Parse(Console.ReadLine());
            Doo = Salary * 8.38 / 100;
            dzpo = Salary * 2.20 / 100;
            zdravno = Salary * 3.20 / 100;
            taxes = taxes + Doo + dzpo + zdravno;
            Salary = Salary - taxes;
            ddfl = Salary * 10 / 100;

            for (int i = 1; i <= Experience; i++)
            {
                
                Console.WriteLine(Salary - ddfl);
                Salary = Salary + Salary * Bonus / 100;
          
            }

            Console.WriteLine("Total: {0}", (Salary - ddfl) * Experience);







        }




    }
}






