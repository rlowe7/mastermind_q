using System;
using System.Collections.Generic;
using System.Text;


namespace Quadax_program
{
    class Validation
    {
        public string ValidateGuess(string guess)
        {
            string message = "";

            if (string.IsNullOrEmpty(guess))
            {
                message = "Please enter guess";
            }
            else if (guess.Length <= 3 || guess.Length >= 5)
            {
                message = "Your guess must be 4 digits in length";
            }
            else
            {
                
                int value = 0;
                char[] c = guess.ToCharArray();

                for (int i = 0; i <= 3; i++)
                {
                    
                    value  = (int)Char.GetNumericValue(c[i]);

                    if (value > 6)
                    {                                 
                        message = "Each digit must between 0 and 6";
                    }
                    
                }

            }
            return message;

            

        }
    }
}
