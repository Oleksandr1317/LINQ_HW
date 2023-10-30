using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_2
{
    public class ParseQuestion
    {
        public ParseQuestion(string text,bool answer,string explanation) 
        {
            Text = text;
            Answer = answer;
            Explanation = explanation;
        }
        public string Text { get;}
        public bool Answer { get;}
        public string Explanation { get;}

        public static List<ParseQuestion> LoadQuestions(string path)
        {

            var questions = File.ReadAllLines(path)
                .Select(x =>
                {
                    string[] parts = x.Split(';');
                    string text = parts[0];
                    bool answer = parts[1] == "yes";
                    string explanation = parts[2];

                    return new ParseQuestion(text, answer, explanation);
                })
                .ToList();

            return questions;
        }
    }
}
