using System;
using System.Collections.Generic;
using System.Text;


namespace Quadax_program
{
    class Answer
    {
        public static string CreateAnswer()
        {
           
            Random random = new Random();
            string randomNumber = "";

            for(int x=0; x<=3; x++)
            {
                randomNumber += random.Next(7);
            }

            return randomNumber;
        } 
    }
}
