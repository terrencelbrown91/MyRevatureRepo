using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        //count the number of times each element value occurs
        //this array has 6 elements. Element 1-5 represent the id numbers of the birds
        //and will hold how many times that id was seen.

        int[] numBirdSightings = new int[6];

        //counts how manyu sightings of each bird.
        foreach (int birdId in arr)
        {
            numBirdSightings[birdId]++;
        }

        //these variables will hold the max number of sightings of an id so far.
        int maxSightings = 0; //highest number of sightings
        int idOfMaxSightings = 0;

        //compare
        for (int r = 1; r < 6; r++)
        {

            if (numBirdSightings[r] > maxSightings)
            {
                maxSightings = numBirdSightings[r];
                idOfMaxSightings = r;
            }
        }
        return idOfMaxSightings;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
