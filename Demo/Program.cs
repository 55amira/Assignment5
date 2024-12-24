namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing And UnBoxing

            ////Boxing 

            //object O1;

            //O1 = 1;
            //O1 = "Ahmed";
            //O1 = 3;

            //O1 = 1.5;
            //O1 = "a";
            //O1 = true;
            //O1 = new DateTime();     

            //UnBoxing
            //object O1 = 3;
            //int X =(int) O1; //unsafe 
            #endregion

            #region Nullable
            //Nullable 
            //Value Type

            //int x = 6;
            // x = null;

            //int? Age = null; //Nullable<int>

            //double? B = null;   //Nullable<double>

            //int x = 5;

            //int? y = x;
            //int? x = 5;
            //int y;
            //y= x;//error 
            //if (x != null)
            //    y = (int)x;
            //else
            //    y = 0;
            //if (x is not null)
            //    y = (int)x;
            //else
            //    y = 0;
            //if (x.HasValue)
            //    y = x.Value;
            //else
            //    y = 0;

            //y=x.HasValue? x.Value : 0;  
            //y=x is not null ? x.Value: 0;
            //y = x ?? 0;
            //Console.WriteLine(y);


            //Nullable Reference Type 

            //string Message = null;
            //string? Message2 = null;
            //Console.WriteLine(Message);
            //Console.WriteLine(Message2);

            #endregion

            #region Null Propagation Operater ?

            ////Null Propagation Operater ?

            //double X = default;
            //bool C = default;

            //int[] Arr = default;
            ////int[] Arr ={1,2,3};
            ////for (int i = 0; i < args.Length; i++)
            ////{
            ////    Console.WriteLine(args[i]);
            ////}

            ////for (int i = 0;(Arr is not null)&& i < args.Length; i++)
            ////{
            ////    Console.WriteLine(Arr[i]);
            ////}

            ////if(Arr is not null)
            ////{
            ////    for (int i = 0; i < Arr.Length; i++)
            ////    {
            ////        Console.WriteLine(Arr[i]);
            ////    }
            ////}

            ////for (int i = 0; i < Arr?.Length; i++)
            ////{
            ////    Console.WriteLine(Arr[i]);
            ////}
            //// int len=Arr?.Length?? 0;    
            #endregion
        }
    }
}
