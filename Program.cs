using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections; 
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Codigo_Morse
{
    class Program
    {
                   
            private static readonly Dictionary<char, String> morse = new Dictionary<char, String>()
      { {'A' , ".-"}, {'B' , "-..."}, {'C' , "-.-."},  {'D' , "-.."},  {'E' , "."},  {'F' , "..-."},  {'G' , "--."}, {'H' , "...."},
        {'I' , ".."}, {'J' , ".---"},  {'K' , "-.-"}, {'L' , ".-.."}, {'M' , "--"},  {'N' , "-."},  {'O' , "---"},  {'P' , ".--."},  {'Q' , "--.-"},
    {'R' , ".-."},  {'S' , "..."}, {'T' , "-"}, {'U' , "..-"}, {'V' , "...-"},  {'W' , ".--"}, {'X' , "-..-"}, {'Y' , "-.--"},  {'Z' , "--.."}, {'0' , "-----"},
    {'1' , ".----"}, {'2' , "..---"},{'3' , "...--"}, {'4' , "....-"}, {'5' , "....."}, {'6' , "-...."}, {'7' , "--..."}, {'8' , "---.."}, {'9' , "----."},
    };

        static void Main(string[] args)
        {

              
             int dot = 128; 
             int dash  = dot * 3;  
             int wordPause = dot * 7; 
             List<string> count = new List<string>(); 
             List<string> count2 = new List<string>(); 
             string a = string.Empty; 
             string es = string.Empty; 
          
                for (int i = 0; i < args.Length; i++)
                {
                      a = args[i].ToUpper(); 
                     count.Add(a);  

                }
           

            foreach (string line in count)
            {

     
                char[] charac = line.ToCharArray();
               // sleep de palabas 

               foreach(char chara in charac){ 
                 string value = string.Empty;
                
                    if (morse.TryGetValue(chara, out value))
                    {    
                        //sleep letras 
                       
                       
                        Console.Write(value);
                            count2.Add(value);

                             foreach(char mila in value.ToCharArray()){
                                  if (mila == '.'){
                                      Console.Beep(300, dot); 
                                        Thread.Sleep(dot);
                                  } else if (mila == '-'){
                                        Console.Beep(300, dash); 
                                         Thread.Sleep(dot);
                              }   
                         }

                         Thread.Sleep(dash);                               
                   }                           
               }
               Console.Write(" ");
               //sleep palabras 
               Thread.Sleep(wordPause);
              
            }

        }
    }
}