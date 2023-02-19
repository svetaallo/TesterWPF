using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("TestProject1")]

namespace TesterWPF.Models
{
    public class Session
    {
        string path = "content.txt";
        public int Day { get; set; }//номер дня должен не просто вычисляться по номеру сессии, а однозначно определяться по дате
        public string QueueId { get; set; }
        public List<Card> CardsToRepeat { get; }

        public Session()
        {
            using(var db = new ApplicationContext())
            {
                CardsToRepeat = db.Cards.ToList();// загружает пока что всю базу данных, а надо определенную
            }
            if (!File.Exists(path))
            {
                File.WriteAllText(path, @"0");
            }
            Day = Int32.Parse(File.ReadAllText(path)) % 10;
            QueueId = GenerateQueueId(Day);
        }
        ~Session()
        {
            File.WriteAllText(path, (++Day).ToString());
        }
        public static string GenerateQueueId(int startDay)//протестила, может отрефакторим? а может сделаем зависимым от даты?
        {
            var queueId = startDay.ToString();
            int step = 2;
            int nextNum = startDay;
            for (var i=0;i<3;i++,step++)
            {
                nextNum = (startDay + step) % 10;
                startDay = nextNum;
                queueId += nextNum.ToString();
            }
            return queueId;
        }
        /*метод, считающий какие дни были пропущены, а следовательно, какие слова просрочены*/
        public void UpdateCardBase(List<Card> card)
        {
            //1.берет из базы !current
            //2. считает дату последней сессии из файла. если вчера - выход из метода
            // если разница больше 10 дней с текущей датой, то отправляем все !current в current
            // если меньше - то пробежаться циклом от сегодняшнего дня n(количество просроченных дней) раз. и если у карточки в номере есть этот день
            // смотрим количество пройденных проверок и индекс текущего дня в непроверенном текущем дне, то отправляем в куррент

            //написать класс дней 0-9 с переопределенным сложением и вычитанием
        }
        public static int GetCurrentDay(DateTime today)
        {
            return (today - new DateTime(2023, 1, 1)).Days % 10;
        }
    }
}