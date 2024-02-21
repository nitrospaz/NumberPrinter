Example application that allows a user to pass in: 
    a number of iterations and 
    a dictionary of number and word combos
    
For each number in the iterative list the program will print the number or the associated word if that number is divisible by a number in the dicitionary list. 
If a number is divisible by more than 2 entires in the list it will print both words.

Example input:
var numberWordPairs = new Dictionary<int, string>
{
    { 3, "Walker" },
    { 5, "Crystal" }
};

int UpperBound = 15;


Example output:
1
2
Walker
4
Crystal
Walker
7
8
Walker
Crystal
11
Walker
13
14
Walker Crystal