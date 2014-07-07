namespace обучалка
{
    class cl            
    {
        private 
        int maxspeed = 0;
        int speed = 0;
        int fuel = 0;
        int fuelpersec = 0;
        
        public cl(int startfuel)        
        {
            fuel = startfuel;              
            Console.WriteLine("Диспетчерская.");
        }
        public void start()       
        {
            if (fuel > 0) do 
            {
                Console.WriteLine("Все системы запущены. Производится процедура взлета.");
            }
            else
            {
                Console.WriteLine("Отказ на взлет. Нету топлива.");
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