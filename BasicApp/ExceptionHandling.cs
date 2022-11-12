using System;

namespace BasicApp
{
    public class ExceptionHandling
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception ex)
            {
               string exMessage= ex.Message;
               return 0;
            }
            finally
            {

            } 
        }
    }
}
