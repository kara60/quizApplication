using System;

namespace QuizApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("En iyi programlama dili hangisidir?", new string[] {"Python", "C#",  "Java", "C++"}, "C#");
            var q2 = new Question("En popüler programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
            var q3 = new Question("En çok kazandıran programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
            var q4 = new Question("En kullanılan kazandıran programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");

            var questions = new Question[] { q1, q2, q3, q4};
            var quiz = new Quiz(questions);

            quiz.DisplayQuestion();           

            Console.ReadKey();
        }
    }
}
