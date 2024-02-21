// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

int UpperBound = 100;

var numberWordPairs = new Dictionary<int, string>
{
    { 3, "Walker" },
    { 5, "Crystal" }
};

NumberPrinter.PrintNumbers(UpperBound, numberWordPairs);

//// print numbers 1-100 to screen
//for (int i = 1; i < 101; i++)
//{
//    // if divisibe by 3
//    if(i % 3 == 0)
//    {
//        // print walker
//        Console.WriteLine("Walker");
//    }else if (i % 5 == 0)
//    {
//        // if divisible by 5
//        //print crystal
//        Console.WriteLine("Crystal");
//    }else
//    {
//        Console.WriteLine(i.ToString());
//    }
//}

// if divisible by both then show both

// pass in upper bound
// pass in number and word pairs
// test cases