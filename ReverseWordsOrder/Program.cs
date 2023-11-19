// See https://aka.ms/new-console-template for more information
using ReverseWordsOrder;

string[] inputArray = { "this is a test", "foobar", "all your base" };
ReverseWords1(3, inputArray);

static void ReverseWords1(int testCases, string[] strings)
{
    var reverser = new Reverser(new ReverseOrder(testCases, strings));
    reverser.Reverse();
}