using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication
{
    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        private Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            Console.WriteLine($"Soru {this.QuestionIndex}: {question.Text}");

            foreach (var c in question.Choices)
            {
                Console.WriteLine($"-{c}");
            }

            Console.Write("Cevap: ");
            var cevap = Console.ReadLine();
            this.Guess(cevap);
        }

        private void Guess(string answer)
        {
            var question = this.GetQuestion();
            if (question.checkAnswer(answer))
                this.Score++;
            this.QuestionIndex++;
            if (this.Questions.Length == this.QuestionIndex)
                this.DisplayScore();  
            else
                this.DisplayQuestion();  
        }

        private void DisplayScore()
        {
            Console.WriteLine($"Score: {this.Score}");
        }

        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex + 1;

            if(totalQuestion >= questionNumber)
            {
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}");
            }
        }
    }
}
