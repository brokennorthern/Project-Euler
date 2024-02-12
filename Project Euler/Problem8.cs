using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem8
    {
        public Problem8()
            {
                var Input = File.ReadAllText(@"C:\Users\Mark\source\repos\Project Euler\Project Euler\Problem8Input.txt");
                //string[] Stringput = Input.Trim().Split("\r\n");

                var Input2 = Input.Replace("\r\n", "");
                long max = 0;

                for (int i = 0; i < Input2.Length - 12; i++)
                {
                long temp = 1;
                    temp = temp * Int32.Parse(Input2[i].ToString())
                    * Int32.Parse(Input2[i + 1].ToString())
                    * Int32.Parse(Input2[i + 2].ToString())
                    * Int32.Parse(Input2[i + 3].ToString())
                    * Int32.Parse(Input2[i + 4].ToString())
                    * Int32.Parse(Input2[i + 5].ToString())
                    * Int32.Parse(Input2[i + 6].ToString())
                    * Int32.Parse(Input2[i + 7].ToString())
                    * Int32.Parse(Input2[i + 8].ToString())
                    * Int32.Parse(Input2[i + 9].ToString())
                    * Int32.Parse(Input2[i + 10].ToString())
                    * Int32.Parse(Input2[i + 11].ToString())
                    * Int32.Parse(Input2[i + 12].ToString());




                if (temp > max)
                    {
                        max = temp;
                    }
                }


                /*for (int i = 0; i < Stringput.Length; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 12; j < Stringput[0].Length; j++)
                        {
                            int temp = 0;
                            temp = (int)Char.GetNumericValue(Stringput[0][j]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 1]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 2]) * 
                                (int)Char.GetNumericValue(Stringput[0][j - 3]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 4]) * 
                                (int)Char.GetNumericValue(Stringput[0][j - 5]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 6]) * 
                                (int)Char.GetNumericValue(Stringput[0][j - 7]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 8]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 9]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 10]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 11]) *
                                (int)Char.GetNumericValue(Stringput[0][j - 12]);
                            if (temp > max)
                            {
                                max = temp;
                            }
                        }
                    } else
                    {
                        for (int j = 0; j < Stringput[i].Length; j++)
                        {
                            int temp = 0;
                            if (j == 0)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 7]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 8]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 9]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 10]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 11]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 12]);
                            }
                            else if (j == 1)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 7]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 8]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 9]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 10]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 11]);
                            }
                            else if (j == 2)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 7]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 8]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 9]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 10]);
                            }
                            else if (j == 3)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 7]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 8]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 9]);
                            }
                            else if (j == 4)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 7]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 8]);
                            }
                            else if (j == 5)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 7]);
                            }
                            else if (j == 6)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][6]) *
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 6]);
                            }
                            else if (j == 7)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][7]) *
                                    (int)Char.GetNumericValue(Stringput[i][6]) *
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 5]);
                            }
                            else if (j == 8)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][8]) *
                                    (int)Char.GetNumericValue(Stringput[i][7]) *
                                    (int)Char.GetNumericValue(Stringput[i][6]) *
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 4]);
                            }
                            else if (j == 9)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][9]) *
                                    (int)Char.GetNumericValue(Stringput[i][8]) *
                                    (int)Char.GetNumericValue(Stringput[i][7]) *
                                    (int)Char.GetNumericValue(Stringput[i][6]) *
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 3]);
                            }
                            else if (j == 10)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][10]) *
                                    (int)Char.GetNumericValue(Stringput[i][9]) *
                                    (int)Char.GetNumericValue(Stringput[i][8]) *
                                    (int)Char.GetNumericValue(Stringput[i][7]) *
                                    (int)Char.GetNumericValue(Stringput[i][6]) *
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 2]);
                            }
                            else if (j == 11)
                            {
                                temp =
                                    (int)Char.GetNumericValue(Stringput[i][11]) *
                                    (int)Char.GetNumericValue(Stringput[i][10]) *
                                    (int)Char.GetNumericValue(Stringput[i][9]) *
                                    (int)Char.GetNumericValue(Stringput[i][8]) *
                                    (int)Char.GetNumericValue(Stringput[i][7]) *
                                    (int)Char.GetNumericValue(Stringput[i][6]) *
                                    (int)Char.GetNumericValue(Stringput[i][5]) *
                                    (int)Char.GetNumericValue(Stringput[i][4]) *
                                    (int)Char.GetNumericValue(Stringput[i][3]) *
                                    (int)Char.GetNumericValue(Stringput[i][2]) *
                                    (int)Char.GetNumericValue(Stringput[i][1]) *
                                    (int)Char.GetNumericValue(Stringput[i][0]) *
                                    (int)Char.GetNumericValue(Stringput[i - 1][Stringput[i].Length - 1]);
                            }
                            else
                            {
                                temp = (int)Char.GetNumericValue(Stringput[i][j]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 1]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 2]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 3]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 4]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 5]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 6]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 7]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 8]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 9]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 10]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 11]) *
                                    (int)Char.GetNumericValue(Stringput[i][j - 12]);
                            }
                            if (temp > max)
                            {
                                max = temp;
                                Console.WriteLine($"The i is {i} and the j is {j} and the new max is {max}");

                            }
                            Console.WriteLine($"The i is {i} and the j is {j} and the current temp is {temp}");

                        }
                    }
                }*/
                Console.WriteLine(max);
        }
    }
}


