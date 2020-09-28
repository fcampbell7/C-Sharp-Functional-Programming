 using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

class Program {
static void Main () {
    var input = Console.In;
    var text = input.ReadToEnd();
    String [] words = text.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
    try{
        var nums = words.Select(n => Int32.Parse(n)).ToArray();
        var x1 = nums.Select(n => n%2 == 0 ? n/2 : n);
        var x2 = x1.Distinct();
        Console.Write(x2.Sum());
    }
    catch(FormatException){
        Console.WriteLine("*** Input string was not in a correct format.");
    }
    catch(OverflowException){
      Console.WriteLine("*** Value was either too large or too small for an Int32.");
    }
    
}
}

