namespace Csharp_basics__Decision_Making___Repeat_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votecount = 0;
            //string? result = null;

            //if (voteCount > 0)
            //{
            //    result = "won";
            //}
            //else { result = "lost"; }
            //Console.WriteLine($"Result {result}");

            // ternary operator
            var result = votecount > 0 ? "won" : "lost";
            Console.WriteLine($"Result {result}");


            int number = 150;

            var Rnumber = number > 0 ? number % 2 == 0 ? "positive Even number" : "Positve Odd number" : number < 0 ? "Negative Number" : "Zero";

            Console.WriteLine();

            // Multi Branching
            int score = 85;
            string grade;
            if(score >= 90) { grade = "Outstanding"; }
            else if(score >= 80) { grade = "Good"; }
            else if (score >= 70) { grade = "average"; }
            else if (score >= 60) { grade = "below average"; }
            else { grade = "Bad performer"; }
            Console.WriteLine(grade);

            var grade1 = score >= 90 ? "Outstanding" : score >= 80 ? "good" : score >= 70 ? "average" : "bad performer";
            Console.WriteLine(grade1);

            //NULL coalescing

            string? myName = "Islam";
            string myOtherName = myName ?? "Moinul";
            Console.WriteLine($"My name is {myOtherName}");

            // loop // repeat Operation

            // String reversal using for loop

            string myString = "Hello";
            string revesedString = "";

            for(int i = myString.Length -1; i >= 0; i--)
            {
                revesedString += myString[i];
            }
            Console.WriteLine(revesedString);

            // Foreach(Palindrom)
            string[] WordCollection = { "madam", "mom", "levet", "radar" };

            foreach(var word in WordCollection) 
            {
                bool isPalindrom = true;
                for (int i=0; i<WordCollection.Length/2;i++) {
                    if (word[i]!= word[word.Length-1-i]) { 
                    isPalindrom = false;
                    }
                }
                Console.WriteLine($"{word} is {(isPalindrom ? "a plaindrome": "Not a plaindroe") }");




            }


        }
    }
}