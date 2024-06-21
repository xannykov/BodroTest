using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace BodroTest
{
    public class Question
    {
        public string QuestionText { get; }
        public List<string> AnswerOptions { get; }
        public int CorrectAnswer { get; }
        public Image QuestionImage { get; set; }
        public UnmanagedMemoryStream QuestionAudio { get; set; }

        public Question(string questionText, List<string> answerOptions, int correctAnswer, Image questionImage = null, UnmanagedMemoryStream questionAudio = null)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
            CorrectAnswer = correctAnswer;
            QuestionImage = questionImage;
            QuestionAudio = questionAudio;
        }
    }
}
