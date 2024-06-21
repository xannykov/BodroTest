using System.Collections.Generic;

namespace BodroTest
{
    public static class QuestionInitializer
    {
        public static List<Question> InitializeQuestions()
        {
            List<Question> questions = new List<Question>
            {

                // Text questions
                //1
                new Question("Question 1 ?",
                    new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 0),
                //2
                new Question("Question 2 ?",
                    new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 1),

                // Questions with images
                //3
                new Question("Question 3 ?",
                    new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 2, Properties.Resources.Image1),
                //4
                new Question("Question 4 ?",
                    new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 3, Properties.Resources.Image2),            
                
                // Questions with music
                //5
                new Question("Question 5 ?",
                    new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 0, null , Properties.Resources.Music1),
                //6
                new Question("Question 6 ?",
                    new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 1, null , Properties.Resources.Music2),

            };

            return questions;
        }
    }
}
