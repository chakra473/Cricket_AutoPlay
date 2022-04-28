using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketAutoPlay
{
    internal class Cricket
    {
        public void autoPlay()
        {
            int Rohit = 0, Virat = 0, Shreyas = 0, SKyadav = 0, KLrahul = 0, Pant = 0, Jadeja = 0, Hardik = 0, Bumrah = 0, Chahal = 0, Shami = 0;
            int Ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, six = 0,total=0,wicket=0,dots=0;
            int balls = 0,b1=0,b2=0,b3=0,b4=0,b5=0,b6=0,b7=0,b8=0,b9=0,b10=0,b11=0;
            int w1=0, w2=0, w3=0, w4=0, w5=0,w6=0,w7=0,w8=0,w9=0,w10=0,w11=0;
            while (balls < 120 && wicket < 10)
            {
                int[] values = {0,0,0,0,0,0,0,0,0,0,0,10, 1,1,1,1,1,1,1,1,1,1,1, 2,2,2,10,2,2,2,3,3,4,4,4,4,4,4,6,6,6,0,
                           10,5};
                Random random = new Random();
                int score;
                do//rohit's score
                {
                    score=values[random.Next(0, values.Length)];
                    if (w1 == 0 && balls < 120)
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Rohit = Rohit + score;b1++; break;
                            case 2: twos++; total = total + score; balls++; ; Rohit = Rohit + score; b1++; break;
                            case 3: threes++; total = total + score; balls++; ; Rohit = Rohit + score; b1++; break;
                            case 4: fours++; total = total + score; balls++; ; Rohit = Rohit + score; b1++; break;
                            case 5: fives++; total = total + score; balls++; ; Rohit = Rohit + score; b1++; break;
                            case 6: six++; total = total + score; balls++; ; Rohit = Rohit + score; b1++; break;
                            case 10: wicket++; balls++; ; Rohit = Rohit + 0; w1 = 1; b1++; break;
                            default: dots++; total = total + 0; balls++; ; Rohit = Rohit + 0; b1++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w1 == 0 && balls < 120));

                
                do//viratt's score
                {
                    score = values[random.Next(0, values.Length)];
                    if (w2 == 0 && balls < 120)
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Virat = Virat + score; b2++; break;
                            case 2: twos++; total = total + score; balls++; ; Virat = Virat + score; b2++; break;
                            case 3: threes++; total = total + score; balls++; ; Virat = Virat + score; b2++; break;
                            case 4: fours++; total = total + score; balls++; ; Virat = Virat + score; b2++; break;
                            case 5: fives++; total = total + score; balls++; ; Virat = Virat + score; b2++; break;
                            case 6: six++; total = total + score; balls++; ; Virat = Virat + score; b2++; break;
                            case 10: wicket++; balls++; ; Virat = Virat + 0; w2 = 1; b2++; break;
                            default: dots++; total = total + 0; balls++; ; Virat = Virat + 0; b2++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w2 == 0 && balls < 120));
                
                do//shreyas's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w3 == 0) && (wicket >= 1 && balls < 120))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Shreyas = Shreyas + score; b3++; break;
                            case 2: twos++; total = total + score; balls++; ; Shreyas = Shreyas + score; b3++; break;
                            case 3: threes++; total = total + score; balls++; ; Shreyas = Shreyas + score; b3++; break;
                            case 4: fours++; total = total + score; balls++; ; Shreyas = Shreyas + score; b3++; break;
                            case 5: fives++; total = total + score; balls++; ; Shreyas = Shreyas + score; b3++; break;
                            case 6: six++; total = total + score; balls++; ; Shreyas = Shreyas + score; b3++; break;
                            case 10: wicket++; balls++; ; Shreyas = Shreyas + 0; w3 = 1; b3++; break;
                            default: dots++; total = total + 0; balls++; ; Shreyas = Shreyas + 0; b3++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w3 == 0) && (wicket>1 && balls < 120));
                
                do//SKyadavs's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w4 == 0) && (wicket >= 2 && balls < 120))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; SKyadav = SKyadav + score; b4++; break;
                            case 2: twos++; total = total + score; balls++; ; SKyadav = SKyadav + score; b4++; break;
                            case 3: threes++; total = total + score; balls++; ; SKyadav = SKyadav + score; b4++; break;
                            case 4: fours++; total = total + score; balls++; ; SKyadav = SKyadav + score; b4++; break;
                            case 5: fives++; total = total + score; balls++; ; SKyadav = SKyadav + score; b4++; break;
                            case 6: six++; total = total + score; balls++; ; SKyadav = SKyadav + score; b4++; break;
                            case 10: wicket++; balls++; ; SKyadav = SKyadav + 0; w4 = 1; b4++; break;
                            default: dots++; total = total + 0; balls++; ; SKyadav = SKyadav + 0; b4++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5  && balls % 6 == 0)) && w4 == 0) && (wicket >= 2 && balls < 120));
                
                do//klrahul's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w5 == 0) && (wicket >= 3 && balls < 120))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; KLrahul = KLrahul + score; b5++; break;
                            case 2: twos++; total = total + score; balls++; ; KLrahul = KLrahul + score; b5++; break;
                            case 3: threes++; total = total + score; balls++; ; KLrahul = KLrahul + score; b5++; break;
                            case 4: fours++; total = total + score; balls++; ; KLrahul = KLrahul + score; b5++; break;
                            case 5: fives++; total = total + score; balls++; ; KLrahul = KLrahul + score; b5++; break;
                            case 6: six++; total = total + score; balls++; ; KLrahul = KLrahul + score; b5++; break;
                            case 10: wicket++; balls++; ; KLrahul = KLrahul + 0; w5 = 1; b5++; break;
                            default: dots++; total = total + 0; balls++; ; KLrahul = KLrahul + 0; b5++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w5 == 0) && (wicket >= 3 && balls < 120));
                
                do//Pant's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w6 == 0) && (wicket >= 4)&&balls<120)
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Pant = Pant + score; b6++; break;
                            case 2: twos++; total = total + score; balls++; ; Pant = Pant + score; b6++; break;
                            case 3: threes++; total = total + score; balls++; ; Pant = Pant + score; b6++; break;
                            case 4: fours++; total = total + score; balls++; ; Pant = Pant + score; b6++; break;
                            case 5: fives++; total = total + score; balls++; ; Pant = Pant + score; b6++; break;
                            case 6: six++; total = total + score; balls++; ; Pant = Pant + score; b6++; break;
                            case 10: wicket++; balls++; ; Pant = Pant + 0; w6 = 1; b6++; break;
                            default: dots++; total = total + 0; balls++; ; Pant = Pant + 0; b6++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w6 == 0) && (wicket >= 4 && balls<120));
                
                do//Jadeja's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w7 == 0) && (wicket >= 5 && balls < 120))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Jadeja = Jadeja + score;b7++; break;
                            case 2: twos++; total = total + score; balls++; ; Jadeja = Jadeja + score;b7++; break;
                            case 3: threes++; total = total + score; balls++; ; Jadeja = Jadeja + score;b7++; break;
                            case 4: fours++; total = total + score; balls++; ; Jadeja = Jadeja + score;b7++; break;
                            case 5: fives++; total = total + score; balls++; ; Jadeja = Jadeja + score;b7++; break;
                            case 6: six++; total = total + score; balls++; ; Jadeja = Jadeja + score;b7++; break;
                            case 10: wicket++; balls++; ; Jadeja = Jadeja + 0; w7 = 1;b7++; break;
                            default: dots++; total = total + 0; balls++; ; Jadeja = Jadeja + 0;b7++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w7 == 0) && (wicket >= 5 && balls<120));
                
                do//Hardik's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w8 == 0) && (wicket >= 6 && balls < 120))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Hardik = Hardik + score;b8++; break;
                            case 2: twos++; total = total + score; balls++; ; Hardik = Hardik + score;b8++; break;
                            case 3: threes++; total = total + score; balls++; ; Hardik = Hardik + score;b8++; break;
                            case 4: fours++; total = total + score; balls++; ; Hardik = Hardik + score;b8++; break;
                            case 5: fives++; total = total + score; balls++; ; Hardik = Hardik + score;b8++; break;
                            case 6: six++; total = total + score; balls++; ; Hardik = Hardik + score;b8++; break;
                            case 10: wicket++; balls++; ; Hardik = Hardik + 0; w8 = 1;b8++; break;
                            default: dots++; total = total + 0; balls++; ; Hardik = Hardik + 0;b8++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w8 == 0) && (wicket >= 6 && balls < 120));
                
                do//Bumrah's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w9 == 0 && balls < 120) && (wicket >= 7 && wicket < 10))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Bumrah = Bumrah + score;b9++; break;
                            case 2: twos++; total = total + score; balls++; ; Bumrah = Bumrah + score;b9++; break;
                            case 3: threes++; total = total + score; balls++; ; Bumrah = Bumrah + score;b9++; break;
                            case 4: fours++; total = total + score; balls++; ; Bumrah = Bumrah + score;b9++; break;
                            case 5: fives++; total = total + score; balls++; ; Bumrah = Bumrah + score;b9++; break;
                            case 6: six++; total = total + score; balls++; ; Bumrah = Bumrah + score;b9++; break;
                            case 10: wicket++; balls++; ; Bumrah = Bumrah + 0; w9 = 1;b9++; break;
                            default: dots++; total = total + 0; balls++; ; Bumrah = Bumrah + 0;b9++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w9 == 0) && (wicket == 7 || wicket > 7 && balls < 120));
               
                do//Shami's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w10 == 0 && balls < 120) && (wicket >= 8 && wicket <10))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Shami = Shami + score;b10++; break;
                            case 2: twos++; total = total + score; balls++; ; Shami = Shami + score;b10++; break;
                            case 3: threes++; total = total + score; balls++; ; Shami = Shami + score;b10++; break;
                            case 4: fours++; total = total + score; balls++; ; Shami = Shami + score;b10++; break;
                            case 5: fives++; total = total + score; balls++; ; Shami = Shami + score;b10++; break;
                            case 6: six++; total = total + score; balls++; ; Shami = Shami + score;b10++; break;
                            case 10: wicket++; balls++; ; Shami = Shami + 0; w10 = 1;b10++; break;
                            default: dots++; total = total + 0; balls++; ; Shami = Shami + 0;b10++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w10 == 0) && (wicket >= 8 && balls < 120));
                
                do//Chahal's score
                {
                    score = values[random.Next(0, values.Length)];
                    if ((w11 == 0 && balls < 120) && (wicket >= 9&&wicket<10))
                    {
                        switch (score)
                        {
                            case 1: Ones++; total = total + score; balls++; Chahal = Chahal + score;b11++; break;
                            case 2: twos++; total = total + score; balls++; ; Chahal = Chahal + score;b11++; break;
                            case 3: threes++; total = total + score; balls++; ; Chahal = Chahal + score;b11++; break;
                            case 4: fours++; total = total + score; balls++; ; Chahal = Chahal + score;b11++; break;
                            case 5: fives++; total = total + score; balls++; ; Chahal = Chahal + score;b11++; break;
                            case 6: six++; total = total + score; balls++; ; Chahal = Chahal + score;b11++; break;
                            case 10: wicket++; balls++; ; Chahal = Chahal + 0; w11 = 1;b11++; break;
                            default: dots++; total = total + 0; balls++; ; Chahal = Chahal + 0;b11++; break;

                        }
                    }
                } while ((((score == 2 || score == 4 || score == 6 || score == 0 || score == 7 || score == 8 || score == 9 && balls % 6 != 0) || (score == 1 || score == 3 || score == 5   && balls % 6 == 0)) && w11 == 0) && (wicket >= 9 && balls < 120));
            
            }
            List<int> notout = new List<int>();
            notout.Add(w1);
            notout.Add(w2);
            notout.Add(w3);
            notout.Add(w4);
            notout.Add(w5);
            notout.Add(w6);
            notout.Add(w7);
            notout.Add(w8);
            notout.Add(w9);
            notout.Add(w10);
            notout.Add(w11);
            string n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11;
            for(int i=0; i<notout.Count; i++)
            {
                if(notout[i] == 0)
                {
                    int z = i + 1;
                    Console.WriteLine($"{z} *");
                   
                }
            }
            int div = 0, rem = 0;
            div = balls / 6;
            rem = balls % 6;
            

       

            Console.WriteLine($"1.ROHIT SHARMA {Rohit} ({b1})");
            Console.WriteLine($"2.VIRAT KOHLI {Virat} ({b2})");
            Console.WriteLine($"3.SHREYAS IYER {Shreyas} ({b3})");
            Console.WriteLine($"4.SURYAKUMAR YADAV {SKyadav} ({b4})");
            Console.WriteLine($"5.KL RAHUL {KLrahul} ({b5})");
            Console.WriteLine($"6.RISHAB PANT {Pant} ({b6})");
            Console.WriteLine($"7.RAVINDRA JADEJA {Jadeja} ({b7})");
            Console.WriteLine($"8.HARDIK PANDYA {Hardik} ({b8})");
            Console.WriteLine($"9.JASPRIT BUMRAH {Bumrah} ({b9})");
            Console.WriteLine($"10.MOHAMMAD SHAMI {Shami} ({b10})");
            Console.WriteLine($"11.YUZVENDRA CHAHAL {Chahal} ({b11})");
            Console.WriteLine($"TOTAL SCORE OF INDIA ({total}-{wicket}) ({div}.{rem} OVERS)");
            Console.WriteLine($"TOTAL BALLS {balls}");
            Console.WriteLine($"TOTAL 4s {fours}");
            Console.WriteLine($"TOTAL 6s {six}");
            Console.WriteLine($"TOTAL 0s {dots}");
        }
    }
}
