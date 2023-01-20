using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TesterWPF.Models
{
    internal class Session
    {
        string path = "content.txt";
        public int Day { get; set; }

        public int[] QueueId { get; set; }
        public List<Card> CurrentQueue { get; }
        public Session()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                CurrentQueue = db.Cards.ToList();// загружает пока что всю базу данных, а надо определенную
            }
            if (!File.Exists(path))
            {
                File.WriteAllText(path, @"0");
            }
            Day = Int32.Parse(File.ReadAllText(path));
            if (Day >= 9)
                Day = 0;
            //сделать метод для заполнения номера очереди
            QueueId = new int[4];
            QueueId[0] = Day;
        }

        private int[] GenerateQueueId(int first)  
        {
            var queueId = new int[4];
            int step = 1;
            int dif = first;
            for (var i=0;i<queueId.Length;i++) //кудрявое условие, можно распутать?
            {
                step++;
                first = (first + step) / 10;
                queueId[i] = first;
                
            }
            return queueId;
        }
        ~Session()
        {
            File.WriteAllText(path, (++Day).ToString());
        }
    }
}
