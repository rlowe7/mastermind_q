using System;
using System.Collections.Generic;
using System.Text;

namespace Quadax_program
{
    class CompareGuessToAnswer
    {
        public string Compare(string guess, string answer)
        {

            StringBuilder sbGuess = new StringBuilder(guess);
            StringBuilder sbAnswer = new StringBuilder(answer);
            string key = "";
           

            
                //check for existing character
                for (int i = 0; i <= 3; i++)
                {
                    //check for right value and position
                    if (sbAnswer[i] == sbGuess[i])
                    {
                        key += "+";
                        sbAnswer[i] = 'x';
                    }
                }

                for (int j = 0; j <= 3; j++)
                {
                    if (sbAnswer.ToString().Contains(sbGuess[j]))
                    {
                       
                        
                        for(int x=0; x <= sbAnswer.Length-1; x++)
                        {
                            if(sbAnswer[x] ==sbGuess[j])
                            { 
                                key += "-";
                                sbAnswer[x] ='x';
                            }
                        }
                    }

                    
                }
                   
                return key;
        }
    }
}
