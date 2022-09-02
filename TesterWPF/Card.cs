using System;
using System.Collections.Generic;
using System.Text;

namespace TesterWPF
{
    class Card
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public Card(string question, string corretAnswer)
        {
            Question = question;
            CorrectAnswer = corretAnswer;
        }
        public override string ToString()
        {
            return $"Вопрос:{Question} \n Ответ:{CorrectAnswer}";
        }
    }
}
