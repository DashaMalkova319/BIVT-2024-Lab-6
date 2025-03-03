using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_6
{
    public class Blue_2
    {
        public struct Participant
        {
            //поля
            private string _name;
            private string _surname;
            private int[,] _marks;
            //свойства
            public string Name => _name;
            public string Surname => _surname;
            
            public int[,] Marks
            {
                get
                {
                    if (_marks == null) return default(int[,]);
                    int[,] newMarks = new int[2, 5];
                    for (int i = 0; i < newMarks.GetLength(0); i++)
                    {
                        for (int j = 0; j < newMarks.GetLength(1); j++)
                        {
                            newMarks[i, j] = _marks[i, j];
                        }
                    }
                    return newMarks;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_marks == null) return 0;
                    int count = 0;
                    for (int i = 0; i < _marks.GetLength(0); i++)
                    {
                        for (int j = 0; j < _marks.GetLength(1); j++)
                        {
                            count += _marks[i, j];
                        }
                    }
                    return count;
                }
            }
            //конструктор
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[2, 5];
            }

            public void Jump(int[] result)
            {
                if (result == null || result.Length <= 5 || _marks == null) return;
                int s1 = 0;
                int s2 = 0;
                if (s1 == 0 && s2 == 0) // проверка на заполненность оценками
                {
                    for (int j = 0; j < _marks.GetLength(1); j++)
                    {
                        _marks[0, j] = result[j];
                        s1 += result[j];
                    }
                }
                else if (s2 == 0 && s1 != 0)
                {
                    for (int j = 0; j < _marks.GetLength(1); j++)
                    {
                        _marks[1, j] = result[j];
                        s2 += result[j];
                    }
                }

            }
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalScore < array[j + 1].TotalScore)
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
                Console.WriteLine($"{Name}\t{Surname}\t{TotalScore}");
            }
        }
    }
}
