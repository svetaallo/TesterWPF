
using TesterWPF.Views;

namespace TesterWPF.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string QueueId { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Theme { get; set; }
        public override string ToString()
        {
            return $"Вопрос:{Question} \n Ответ:{CorrectAnswer}";
        }

        public Card(string question, string correctAnswer)
        {
            QueueId = "current";
            Question = question;
            CorrectAnswer = correctAnswer;
        }

        public void SaveToBase()//сделать сохранение в базу, нужно передавать базу как параметр
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Add(this);
                db.SaveChanges();
            }
        }
    }
}
