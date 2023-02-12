using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject1")]

namespace TesterWPF.Models
{
    public class Session
    {
        string path = "content.txt";
        public int Day { get; set; }
        public string QueueId { get; set; }// будет вызываться при добавлении новой карточки
        public List<Card> CardsToRepeat { get; }
        public Session()
        {
            using(ApplicationContext db = new ApplicationContext())
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

        public static string GenerateQueueId(int first)//протестила, может отрефакторим?
        {
            var queueId = first.ToString();
            int step = 2;
            int nextNum = first;
            for (var i=0;i<3;i++,step++)
            {
                nextNum = (first + step) % 10;
                first = nextNum;
                queueId += nextNum.ToString();
            }
            return queueId;
        }
    }
}