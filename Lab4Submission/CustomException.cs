using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Submission
{
    public class AgeException : Exception
    {
        public AgeException(): base("Above 18 Only!")
        {
            
        }
    }
    public class NaNException : Exception
    {
        public NaNException() : base("Input is not a number.")
        {

        }
    }

    public class DivideByZeroException : Exception
    {
        public DivideByZeroException() : base("Input can't be divided by zero.")
        {

        }
    }

    public class KucingValidation: Exception
    {
        public KucingValidation() : base("Input is not kucing")
        {

        }
    }
    public class NaturalNumberException : Exception
    {
       public NaturalNumberException():base("Not a natural number!")
        {

        }
    }

}
