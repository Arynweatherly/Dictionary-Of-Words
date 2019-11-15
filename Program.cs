using System;
using System.Collections.Generic;

namespace dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>()
            { { "food", "any nutritious substance that people or animals eat or drink or that plants absorb in order to maintain life and growth" }, { "water", "a colorless, transparent, odorless liquid that forms the seas, lakes, rivers, and rain and is the basis of the fluids of living organisms." }, { "air", "the invisible gaseous substance surrounding the earth, a mixture mainly of oxygen and nitrogen." }, { "sun", "the star around which the earth orbits." }, { "star", "a fixed luminous point in the night sky which is a large, remote incandescent body like the sun." }
            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("happy", "feeling or showing pleasure or contentment.");
            wordsAndDefinitions.Add("sad", "feeling or showing sorrow; unhappy.");
            wordsAndDefinitions.Add("angry", "having a strong feeling of or showing annoyance, displeasure, or hostility");
            wordsAndDefinitions.Add("excited", "very enthusiastic and eager.");
            wordsAndDefinitions.Add("tired", "in need of sleep or rest; weary.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            if (wordsAndDefinitions.ContainsKey("happy"))
            {
                Console.WriteLine("happy is defined as" + wordsAndDefinitions["happy"]);
            }
            // Console.WriteLine("happy is defined as:" + Value[""])

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"{word.Key} is defined as ${word.Value}");
            }
        }
    }
}