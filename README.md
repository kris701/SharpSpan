# SharpSpan

SharpSpan aims to increase the performance of severeal different c# fields. This mainly being fields where methods such as LINQ is used, but can be faster. Examples of such could be using LINQ to make a list to map out the elements of another list is odd or even. The performance increase can be seen with that example:

        var output = SomeList.Select(x => x % 2 == 0).ToList();
        
This method makes a list, from a list, containing bools that tell of the numbers of the list is even.
Using a Stopwatch to test how many ticks it takes for LINQ to calculate the result can be as high as 30000 ticks. Meanwhile the SharpSpan method of:

        var output = NewList.MapNumbers(MapMode.IsOdd);

Only takes as little as 3000 ticks, that is 10 times faster then what LINQ could do.

I must make it clear that this is not saying that LINQ is bad, LINQ is just very universal, and that means that it many times sacrifices performance over stability and compatibility.

## SharpSpan Methods

### SharpSpan.Lists

**These are all extensions to the normal List<T> class, you only need to add the SharpSpan.Lists namespace.**
  
Finds the lowest number in a list:

        int FindLowestNumberFast()

Find the index of the lowest number in a list:

        int FindLowestNumberIndexFast()
        
Find the highest number in a list:

        int FindHighestNumberFast()
         
Find the index of the highest number in a list:

        int FindHighestNumberIndexFast()

Makes a list from a list, with the given method:

        List<bool> MapNumbers(MapMode mapmode, int Value)

Checks if all elements in a list returns true with the given method:

        bool MapNumbersAll(MapMode mapmode, int Value)

The different methods that can be used for the above two functions:

        IsOdd
        IsEven
        IsGreaterThan
        IsGreaterThanOrEqual
        IsLessThan
        IsLessThanOrEqual
        IsEqual
        IsNotEqual

***
