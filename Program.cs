namespace Lesson5Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random r = new Random();    

            int number = r.Next(); // - вызов действия Next(). - генерацию следующего рандомного числа
            Console.WriteLine(number);

            

            number = r.Next(100); // - устанавливаем верхний порог НЕ ВКЛЮЧИТЕЛЬНЫЙ! т.е, в данном случае - до 99
            Console.WriteLine(number);

            number = r.Next(5, 9); // - устанавливаем нижний и верхний порог через запятую. Нижний порог ВКЛЮЧИТЕЛЬНЫЙ! т.е, в данном случае - от 5
            Console.WriteLine(number);

            */
            /*

            Random rnd = new Random();

            int number;


            for (int q = 1; q <= 10; q++)
            {
                number = rnd.Next(0, 99);
                Console.WriteLine(number);
            }

            */

            Random rnd = new Random();

            int number = 1;
            int x0 = 0;
            int x1 = 0;
            int n = 0;
            int win0 =0;
            int win1 = 0;








            for (int i = 0; i <= 100; i++)
            {    
                    for (int q = 1; q <= 10000; q++)
                    {
                        number = rnd.Next(0, 10000);
                        if (number < 5000)
                        {
                            x0++;
                        }
                        else
                        {
                            x1++;
                        }                        
                    }
                if (x0 < x1)
                {
                    win0++;
                }
                else
                {
                    win1++;
                }
                Console.WriteLine(n + ":" + x0 + " " + x1);
                // Console.WriteLine("0 - " + x0 + "\n" + "1 - " + x1);

                

                n++;
            }

            Console.WriteLine("1 -" + win1 + "\n" + "0 - " + win0);
        }
    }
}