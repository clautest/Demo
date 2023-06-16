using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Utilities
{
    public class Data
    {
        public static class Credentials
        {
            public static class Valid
            {
                public static string UsernameData = "standard_user";
                public static string Password = "secret_sauce";
            }

            public static class Invalid
            {
                public static string UsernameData = "user";
                public static string Password = "sauce";
            }

        }

    }
}
