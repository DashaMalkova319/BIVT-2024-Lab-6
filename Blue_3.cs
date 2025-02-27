using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            //поля
            private string _name;
            private string _surname;
            private int[] _penaltyTimes;

            //свойства
            public string Name => _name;
            public string Surname => _surname;
            public int[] PenaltyTimes
            {
                get
                {
                    if (_penaltyTimes == null) return default(int[]);
                    int[] newPenaltyTimes = new int[_penaltyTimes.Length];
                    Array.Copy(_penaltyTimes, newPenaltyTimes, _penaltyTimes.Length);
                    return newPenaltyTimes;
                }
            }
            //все время штрафных
            public int TotalTime
            {
                get
                {
                    if (_penaltyTimes == null) return 0;
                    int count = 0;
                    for(int i = 0;  i < _penaltyTimes.Length; i++)
                    {
                        count += _penaltyTimes[i];
                    }
                    return count;
                }
            }
            //есть или нет штрафа 10 мин(исключен или нет)
            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return true;
                    for (int i = 0; i < _penaltyTimes.Length; i++)
                    {
                        if (_penaltyTimes[i] == 10) return false;
                    }
                    return true;
                }
            }
            //Конструктор
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = new int[0];
            }
            //методы

            public void PlayMatch(int time)
            {
                if (_penaltyTimes == null) return;
                int[] New = new int[_penaltyTimes.Length + 1];
                Array.Copy(_penaltyTimes, New, _penaltyTimes.Length);
                New[_penaltyTimes.Length] = time;  //добавляем штрафной
                _penaltyTimes = New;

            }
            //сортируем по возрастанию по сумме штрафных
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0;i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalTime > array[j + 1].TotalTime)
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{Name}\t{Surname}\t{TotalTime}\t{IsExpelled}");
            }
        }

    }
}
