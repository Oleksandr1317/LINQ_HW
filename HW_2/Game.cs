using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    public class Game
    {
        private List<ParseQuestion> questions;
        private int maxAttempts;
        private int currentAttempts;
        public Game(string path,int attempt) 
        {
            if(path == null) 
                throw new ArgumentNullException("path is null");
            if(path == "")
                throw new ArgumentException("path is empty");
            if (attempt < 2)
                throw new ArgumentException("attempt must be >= 2");

            this.questions = ParseQuestion.LoadQuestions(path);
            this.maxAttempts = attempt;
            this.currentAttempts = 0;
        }
        public bool PlayGame()
        {
            int score = 0;
            int currentQuestionIndex = 0;

            while(currentAttempts < maxAttempts && currentQuestionIndex < questions.Count) 
            {
                Console.WriteLine($"Question: {questions[currentQuestionIndex].Text}");
                Console.Write("Do you belive this statement? (yes/no): ");
                string playerAnswer = Console.ReadLine().ToLower();

                if(playerAnswer == "yes" && questions[currentQuestionIndex].Answer || playerAnswer == "no" && !questions[currentQuestionIndex].Answer) 
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect!. Explanation: {questions[currentQuestionIndex].Explanation}\n");
                    currentAttempts++;
                }
                currentQuestionIndex++;
            }
            if (currentAttempts < maxAttempts)
            {
                Console.WriteLine($"Congratulations! You won with a score of {score} out of {questions.Count}");
                return true;
            }
            else { Console.WriteLine($"You lost! You scored : {score} out of {questions.Count}"); 
            return false;}
        }
    }
}
