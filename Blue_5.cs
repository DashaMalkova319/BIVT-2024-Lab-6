using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_5;

namespace Lab_6
{
    public class Blue_5
    {
        
        public struct Sportsman
        {
            //поля
            private string _name;
            private string _surname;
            private int _place;
            //свойства
            public string Name => _name;
            public string Surname => _surname;
            public int Place => _place;
            //конструктор(тоже метод)
            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }
            //методы
            public void SetPlace(int place)
            {
                if (_place == 0 && place >= 1) _place = place;

            }
            public void Print()
            {
                Console.WriteLine($"{_name}\t{_surname}\t{_place}");
            }
        }
        public struct Team
        {
            //поля
            private string _name;
            private Sportsman[] _sportsmen;
            private int _count;
            //свойства
            public string Name => _name;
            public Sportsman[] Sportsmen => _sportsmen;
            
            public int SummaryScore
            {
                get
                {
                    if(_sportsmen == null) return 0;
                    int sum = 0;
                    for( int i = 0; i < _sportsmen.Length; i++ )
                    {
                        if (_sportsmen[i].Place == 1) sum += 5;
                        else if(_sportsmen[i].Place == 2) sum += 4;
                        else if (_sportsmen[i].Place == 3) sum += 3;
                        else if (_sportsmen[i].Place == 4) sum += 2;
                        else if (_sportsmen[i].Place == 5) sum += 1;
                        else break;
                    }
                    return sum;
                }
            }
            public int TopPlace
            {
                get
                {
                    if ( _sportsmen == null) return 0;
                    int mini = 18;
                    for(int i = 0; i < _sportsmen.Length;i++ )
                    {
                        if(mini >  _sportsmen[i].Place && _sportsmen[i].Place > 0) mini = _sportsmen[i].Place;
                    }
                    return mini;
                }
            }
            //конструктор
            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _count = 0;
            }
            //методы
            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _count == 6) return;
                _sportsmen[_count] = sportsman;
                _count++;
            }
            public void Add(Sportsman[] sportsmen)
            {
                if (_sportsmen == null ) return;
                for(int i = 0 ; i < _sportsmen.Length ; i++ )
                {
                    Add(sportsmen[i]);
                }
            }
            public static void Sort(Team[] teams)
            {
                if (teams == null) return;
                for (int i = 0 ;i < teams.Length ; i++ )
                {
                    for(int j = 0 ;j < teams.Length - i - 1;j++ )
                    {
                        if (teams[j].SummaryScore < teams[j + 1].SummaryScore)
                        {
                            var temp = teams[j];
                            teams[j] = teams[j + 1];
                            teams[j + 1] = temp;
                        }
                        else if(teams[j].SummaryScore == teams[j + 1].SummaryScore && teams[j].TopPlace > teams[j + 1].TopPlace)
                        {
                            var temp = teams[j];
                            teams[j] = teams[j + 1];
                            teams[j + 1] = temp;
                        }
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{_name}");
                for(int i =0 ;i < _sportsmen.Length;i++ )
                {
                    _sportsmen[i].Print();
                }
                    
                Console.WriteLine(" ");
            }
        }
    }
}
