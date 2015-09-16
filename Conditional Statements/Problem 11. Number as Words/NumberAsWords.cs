using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Number_as_Words
{
    class NumberAsWords
    {

        public static void one(string number){
            
            switch (number)
            {
                case "0": Console.WriteLine("Zero"); break;
                case "1": Console.WriteLine("One"); break;
                case "2": Console.WriteLine("Two"); break;
                case "3": Console.WriteLine("Three"); break;
                case "4": Console.WriteLine("Four"); break;
                case "5": Console.WriteLine("Five"); break;
                case "6": Console.WriteLine("Six"); break;
                case "7": Console.WriteLine("Seven"); break;
                case "8": Console.WriteLine("Eight"); break;
                case "9": Console.WriteLine("Nine"); break;
                default:
                    break;
            }
        }

        public static void two(string number)
        {
            string res = "";
            int x1 = int.Parse(number);
            int first = x1 / 10;
            int second = x1 % 10;
            switch (first)
            {
                case 2: res+="Twenty "; break;
                case 3: res+="Thirty "; break;
                case 4: res+="Fourty "; break;
                case 5: res+="Fifty "; break;
                case 6: res+="Sixty " ; break;
                case 7: res+="Seventy "; break;
                case 8: res+="Eighty " ; break;
                case 9: res+="Ninety " ; break;
                
                default:
                    break;
            }

            switch (second)
            {
                case 1: res += "one"; break;
                case 2: res += "two"; break;
                case 3: res += "three"; break;
                case 4: res += "four"; break;
                case 5: res += "five"; break;
                case 6: res += "six"; break;
                case 7: res += "seven"; break;
                case 8: res += "eight"; break;
                case 9: res += "nine"; break;

                default:
                    break;
            }
            Console.WriteLine(res);
        }

        public static void three(string number){
            string res = "";
            int n=int.Parse(number);
            int firstD=n/100;
            int sec=n/10;
            int secD=sec%10;
            int thirdD=n%10;
            
                switch (firstD)
                {
                        
                    case 1: res += "One hundred "; break;
                    case 2: res += "Two hundred "; break;
                    case 3: res += "Three hundred "; break;
                    case 4: res += "Four hundred "; break;
                    case 5: res += "Five hundred "; break;
                    case 6: res += "Six hundred "; break;
                    case 7: res += "Seven hundred "; break;
                    case 8: res += "Eight hundred "; break;
                    case 9: res += "Nine hundred "; break;
                    default:
                        break;
                }
                switch (secD)
                {
                  
                    case 1: 
                        if(thirdD!=0)
                        {
                            switch (thirdD)
                            {
                                case 0: res+="and ten"; break;
                                case 1: res+="and eleven"; break;
                                case 2: res+="and twelve"; break;
                                case 3: res+="and thirteen"; break;
                                case 4: res+="and fourteen"; break;
                                case 5: res+="and fifteen"; break;
                                case 6: res+="and sixteen"; break;
                                case 7: res+="and seventeen"; break;
                                case 8: res+="and eighteen"; break;
                                case 9: res+="and nineteen"; break;
                                
                                default:
                                    two(number);
                                    break;
                            }
                        }
                        ; break;
                    case 2:
                        if(secD==2){
                            switch (thirdD)
                            {
                                case 0: res += "and twenty"; break;
                                case 1: res += "and twenty one"; break;
                                case 2: res += "and twenty two"; break;
                                case 3: res += "and twenty three"; break;
                                case 4: res += "and twenty four"; break;
                                case 5: res += "and twenty five"; break;
                                case 6: res += "and twenty six"; break;
                                case 7: res += "and twenty seven"; break;
                                case 8: res += "and twenty eight"; break;
                                case 9: res += "and twenty nine"; break;
                                

                                default:
                                    
                                    break;
                            }
                        }
                       ; break;

                    case 3: if (secD == 3)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and thirty"; break;
                                case 1: res += "and thirty one"; break;
                                case 2: res += "and thirty two"; break;
                                case 3: res += "and thirty three"; break;
                                case 4: res += "and thirty four"; break;
                                case 5: res += "and thirty five"; break;
                                case 6: res += "and thirty six"; break;
                                case 7: res += "and thirty seven"; break;
                                case 8: res += "and thirty eight"; break;
                                case 9: res += "and thirty nine"; break;


                                default:

                                    break;
                            }
                        }
                        ; break;
                    case 4: if (secD == 4)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and fourty"; break;
                                case 1: res += "and fourty one"; break;
                                case 2: res += "and fourty two"; break;
                                case 3: res += "and fourty three"; break;
                                case 4: res += "and fourty four"; break;
                                case 5: res += "and fourty five"; break;
                                case 6: res += "and fourty six"; break;
                                case 7: res += "and fourty seven"; break;
                                case 8: res += "and fourty eight"; break;
                                case 9: res += "and fourty nine"; break;

                                default:

                                    break;
                            }
                        }
                        ; break;
                    case 5: if (secD == 5)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and fifty"; break;
                                case 1: res += "and fifty one"; break;
                                case 2: res += "and fifty two"; break;
                                case 3: res += "and fifty three"; break;
                                case 4: res += "and fifty four"; break;
                                case 5: res += "and fifty five"; break;
                                case 6: res += "and fifty six"; break;
                                case 7: res += "and fifty seven"; break;
                                case 8: res += "and fifty eight"; break;
                                case 9: res += "and fifty nine"; break;

                                default:

                                    break;
                            }
                        }
                        ; break;
                    case 6: if (secD == 5)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and sixty"; break;
                                case 1: res += "and sixty one"; break;
                                case 2: res += "and sixty two"; break;
                                case 3: res += "and sixty three"; break;
                                case 4: res += "and sixty four"; break;
                                case 5: res += "and sixty five"; break;
                                case 6: res += "and sixty six"; break;
                                case 7: res += "and sixty seven"; break;
                                case 8: res += "and sixty eight"; break;
                                case 9: res += "and sixty nine"; break;

                                default:

                                    break;
                            }
                        }
                        ; break;
                    case 7: if (secD == 7)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and seventy"; break;
                                case 1: res += "and seventy one"; break;
                                case 2: res += "and seventy two"; break;
                                case 3: res += "and seventy three"; break;
                                case 4: res += "and seventy four"; break;
                                case 5: res += "and seventy five"; break;
                                case 6: res += "and seventy six"; break;
                                case 7: res += "and seventy seven"; break;
                                case 8: res += "and seventy eight"; break;
                                case 9: res += "and seventy nine"; break;

                                default:

                                    break;
                            }
                        }
                        ; break;
                    case 8: if (secD == 8)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and eighty"; break;
                                case 1: res += "and eighty one"; break;
                                case 2: res += "and eighty two"; break;
                                case 3: res += "and eighty three"; break;
                                case 4: res += "and eighty four"; break;
                                case 5: res += "and eighty five"; break;
                                case 6: res += "and eighty six"; break;
                                case 7: res += "and eighty seven"; break;
                                case 8: res += "and eighty eight"; break;
                                case 9: res += "and eighty nine"; break;

                                default:

                                    break;
                            }
                        }
                        ; break;
                    case 9: if (secD == 9)
                        {
                            switch (thirdD)
                            {
                                case 0: res += "and ninety"; break;
                                case 1: res += "and ninety one"; break;
                                case 2: res += "and ninety two"; break;
                                case 3: res += "and ninety three"; break;
                                case 4: res += "and ninety four"; break;
                                case 5: res += "and ninety five"; break;
                                case 6: res += "and ninety six"; break;
                                case 7: res += "and ninety seven"; break;
                                case 8: res += "and ninety eight"; break;
                                case 9: res += "and ninety nine"; break;

                                default:

                                    break;
                            }
                        }
                        ; break;
                    default:
                        break;
                }

                Console.WriteLine(res);
            
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if(number.Length==1)
            {
                one(number);
            }
              
            else if(number.Length==2)
            {
                
                switch (number)
                {
                    case "10": Console.WriteLine("Ten"); break;
                    case "11": Console.WriteLine("Eleven"); break;
                    case "12": Console.WriteLine("Twelve"); break;
                    case "13": Console.WriteLine("Thirteen"); break;
                    case "14": Console.WriteLine("Fourteen"); break;
                    case "15": Console.WriteLine("Fifteen"); break;
                    case "16": Console.WriteLine("Sixteen"); break;
                    case "17": Console.WriteLine("Seventeen"); break;
                    case "18": Console.WriteLine("Eighteen"); break;
                    case "19": Console.WriteLine("Nineteen"); break;
                    case "20": Console.WriteLine("Twenty"); break;
                    default:
                        two(number);
                        break;
                }
            }
            else if(number.Length==3)
            {
                three(number);
            }
        }
    }
}
