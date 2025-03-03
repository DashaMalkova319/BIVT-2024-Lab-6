using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Lab_6.Blue_5;

namespace Lab_6
{
    public class Blue_4
    {
        public struct Team
        {
            //поля
            private string _name;
            private int[] _scores;
            //свойства
            public string Name => _name;
            public int[] Scores
            {
                get
                {
                    if (_scores == null) return default(int[]);
                    int[] newScores = new int[_scores.Length];
                    Array.Copy(_scores, newScores, _scores.Length);
                    return newScores;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_scores == null) return 0;
                    int count = 0;
                    for (int i = 0; i < _scores.Length; i++)
                    {
                        count += _scores[i];
                    }
                    return count;
                }
            }
            //конструктор
            public Team(string name)
            {
                _name = name;
                _scores = new int[0];
            }
            //методы
            public void PlayMatch(int result)
            {
                if (_scores == null) return;
                int[] New = new int[_scores.Length + 1];
                Array.Copy(_scores, New, _scores.Length);
                New[_scores.Length] = result;
                _scores = New;
            }
            public void Print()
            {
                Console.WriteLine($"{_name}\t{TotalScore}");
               
            }

        }
        public struct Group
        {
            //конструктор
            private string _name;
            private Team[] _teams;
            private int _count;

            //свойства
            public string Name => _name;
            public Team[] Teams => _teams;
            
            //конструктор
            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _count = 0;
            }
            //методы
            public void Add(Team team)
            {
                if (_teams == null || _count >= 12) return;
                else
                {
                    _teams[_count] = team;
                    _count++;
                }
            }
            public void Add(Team[] teams)
            {
                if (_teams == null) return;

                for (int i = 0; i < teams.Length; i++)
                {
                    Add(teams[i]);
                }
            }
            public void Sort()
            {
                if (_teams == null) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j + 1].TotalScore)
                        {
                            var temp = _teams[j];
                            _teams[j] = _teams[j + 1];
                            _teams[j + 1] = temp;
                        }
                    }
                }
            }
            public static Group Merge(Group group1, Group group2, int size)
            {
                Group finaly = new Group("Финалисты");
                int i = 0, j = 0;
                while (i < size / 2 && j < size / 2)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        finaly.Add(group1.Teams[i++]);
                    }
                    else
                    {
                        finaly.Add(group2.Teams[j++]);
                    }
                }
                while (i < size / 2)
                    finaly.Add(group1.Teams[i++]);
                while (j < size / 2)
                    finaly.Add(group2.Teams[j++]);
                return finaly;

            }

            public void Print()
            {
                Console.Write($"{_name}: ");
                for (int i = 0; i < _teams.Length; i++)
                {
                   _teams[i].Print();
                }
                Console.WriteLine("");
            }
        }
    }
}
