using System;

namespace BlazorAplication.Client.Helpers
{
    public class CostomGreeting
    {
        public static string customGreeting(string value)
        {
            return value.ToUpper() + " hoje é " + DateTime.Today  ;
        }

    }

}