namespace обучалка
{
    class cl            
    {
        private 
        int maxspeed = 0;
        int speed = 0;
        int fuel = 0;
        int fuelpersec = 0;
        int maxfuel = 700;
        int height = 0;
        int maxheight = 900;
        
        public cl(int startfuel)        
        {
            fuel = startfuel;              
            Console.WriteLine("Диспетчерская.");
        }
        public void getfuel()       
        {
            fuel = maxfuel;
        public void morespeed(int a)
        {
            if speed + a < maxspeed 
            {
                speed = speed + a;
            }
            else
            {
                Console.WriteLine("Нельзя увеличить скорость на данное значение, превышает макс. скорость.");
            }
        }
        public void lessspeed(int a)
        {
            if speed - a > 0 
            {
                speed = speed - a;
            }
            else
            {
                speed = 0;
            }
            if speed < maxspeed*0,1
            {
                height = 0;
                Console.WriteLine("Слишком низкая скорость. Самолет упал и разбился =\.");
            }
        }
        public void moreheight(int a)
        {
            if height + a < maxspeed 
            {
                height = height + a;
            }
            else
            {
                Console.WriteLine("Нельзя увеличить высоту на данное значение, превышает макс. высоту.");
            }
        }
        public void lessheight(int a)
        {
            if height - a > 0 
            {
                height = height + a;
            }
            else
            {
                if speed > maxspeed*0,5
                {
                    height = 0;
                    Console.WriteLine("Самолет разбился.");
                }
                else
                {
                    height = 0;
                    Console.WriteLine("Самолет приземлился.");
                }
            }
        }
    }
    class Program  //базовый класс
    {
        static void Main(string[] args) //точка входа в программу
        {
            Console.WriteLine("старт");
            int n = Convert.ToInt32(Console.ReadLine());

            cl cl1 = new cl(n);         //создание экземпляра класса. тут мы используем конструктор с параметром
            cl cl2 = new cl();          //тут конструктор без параметров

            Console.WriteLine(cl1.MetN());      //
            Console.WriteLine(cl2.MetN());      //вызов методов 1 у обоих классов

            cl1.MetM(5);        //
            cl2.MetM(5);        //вызов второго метода у обоих экземпляров класса 

            Console.WriteLine("финиш");
            Console.ReadKey();
        }
    }
}