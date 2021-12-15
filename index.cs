    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static void Main() {
                var a = Add(1, 2);
                var b = Add(17, 13, 4);
                var c = Add(90, 10, 5, 4);
                
                Console.WriteLine(a); //3
                Console.WriteLine(b); //34
                Console.WriteLine(c); //109
                
            }
            
            public static int Add(params int[] val){
                int result = 0;
                foreach(var v in val){
                    result += v;
                }
            return result;
            }
        }
    }