using System;
using System.Linq;
System.Linq.Enumerable.Range(1, 10).ToList().ForEach(x => 
 {
     System.Linq.Enumerable.Range(1, x).ToList().ForEach(y =>
     {
         Console.Write(y);
     });
     Console.WriteLine();
 });