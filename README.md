# SharpSpan

SharpSpan aims to increase the performance of severeal different c# fields. This mainly being fields where methods such as LINQ is used, but can be faster. Examples of such could be using LINQ to make a list to map out the elements of another list is odd or even. The performance increase can be seen with that example:

        var output = SomeList.Select(x => x % 2 == 0).ToList();
        
This method makes a list, from a list, containing bools that tell of the numbers of the list is even.
Using a Stopwatch to test how many ticks it takes for LINQ to calculate the result can be as high as 30000 ticks. Meanwhile the SharpSpan method of:

        var output = NewList.MapNumbers(MapMode.IsOdd);

Only takes as little as 3000 ticks, that is 10 times faster then what LINQ could do.

I must make it clear that this is not saying that LINQ is bad, LINQ is just very universal, and that means that it many times sacrifices performance over stability and compatibility.

Check the [wiki](https://github.com/kris701/SharpSpan/wiki) for more info!
