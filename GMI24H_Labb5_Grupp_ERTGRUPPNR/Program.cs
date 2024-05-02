using GMI24H_Labb5_Grupp_ERTGRUPPNR;
using GMI24H_Labb5_Grupp_ERTGRUPPNR.MyAlgorithmLibrary;
using System.Diagnostics;


/// <summary>
/// NOTE: You are by no means obligated to use this project structure. It is just a suggestion. If you want to create
/// your own project from scratch, you are most welcome to do so.
/// 
/// In the Program class you have the Main methods which is the starting point of any program which I am sure that you
/// already are aware of. 
/// 
/// Please write comments in your own code for specific test cases or other things that you want to show.
/// It is ok to write your code in English and your comments in Swedish. However, do not mix Enlish and Swedish IN THE CODE.
/// 
/// It is very much up to you how you decide to organize your work so do not feel obligated to use the structure provided in this template.
///
/// Experiment and have fun! 
/// 
/// Best of luck! /Elin
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {

        //You can create arrays to test your sorting algorithms and you can create
        //a sorted array and an element to search for to test your searching algorithms. You have some sample data in the MyData.cs file that you can use.
        //but you are of course free to experiment with even larger data sets (in fact, this might be necessary to measure the performance of your algorithms).
        MyData data = new();

        //Since the methods in the Sorter and Searcher classes are not static, you need to create an object of each class
        //in order to call the methods which consist your algorithms.
        Sorter sorter = new();
        Searcher searcher = new();

        // The BubbleSort method of the Sorter class is not yet implemented,
        // the method call below is just for reference on how you
        //can call the method and pass the sample data provided in the MyData class.
        int[] myArray = data.RandomNumSmallSmallRange; //initializing array that we want to sort. Note that we create and assign this prior to the method call, and there is a reason for this. Do you know why? :)
        sorter.BubbleSort(myArray); // <-- implement the methods from ISorter in the Sorter class in order to use them and passing the previously initialized array as an argument to the sorting method we want to test...

        //To be able to measure how long it takes to run an algorithm, you can use
        //The Stopwatch and the TimeSpan classes.

        for(int i = 0; i < 10; i++)
        {
            Stopwatch sw = Stopwatch.StartNew();
            //HINT: this is an appropriate place to run your algorithm.
          
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed; //HINT: perhaps might be a good idea to do something with this...
            
        }
        
    }
}