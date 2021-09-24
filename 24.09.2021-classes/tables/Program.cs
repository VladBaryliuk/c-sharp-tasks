using System;

namespace tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] Tables = {new Table(1,5), new Table(2,10), new Table(3,20)};

            bool isOpen = true;

            while(isOpen)
            {
                Console.WriteLine("cafe administration");

                for(int i = 0; i < Tables.Length;i ++)
                {
                   Tables[i].showInfo(); 
                }

                Console.Write("\nEnter the number of table ");
                int UserTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Enter number of places");
                int UserPlace = Convert.ToInt32(Console.ReadLine());

                Tables[UserTable].Reserve(UserPlace);

                Console.WriteLine("Enter 'Enter' to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    class Table
    {
        private int _number;
        private int _maxPlaces;
        private int _freePlaces;

        public Table(int number, int maxPlace)
        {
            _number = number;
            _maxPlaces = maxPlace;
            _freePlaces = maxPlace;
        }

        public void showInfo()
        {
            Console.WriteLine("table " + _number + " there are " + _freePlaces + " free places and " + _maxPlaces + " max places");
        }
        public void Reserve(int places)
        {
            bool isReserve = _freePlaces >= places;

            if(isReserve)
            {
                _freePlaces -= places;
                Console.WriteLine("your booking sucsecful");
            } 
            else
            {
               Console.WriteLine("booking mistake"); 
            } 
        } 
    }
}
