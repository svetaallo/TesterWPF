
namespace TesterWPF.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Theme { get; set; }
        public override string ToString()
        {
            return $"Вопрос:{Question} \n Ответ:{CorrectAnswer}";
        }

        public Card(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
        }
    }
}
