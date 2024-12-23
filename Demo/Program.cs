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





        }
    }
}
