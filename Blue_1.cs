using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_1
    {
        public struct Response
        {
            //поля
            private string _name;
            private string _surname;
            private int _votes;

            //свойства
            public string Name => _name;
            public string Surname => _surname;  
            public int Votes => _votes;

            //конструктор
            public Response(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _votes = 0;
            }
            //методы
            public int CountVotes(Response[] responses)
            {
                if (responses == null) return 0;
                int count = 0;
                foreach (var response in responses)
                {
                    if (response.Name == _name && response.Surname == _surname) count++;
                }
                _votes = count;
                return count;
            }
       
            public void Print()
            {
                Console.WriteLine($"{Name}\t{Surname}\t{Votes}");
            }
        }
    }
}
