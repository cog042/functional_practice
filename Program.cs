﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

public class Program
{

    /**
     * PART 0
     *
     * Write a function that calculates the sum of all the numbers in an array
     */

    public static int sumOfArray(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result = result + arr[i];
        }
        //for //-> arr[0] + arr[1] + ... + arr[i]
        return result;
        //or
        //Array.ForEach(arr, delegate (int i) {sumOfArray += i; });
        //return 0;
        //int sumOfArray = 0;
        //Array.ForEach(arr, delegate (int i) {sumOfArray += i; });
        //Console.WriteLine(sumOfArray);

        //or
        //int sum = arr.Sum();
    }
    public static void Main() {
        int a = 7;
        int b = 8;
        int x = sum(a, b);
        Console.WriteLine(x);
    }
    /**
     * PART 1
     *
     * Write a function that takes two numbers as
     * arguments and computes the sum of those two numbers.
     */

    public static int sum(int a, int b)
    {
        int x = a + b;
        return x;
    }

    /**
     * PART 1B
     *
     * Write a function that handles any ampunt of numbers as input and
     * computes the sum of those numbers
     */

    public static int sumAll(params int[] sum)
    {
        int result = 0;
        for (int i = 0; i < sum.Length; i++)
        {
            result = result + sum[i];
        }
        return result;
    }
    //or
    //{
    //sumOfArray 
    //}
    //return result;
    //
    //or
    //return sumOfArray (x);
    /**
     * PART 2
     *
     * write a function that finds the Greatest Common Denominator of two numbers
     * - if no GCD exists, return 1
     */
    public static List<int> getDivisors(int x) //a method that creates a list called getDivisors which takes an argument x of type integer 
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                divisors.Add(i);
            }
        }

        return divisors;
    }
    public static int GCD(int a, int b)
    {

        List<int> A = getDivisors(a);  //recall: getDivisors(arg) IS the function and its output is a list called divisors.
        List<int> B = getDivisors(b);  //getDivisors runs on int a&b and gets passed into List A and B
        int greatest = 1;

        foreach (int i in A)
        {                       //this whole loop w/in a loop is to store the largest value common to both lists, the GCD
            if (B.Contains(i))
                greatest = i;
        }

        return greatest;
    }

    /**
     * PART 3
     *
     * write a function that prints out the Least Common Multiple of two numbers
     */

    public static int LCM(int a, int b)
    {
        int x = a * b / GCD(a, b);  //< -this works b/ c a fast way to find LCM is a*b / GCD and we already have a function for GCD.
        return x;
    }


    //ask why that below didn't work

    //public static List<int> getMultiples(int x) //a method that creates a list called getMultiples which takes an argument x of type integer 
    //{
    //    List<int> multiples = new List<int>();

    //    for (int i = 1; i <= x; i++)
    //    {
    //        if (x * i)/x = 0) 
    //        {
    //            multiples.Add(x);
    //        }
    //    }
    //    return multiples;
    //}
    //List<int> A = getMultiples(a);  
    //List<int> B = getMultiples(b);  
    //int leastest = 1;

    //foreach (int i in A)
    //{                       
    //    if (B.Contains(i))
    //        leastest = i;
    //}

    //return leastest;

    /**
     * Part 4
     *
     * write a function the returns a FizzBuzz string for some number N (counting up from 1).
     * - for every number that isn't a multiple of 3 or 5, return a period "."
     * - for every number that is a multiple of 3 (but not 5), return "fizz"
     * - for every number that is a multiple of 5 (but not 3), return "buzz"
     * - for every number that is a multiple of 3 and 5, return "fizzbuzz"
     */

    public static List<int> fizzbuzz(int n)
    {
        List<int> fB = new List<int>(n);
        for (int i = 1; i <= n; i++)
        {
            if (n % 3 == 0)
            {
                n.ToString("fizz"); //needs to be fizz 
            }
            else if (n % 5 == 0)
            {
                n.ToString("buzz"); //buzz
            }
            else if (n % 3 == 0 && n % 5 == 0)
            {
                n.ToString("fizzbuzz"); //fizzbuzz
            }
            else
            {
                n.ToString(".");  // "."
            }
        }
        return fB;
    }

    /**
     * PART 5
     *
     * Define a function max() that takes two numbers as arguments
     * and returns the largest of them.
     */

    public static int max(int a, int b)
    {
        int x = Math.Max(a, b);
        return x;
    }

    /**
     * PART 6
     *
     * Define a function maxOfThree() that takes three
     * numbers as arguments and returns the largest of them.
     */

    public static int maxOfThree(int a, int b, int c)
    {
        int y = max(a, b);
        int z = Math.Max(y, c);
        return z;
    }

    /**
     * PART 6B
     *
     * Define a function maxOfAll() that takes any amount of
     * numbers as arguments and returns the largest of them.
     */

    public static int maxOfAll()
    {
        List<int> numbers = new List<int>();
        int max = numbers.Max();
        return max;
    }

    /**
     * PART 7
     *
     * Write a function isVowel() that takes a string with a single character (i.e. a string of length 1)
     * and returns true if it is a vowel, false otherwise.
     */



    //public enum vowels
    //{
    //    a, e, i, o, u
    //}

    public static bool isVowel(string myString)
    {
        string myString=new string;
     
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'a' || myString[i] == 'e' ||
                myString[i] == 'i' || myString[i] == 'o' ||
                myString[i] == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    /**
     * PART 8
     *
     * Write a function rovarspraket() that will translate
     * a text into a "rövarspråket". That is, double every
     * consonant and place an occurrence of "o" in between.
     *
     * For example, rovarspraket("this is fun") should
     * return the string "tothohisos isos fofunon".

     */

    public static string rovarspraket(string s)
    {
        public enum Vowel
        {
            a,b,c,d,e
        }
        char[] input = new char[] { 'a', 'e', 'i', 'o', 'u' };
        string vow = new string(vowels);
        
        return "";
    }

    /**
     * Part 9
     *
     * Define a function reverse() that computes
     * the reversal of a string. For example,
     * reverse("skoob") should return the
     * string "books".
     */

    public static string reverse(string str)
    {
        // YOUR CODE HERE
        return "";
    }

    /**
     * Part 10
     *
     * Write a function findLongestWord() that takes an
     * string returns the first, longest word in the string.
     *
     * i.e. findLongestWord("book dogs") should return "book"
     */

    public static string findLongestWord(string sentence)
    {
        // YOUR CODE HERE
        return "";
    }

    public static void Main()
    {
        Debug.Assert(sumOfArray(new int[] { 1, 2 }) == 3);
        Debug.Assert(sumOfArray(new int[0]) == 0);
        Debug.Assert(sumOfArray(new int[] { 1, 2, 3 }) == 6);
        Debug.Assert(sumOfArray(new int[] { 10, 9, 8 }) == 27);

        Debug.Assert(sum(8, 11) == 19);
        Debug.Assert(sum(4, 100) == 104);

        Debug.Assert(sumAll(8, 11) == 19);
        Debug.Assert(sumAll(4, 100) == 104);
        Debug.Assert(sumAll(8, 11, 20, 30, 11) == 80);
        Debug.Assert(sumAll(4, 100, 1, 4, -10, 15, 21) == 135);

        Debug.Assert(GCD(5, 1) == 1);
        Debug.Assert(GCD(15, 3) == 3);
        Debug.Assert(GCD(15, 5) == 5);
        Debug.Assert(GCD(50, 20) == 10);

        Debug.Assert(LCM(10, 10) == 10);
        Debug.Assert(LCM(2, 5) == 10);
        Debug.Assert(LCM(3, 6) == 6);
        Debug.Assert(LCM(0, 1) == 1);

        Debug.Assert(fizzbuzz(1) == ".");
        Debug.Assert(fizzbuzz(2) == "..");
        Debug.Assert(fizzbuzz(3) == "..fizz");
        Debug.Assert(fizzbuzz(5) == "..fizz.buzz");
        Debug.Assert(fizzbuzz(10) == "..fizz.buzzfizz..fizzbuzz");

        Debug.Assert(max(1, 3) == 3);
        Debug.Assert(max(0, 3) == 3);
        Debug.Assert(max(10, 3) == 10);
        Debug.Assert(max(-1, -3) == -1);

        Debug.Assert(maxOfThree(1, 3, 2) == 3);
        Debug.Assert(maxOfThree(0, 3, -1) == 3);
        Debug.Assert(maxOfThree(10, 3, 50) == 50);
        Debug.Assert(maxOfThree(-1, -3, -10) == -1);
        Debug.Assert(maxOfAll(-30, -50, -1, -3, -10, -11, -20) == -1);
        Debug.Assert(maxOfAll(10, 20, 11, 53, 100, 211, -20) == 211);

        Debug.Assert(isVowel("B") == false);
        Debug.Assert(isVowel("b") == false);
        Debug.Assert(isVowel("a") == true);
        Debug.Assert(isVowel("E") == true);

        Debug.Assert(rovarspraket("a") == "a");
        Debug.Assert(rovarspraket("b") == "bob");
        Debug.Assert(rovarspraket("cat") == "cocatot");
        Debug.Assert(rovarspraket("javascript") == "jojavovasoscocroripoptot");

        Debug.Assert(reverse("books") == "skoob");
        Debug.Assert(reverse("we don't want no trouble") == "elbuort on tnaw t'nod ew");

        Debug.Assert(findLongestWord("book dogs") == "book");
        Debug.Assert(findLongestWord("don't mess with Texas") == "Texas");
    }
}
