using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace TesterWPF
{
    class Card: DependencyObject
    {
        public static readonly DependencyProperty QuestionProperty;

        public static readonly DependencyProperty CorrectAnswerProperty;
        public List <(string, bool)> Answers { get; set; }
        static Card()
        {
            QuestionProperty = DependencyProperty.Register("Question", typeof(string), typeof(Card));
            CorrectAnswerProperty = DependencyProperty.Register("CorrectAnswer", typeof(string), typeof(Card));
        }
        public string Question
        {
            get { return (string)GetValue(QuestionProperty); }
            set { SetValue(QuestionProperty, value); }
        }
        public string CorrectAnswer
        {
            get { return (string)GetValue(CorrectAnswerProperty); }
            set { SetValue(CorrectAnswerProperty, value); }
        }
        public override string ToString()
        {
            return $"Вопрос:{Question} \n Ответ:{CorrectAnswer}";
        }
    }
}
