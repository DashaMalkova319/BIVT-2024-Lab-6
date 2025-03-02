using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_1;
using static Lab_6.Blue_2;
using static Lab_6.Blue_5;

namespace Lab_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Blue_1

            //Blue_1.Response[] responses = new Blue_1.Response[]
            //{
            //new Response("Татьяна", "Степанова"),
            //new Response("Никита", "Жарков"),
            //new Response("Юрий", "Иванов"),
            //new Response("Юрий", "Иванов")
            //};

            //Response t = new Response("Татьяна", "Степанова");
            //t.CountVotes(responses);
            //t.Print();

            //Response n = new Response("Никита", "Жарков");
            //n.CountVotes(responses);
            //n.Print();

            //Response u = new Response("Юрий", "Иванов");
            //u.CountVotes(responses);
            //u.Print();


            // Blue_2
            // Создаем массив участников

            Blue_2.Participant[] participants = new Blue_2.Participant[10];
            participants[0] = new Blue_2.Participant("Александр", "Петров");
            participants[1] = new Blue_2.Participant("Артем", "Луговой");
            participants[2] = new Blue_2.Participant("Мария", "Свиридова");
            participants[3] = new Blue_2.Participant("Игорь", "Смирнов");
            participants[4] = new Blue_2.Participant("Николай", "Зайцев");
            participants[5] = new Blue_2.Participant("Инесса", "Кристиан");
            participants[6] = new Blue_2.Participant("Марина", "Свиридова");
            participants[7] = new Blue_2.Participant("Александр", "Петров");
            participants[8] = new Blue_2.Participant("Сергей", "Батов");
            participants[9] = new Blue_2.Participant("Александра", "Сидорова");

            // Заполняем оценки для прыжков

            participants[0].Jump(new int[] { 11, 0, 8, 7, 12 });
            participants[0].Jump(new int[] { 2, 3, 10, 13, 16 });

            participants[1].Jump(new int[] { 18, 17, 20, 7, 11 });
            participants[1].Jump(new int[] { 3, 7, 12, 19, 2 });

            participants[2].Jump(new int[] { 17, 13, 2, 19, 2 });
            participants[2].Jump(new int[] { 10, 0, 0, 6, 5 });

            participants[3].Jump(new int[] { 15, 7, 14, 19, 15 });
            participants[3].Jump(new int[] { 5, 13, 16, 18, 16 });

            participants[4].Jump(new int[] { 20, 5, 4, 3, 0 });
            participants[4].Jump(new int[] { 18, 4, 12, 18, 7 });

            participants[5].Jump(new int[] { 5, 17, 20, 2, 11 });
            participants[5].Jump(new int[] { 10, 18, 9, 7, 12 });

            participants[6].Jump(new int[] { 18, 1, 10, 5, 20 });
            participants[6].Jump(new int[] { 19, 1, 5, 1, 18 });

            participants[7].Jump(new int[] { 2, 17, 5, 11, 3 });
            participants[7].Jump(new int[] { 7, 18, 3, 5, 3 });

            participants[8].Jump(new int[] { 2, 0, 5, 18, 20 });
            participants[8].Jump(new int[] { 3, 12, 4, 2, 10 });

            participants[9].Jump(new int[] { 12, 2, 17, 5, 7 });
            participants[9].Jump(new int[] { 5, 15, 15, 5, 11 });

            Participant.Sort(participants);

            foreach (var participant in participants)
            {
                participant.Print();
            }

            //Blue_3

            //Blue_3.Participant[] participants = new Blue_3.Participant[5];
            //participants[0] = new Blue_3.Participant("Инна", "Пономарева");
            //participants[1] = new Blue_3.Participant("Юрий", "Ушаков");
            //participants[2] = new Blue_3.Participant("Дмитрий", "Иванов");
            //participants[3] = new Blue_3.Participant("Иван", "Кристиан");
            //participants[4] = new Blue_3.Participant("Татьяна", "Ушакова");



            //// Заполняем оценки для прыжков

            //participants[0].PlayMatch(2);
            //participants[0].PlayMatch(2);
            //participants[0].PlayMatch(0);
            //participants[0].PlayMatch(2);
            //participants[0].PlayMatch(0);
            //participants[0].PlayMatch(0);
            //participants[0].PlayMatch(0);
            //participants[0].PlayMatch(5);
            //participants[0].PlayMatch(2);
            //participants[0].PlayMatch(5);

            //participants[1].PlayMatch(0);
            //participants[1].PlayMatch(10);
            //participants[1].PlayMatch(10);
            //participants[1].PlayMatch(0);
            //participants[1].PlayMatch(5);
            //participants[1].PlayMatch(5);
            //participants[1].PlayMatch(2);
            //participants[1].PlayMatch(10);
            //participants[1].PlayMatch(10);
            //participants[1].PlayMatch(10);

            //participants[2].PlayMatch(2);
            //participants[2].PlayMatch(5);
            //participants[2].PlayMatch(5);
            //participants[2].PlayMatch(2);
            //participants[2].PlayMatch(0);
            //participants[2].PlayMatch(10);
            //participants[2].PlayMatch(5);
            //participants[2].PlayMatch(2);
            //participants[2].PlayMatch(0);
            //participants[2].PlayMatch(0);

            //participants[3].PlayMatch(2);
            //participants[3].PlayMatch(10);
            //participants[3].PlayMatch(2);
            //participants[3].PlayMatch(5);
            //participants[3].PlayMatch(2);
            //participants[3].PlayMatch(2);
            //participants[3].PlayMatch(10);
            //participants[3].PlayMatch(10);
            //participants[3].PlayMatch(5);
            //participants[3].PlayMatch(0);

            //participants[4].PlayMatch(5);
            //participants[4].PlayMatch(2);
            //participants[4].PlayMatch(0);
            //participants[4].PlayMatch(10);
            //participants[4].PlayMatch(10);
            //participants[4].PlayMatch(2);
            //participants[4].PlayMatch(10);
            //participants[4].PlayMatch(5);
            //participants[4].PlayMatch(0);
            //participants[4].PlayMatch(2);



            //Blue_3.Participant.Sort(participants);

            //foreach (var participant in participants)
            //{
            //    participant.Print();
            //}
            //Program program = new Program();

            //Blue_4.Team[] teams = new Blue_4.Team[]            {
            //       new Blue_4.Team("Энергия"),
            //       new Blue_4.Team("Спартак"),
            //       new Blue_4.Team("Барс"),
            //       new Blue_4.Team("Нефтехим"),
            //       new Blue_4.Team("Байкал"),
            //       new Blue_4.Team("Василек"),
            //       new Blue_4.Team("Урал"),
            //       new Blue_4.Team("Быки"),
            //       new Blue_4.Team("Метеор"),
            //       new Blue_4.Team("Быки"),
            //       new Blue_4.Team("ЦСКА"),
            //       new Blue_4.Team("Русь")            };
            //foreach (var x in new int[] { 1, 0, 0, 0, 3, 0, 1, 0, 1, 3, 0, 0 }) teams[0].PlayMatch(x);
            //foreach (var x in new int[] { 0, 0, 1, 3, 3, 1, 0, 3, 0, 3, 1, 3, 3, 0, 1, 1, 1, 1, 0, 1 }) teams[1].PlayMatch(x);
            //foreach (var x in new int[] { 0, 3, 0, 0, 3, 1, 0, 1, 0, 3, 0, 0, 3, 1, 1, 3, 0, 1, 0, 0 }) teams[2].PlayMatch(x);
            //foreach (var x in new int[] { 3, 1, 1, 0, 1, 0, 1, 3, 1, 3, 1, 0, 1, 1, 0, 1, 3, 3, 3, 0 }) teams[3].PlayMatch(x);
            //foreach (var x in new int[] { 1, 0, 1, 0, 0, 1, 3, 1, 3, 3, 3, 1, 3, 3, 0, 1, 0, 0, 0, 0 }) teams[4].PlayMatch(x);
            //foreach (var x in new int[] { 1, 3, 3, 3, 3, 3, 1, 3, 3, 0, 1, 3, 3, 0, 1, 0, 0, 3, 0, 3 }) teams[5].PlayMatch(x);
            //foreach (var x in new int[] { 0, 1, 3, 1, 1, 0, 0, 0, 3, 3, 1, 3, 3, 3, 0, 0, 3, 3, 3, 0 }) teams[6].PlayMatch(x);
            //foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teams[7].PlayMatch(x);
            //foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teams[8].PlayMatch(x);
            //foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teams[9].PlayMatch(x);
            //foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[10].PlayMatch(x);
            //foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[11].PlayMatch(x);
            //Blue_4.Group group1 = new Blue_4.Group("Группа 1");
            //foreach (var team in teams)
            //{
            //    group1.Add(team);
            //}
            //group1.Sort();
            //Console.WriteLine("Группа 1 после сортировки:"); group1.Print();

            //Console.WriteLine();
            //Blue_4.Team[] teamss = new Blue_4.Team[] {
            //new Blue_4.Team("Локомотив"),
            //new Blue_4.Team("СКА"),
            //new Blue_4.Team("Энергия"),
            //new Blue_4.Team("Нефтехим"),
            //new Blue_4.Team("Ак-барс"),
            //new Blue_4.Team("Барс"),
            //new Blue_4.Team("СПБ"),
            //new Blue_4.Team("Быки"),
            //new Blue_4.Team("Метеор"),
            //new Blue_4.Team("Быки"),
            //new Blue_4.Team("ЦСКА"),
            //new Blue_4.Team("Русь") };

            //foreach (var x in new int[] { 1, 1, 3, 0, 3, 0, 1, 0, 3, 3, 3, 3 }) teamss[0].PlayMatch(x);
            //foreach (var x in new int[] { 0, 0, 1, 0, 3, 1, 0, 3, 1, 3, 1, 3, 3, 1, 1, 1, 0, 3, 1, 1 }) teamss[1].PlayMatch(x);
            //foreach (var x in new int[] { 1, 1, 3, 3, 0, 0, 3, 3, 1, 0, 3, 0, 0, 1, 0, 3, 1, 1, 0, 1 }) teamss[2].PlayMatch(x);
            //foreach (var x in new int[] { 1, 3, 3, 1, 1, 3, 3, 1, 3, 3, 1, 1, 0, 3, 0, 3, 1, 3, 1, 1 }) teamss[3].PlayMatch(x);
            //foreach (var x in new int[] { 0, 3, 1, 1, 1, 0, 3, 1, 0, 3, 0, 0, 1, 3, 3, 1, 1, 3, 0, 0 }) teamss[4].PlayMatch(x);
            //foreach (var x in new int[] { 3, 1, 0, 0, 3, 1, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 3, 0, 3, 1 }) teamss[5].PlayMatch(x);
            //foreach (var x in new int[] { 0, 1, 1, 3, 0, 1, 3, 0, 3, 3, 0, 0, 0, 3, 3, 1, 1, 0, 3, 1 }) teamss[6].PlayMatch(x);
            //foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teamss[7].PlayMatch(x);
            //foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teamss[8].PlayMatch(x);
            //foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teamss[9].PlayMatch(x);
            //foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teamss[10].PlayMatch(x);
            //foreach (var x in new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }) teamss[11].PlayMatch(x);
            //Blue_4.Group group2 = new Blue_4.Group("Группа 2");
            //foreach (var team in teamss)
            //{
            //    group2.Add(team);
            //}
            //group2.Sort();
            //Console.WriteLine("Группа 2 после сортировки:"); group2.Print();
            //Blue_4.Group.Merge(group1, group2, 12).Print();

            Blue_5.Sportsman[] Sportsmen = new Blue_5.Sportsman[]
                  {
                 new Blue_5.Sportsman("Мирослав", "Распутин"),
                 new Blue_5.Sportsman("Игорь", "Павлов"),
                 new Blue_5.Sportsman("Полина", "Свиридова"),
                 new Blue_5.Sportsman("Савелий", "Луговой"),
                 new Blue_5.Sportsman("Николай", "Козлов"),
                 new Blue_5.Sportsman("Юлия", "Сидорова"),
                 new Blue_5.Sportsman("Полина", "Луговая"),
                 new Blue_5.Sportsman("Светлана", "Иванова"),
                 new Blue_5.Sportsman("Александр", "Петров"),
                 new Blue_5.Sportsman("Игорь", "Распутин"),
                 new Blue_5.Sportsman("Савелий", "Свиридов"),
                 new Blue_5.Sportsman("Мария", "Свиридова"),
                 new Blue_5.Sportsman("Дмитрий", "Свиридов"),
                 new Blue_5.Sportsman("Светлана", "Козлова"),
                 new Blue_5.Sportsman("Екатерина", "Луговая"),
                 new Blue_5.Sportsman("Степан", "Жарков"),
                 new Blue_5.Sportsman("Степан", "Распутин"),
                 new Blue_5.Sportsman("Дарья", "Свиридова") };
            int[] places = { 12, 2, 17, 13, 5, 6, 7, 8, 9, 10, 11, 1, 4, 14, 15, 16, 3, 18 };
            for (int i = 0; i < Sportsmen.Length; i++)
            {
                Sportsmen[i].SetPlace(places[i]);
            }

            Blue_5.Team[] teams = new Blue_5.Team[]
            {
                     new Blue_5.Team("Локомотив"),
                     new Blue_5.Team("Динамо"),
                     new Blue_5.Team("Спартак") };

            teams[0].Add(new Blue_5.Sportsman[] { Sportsmen[0], Sportsmen[1], Sportsmen[2], Sportsmen[3], Sportsmen[4], Sportsmen[5] });
            teams[1].Add(new Blue_5.Sportsman[] { Sportsmen[6], Sportsmen[7], Sportsmen[8], Sportsmen[9], Sportsmen[10], Sportsmen[11] });
            teams[2].Add(new Blue_5.Sportsman[] { Sportsmen[12], Sportsmen[13], Sportsmen[14], Sportsmen[15], Sportsmen[16], Sportsmen[17] });

            Blue_5.Team.Sort(teams);

            Console.WriteLine("");
            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Name}, {team.SummaryScore},{team.TopPlace}");
                team.Print();
            }
        }

    }
}
   
    