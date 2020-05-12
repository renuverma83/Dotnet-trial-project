using System;
 namespace DotnetBot{
     public static class program {     
             public static void main(string[] args)
             {
                 string message="";
                 if(args.Length<1)
                 {
                     message="welcome to dot net core";
                 }
                 else{
                     foreach(string items in args)
                     {
                         message +=item;
                     }
                 }
             }
     }

 }
