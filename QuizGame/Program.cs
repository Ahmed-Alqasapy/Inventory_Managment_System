using System.Data.SqlTypes;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Questions = new string[3] {

                "What is Your Name?",
                "What is Capital Of France",
                "What is the Best Language in The Worls"

           };

            string[] CorrectAnswers = new string[3] {

                "Ahmed",
                "Paris",
                "Arabic"
            };



            Console.WriteLine("Welcome To The Game");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Please Answer The Following Questions\n");
            int CorrectCount = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q{i+1}---{Questions[i]}");
                string userAnswer = Console.ReadLine();
                
                try
                {
                    
                    bool result = IsCorrectAnswer(userAnswer, CorrectAnswers[i]);
                    if (result == true)
                    {
                        Console.WriteLine("Correct Answer!");
                        CorrectCount++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry Incorrect Answer , Correct Answer is {CorrectAnswers[i]}");

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("\n");


            }
            Console.WriteLine($"Your Score is {CorrectCount} out of 3");
            Console.WriteLine("Quiz Completed , Thanks For Playing This Quiz");

            

        }


        static bool IsCorrectAnswer(string UserAnswer , string CorrectAnswer)
        {
            
            if(string.IsNullOrEmpty(UserAnswer))
            {
                throw new Exception("Answer Can`t be null");
            }

            if(UserAnswer == CorrectAnswer)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
