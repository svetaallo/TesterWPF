
namespace TesterWPF.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Theme { get; set; }
        //public DateTime NextCheckup { get; set; }
        //public Card(string question, string corretAnswer, string theme)
        //{
        //    Theme = theme;
        //    Question = question;
        //    CorrectAnswer = corretAnswer;
        //    //NextCheckup = DateTime.Today.AddDays(1);
        //}

        public override string ToString()
        {
            return $"Вопрос:{Question} \n Ответ:{CorrectAnswer}";
        }
    }
}
