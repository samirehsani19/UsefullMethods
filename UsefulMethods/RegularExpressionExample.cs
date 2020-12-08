using System;
using System.Text.RegularExpressions;

namespace UsefulMethods
{
    internal class RegularExpressionExample
    {
        internal void CheckForValidation()
        {
            string text = "hello my name is Samir and i am practicing regular expression. todays date is 2020-12-06. it is actually sunday night";
            string validEmail = "samir.examle20gmail.com";
            string InvalidEmail = "samir.examle333@gmail.world";

            string ptr1 = @"\b[M]\w+";  //find a word tha start with m
            Regex r1 = new Regex(ptr1, RegexOptions.IgnoreCase);
            Console.WriteLine(r1.Match(text));   //ouput: my

            Regex r2 = new Regex(@"\bSamir\b");   //find Samir   start with uppercase
            Match match1 = r2.Match(text);   //ouput: Samir
            if (match1.Success)
            {
                Console.WriteLine("Match Value: " + match1.Value);
            }


            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";   //ouput:        Henry Hunt  Sara Samuels   Abraham Adams   Nicole Norris
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
                         "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));


            string pattern4 = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";

            foreach (Match match in Regex.Matches(input, pattern4, RegexOptions.IgnoreCase))
                Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                                  match.Value, match.Groups[1].Value, match.Index);

            // The example displays the following output:
            //       This this (duplicates 'This') at position 0
            //       a a (duplicates 'a') at position 66












}


        /*  
            ^ asserts that the regular expression must match at the beginning of the subject
            [] is a character class - any character that matches inside this expression is allowed
            A-Z allows a range of uppercase characters
            a-z allows a range of lowercase characters
            . matches a period rather than a range of characters
            \s matches whitespace (spaces and tabs)
            _ matches an underscore
            - matches a dash (hyphen); we have it as the last character in the character class so it doesn't get interpreted as being part of a character range. We could also escape it (\-) instead and put it anywhere in the character class, but that's less clear
            + asserts that the preceding expression (in our case, the character class) must match one or more times
            $ Finally, this asserts that we're now at the end of the subject  
         
         */
    }
}