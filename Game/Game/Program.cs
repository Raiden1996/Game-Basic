using GraphDLL;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    class Program
    {

         static void PlayAgain()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("zw2.png", 0, 0, 800, 600);
                if (x > 233 && y > 310 & x < 333 && y < 415 && click == 1)
                {
                    Graph.nosound();
                    Graph.playsound("1.mp3");
                    newgame();
                }  //yes
                if (x > 444 && y > 303 & x < 597 && y < 409 && click == 1)
                {
                    Graph.nosound();
                    mainmenu();
                }  //no
                
            }
        }
        static void D()
        {
            Graph.delay(500);
        }
        static int score = 0;
        static void GameOver()
        
        {

            Graph.image("Final.png", 0, 0, 800, 600);
            Graph.delay(7000);
           Graph.image("zw.png", 0, 0, 800, 600);
                Graph.delay(50);
                Graph.copybackground();
                Graph.setcolor(Color.Brown);    
            Graph.setfont("Rosewood", FontStyle.Regular, 40);
                Graph.pastebackground();    
            Graph.outtextxy(50,100, "Your Final Score =" + score);
            Graph.outtextxy(50, 150,"To See How Your Score Is Going To");
            Graph.outtextxy(50, 250, "Be Counted,Use This Formula :");
            Graph.outtextxy(50, 350, "Result = Your Score * 11.6");
            Graph.outtextxy(50, 450, "Final =" + score * 11.6);
            Graph.delay(9000);
            Graph.image("Final2.png", 0, 0, 800, 600);
            Graph.delay(12000);
            PlayAgain();
            }
        static void Q15()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("15q.png", 0, 0, 800, 600);
                if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                {
                    score++;
                    D();
                    GameOver();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1)
                    {
                        D();GameOver();
                    } 
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1)
                    {
                        D();GameOver();
                    } 
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                    {
                        D();GameOver();
                    } 
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                    {
                        D();GameOver();
                    } 
                }
}
        }
        static void Q14()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("14q.png", 0, 0, 800, 600);
                if (x > 723 && y > 488 & x < 752 && y < 510 && click == 1)
                {
                    score++;
                    D();
                    Q15();
                }
                else
                {
                    if (x > 611 && y > 507 & x < 643 && y < 535 && click == 1)
                    {
                        D();Q15();
                    } 
                }
            }
        }
        static void Q13()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("13q.png", 0, 0, 800, 600);
                if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1)
                {
                    score++;
                    D();
                    Q14();
                }
                else
                {
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q14();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                    {
                        D();Q14();
                    } 
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                    {
                        D();Q14();
                    } 
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                    {
                        D();Q14();
                    } 
                }
            }
        }
        static void Q12()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("12q.png", 0, 0, 800, 600);
                if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1)
                {
                    score++;
                    D();
                    Q13();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q13();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                    {
                        D();Q13();
                    } 
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                    {
                        D();Q13();
                    } 
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                    {
                        D();Q13();
                    } 
                }
            }
        }
        static void Q11()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("11q.png", 0, 0, 800, 600);
                if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                {
                    score++;
                    D();
                    Q12();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q12();
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q12();
                    }
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1) 
                    {
                        D();Q12();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1) 
                    {
                        D();Q12();
                    }

                }
            }
        }
        static void Q10()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("10q.png", 0, 0, 800, 600);
                if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                {
                    score++;
                    D();
                    Q11();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q11();
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q11();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1) 
                    {
                        D();Q11();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                    {
                        D();Q11();
                    }
                }
            }
        }
        static void Q9()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("9q.png", 0, 0, 800, 600);
                if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                {
                    score++;
                    D();
                    Q10();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q10();
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q10();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1) 
                    {
                        D();Q10();
                    }
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                    {
                        D();Q10();
                    }
                }
            }
        }
        static void Q8()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("8q.png", 0, 0, 800, 600);
                if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                {
                    score++;
                    D();
                    Q9();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q9();
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q9();
                    }
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1) 
                    {
                        D();Q9();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1) 
                    {
                        D();Q9();
                    }
                }
           }
        }
        static void Q7()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("7q.png", 0, 0, 800, 600);
                if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                {
                    score++;
                    D();
                    Q8();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q8();
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q8();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1) 
                    {
                        D();Q8();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1) 
                    {
                        D();Q8();
                    }
                }
            }
        }
        static void Q6()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("6q.png", 0, 0, 800, 600);
                if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1)
                {
                    score++;
                    D();
                    Q7();
                }
                else
                {
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q7();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1) 
                    {
                        D();Q7();
                    }
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1) 
                    {
                        D();Q7();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1) 
                    {
                        D();Q7();
                    }
                }
            }
        }
        static void Q5()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("5q.png", 0, 0, 800, 600);
                if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                {
                    score++;
                    D();
                    Q6();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q6();
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1) 
                    {
                        D();Q6();
                    }
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1) 
                    {
                        D();Q6();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1) 
                    {
                        D();Q6();
                    }
                }
            }
        }
        static void Q4()
        {
            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("4q.png", 0, 0, 800, 600);
                if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1)
                {

                    score++;
                    D();
                    Q5();
                }
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1) 
                    {
                        D();Q5();
                    }
                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1) 
                    {
                        D();Q5();
                    }
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1) 
                    {
                        D();Q5();
                    }
                    if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1) 
                    {
                        D();Q5();
                    }
                }
            }
        }
        static void Q3()
       {
           for (; ; )
           {
               int x, y, click;
               Graph.getmouse(out x, out y, out click);
               Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
               Graph.delay(0);
               Graph.image("3q.png", 0, 0, 800, 600);
               if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
               {
                   score++;
                   D();
                   Q4();
               }
               else
               {
                   if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1)
                   {
                       D();Q4();
                   } 
                   if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1)
                   {
                       D();Q4();
                   } 
                   if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                   {
                       D();Q4();
                   } 
                   if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                   {
                       D();Q4();
                   } 
               }
           }
       }
        static void Q2()
       {
           for (; ; )
           {
               int x, y, click;
               Graph.getmouse(out x, out y, out click);
               Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
               Graph.delay(0);
               Graph.image("2q.png", 0, 0, 800, 600);
               if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
               {
                   score++;
                   D();
                   Q3();
               }
               else
               {
                   if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1)
                   {
                       D();Q3();
                   } 
                   if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1)
                   {
                       D();Q3();
                   } 
                   if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                   {
                       D();Q3();
                   } 
                   if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                   {
                       D();Q3();
                   } 
               } 
           }
               
          
       }
        static void Q1()
        {
              for (; ; )
               {
                   int x, y, click;
                   Graph.getmouse(out x, out y, out click);
                   Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                   Graph.delay(0); 
                Graph.image("1q.png", 0, 0, 800, 600);
                if (x > 760 && y > 470 & x < 790 && y < 500 && click == 1)
                {
                    score++;
                    D();
                    Q2();
}
                else
                {
                    if (x > 550 && y > 510 & x < 580 && y < 534 && click == 1)
                    {
                        D(); Q2(); 
                    }
                    if (x > 605 && y > 500 & x < 637 && y < 525 && click == 1)
                    {
                        D(); Q2();
                  } 

                    if (x > 654 && y > 490 & x < 687 && y < 517 && click == 1)
                    {
                        D();Q2();
                    } 
                    if (x > 710 && y > 480 & x < 740 && y < 510 && click == 1)
                    {
                        D();Q2();
                    } 
                }
                    }
              
        }
        
        static void newgame()
        {
            Graph.playsound("1.mp3");
            
            int n = 5;
            for (int i = 1; i <= 5; i++)
            {
                Graph.image("1i" + n + ".png", 0, 0, 800, 600);
                n = n - 1;
                Graph.delay(350);
            }
            Graph.image("1i1.png", 0, 0, 800, 600);
            Graph.delay(7500);
            Graph.playsound("Count.mp3");
            int m=5;
            for (int i = 1; i <=5; i++)
            {
                Graph.image("1s" + m + ".png", 0, 0, 800, 600);
                m = m - 1;
                Graph.delay(1200);
            }
            Graph.image("Go.jpg", 0, 0, 800, 600);
            Graph.delay(1000);
          Graph.playsound("6.mp3");
        
            Q1(); 
          Q2();
          Q3();
          Q4();
          Q5();
          Q6();
          Q7();
          Q8();
          Q9();
          Q10();
          Q11();
          Q12();
          Q13();
          Q13();
          Q14();
          Q15();
          if (Graph.isplaying)
          {
          }
          else
          {
              Graph.playsound("6.mp3");
          }
         
}
        
        static void credits()
        {

            Graph.playsound("1.mp3");
            int n=1;
           for (int i = 1; i <= 5; i++)
           {
               Graph.image("4d" + n + ".png", 0, 0, 800, 600);
               n = n + 1;
               Graph.delay(350);
           }
           
           
            for (;;)
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
               Graph.image("4d4.png", 0, 0, 800, 600);
                
                if (x > 88 && y > 484 & x < 213 && y < 542 && click == 1)
                {
                    Graph.playsound("2.mp3");
                    mainmenu(); 
                }
            }  
               
       }
        static void help()
        {
            Graph.playsound("1.mp3");
            int n = 1;
            for (int i = 1; i <= 5; i++)
            {
                Graph.image("6d" + n + ".png", 0, 0, 800, 600);
                n = n + 1;
                Graph.delay(350);
            }


            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("6d5.png", 0, 0, 800, 600);

                if (x > 88 && y > 484 & x < 213 && y < 542 && click == 1)
                {
                    Graph.playsound("2.mp3");
                    mainmenu();
                }
            }  
               
        }
        static void about()
        {
            

            Graph.playsound("1.mp3");
            int n = 1;
            for (int i = 1; i <= 5; i++)
            {
                Graph.image("7d" + n + ".png", 0, 0, 800, 600);
                n = n + 1;
                Graph.delay(350);
            }


            for (; ; )
            {
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                Graph.delay(0);
                Graph.image("7d5.png", 0, 0, 800, 600);

                if (x > 88 && y > 484 & x < 213 && y < 542 && click == 1)
                {
                    Graph.playsound("2.mp3");
                    mainmenu();
                }
            }  
               
        }
        static void exit()
        {
          for (; ; )
          {
              int x, y, click;
              Graph.getmouse(out x, out y, out click);
              Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
              Graph.delay(0);
              Graph.playsound("1.mp3");
              Graph.image("5d1.png", 0, 0, 800, 600);
             if (x > 443 && y > 318 & x < 613 && y < 426 && click==1)
              {
               Graph.playsound("1.mp3"); //nope
                  mainmenu();
              }
              if (x > 216 && y > 318 & x < 378 && y < 426 && click == 1)  //yep
              {
                 Graph.playsound("2.mp3"); 
                 break;
               }
        }
            Graph.closegraph();
        }
        static void mainmenu()
        {
           string pic = "1d1.png";

            Graph.hidemouse();
            for (; ; )
            {
                Graph.setcolor(Color.Black);
                Graph.image(pic, 0, 0, 800, 600);
                int x, y, click;
                Graph.getmouse(out x, out y, out click);
                Graph.image("z.png", x - 20, y - 20, x + 20, y + 20);
                                                          Graph.delay(0);
                if (x > 582 && y > 135 && x < 772 && y < 209)//New Game
                    if (click == 1) newgame(); else pic = "3d1.png";
                else
                    if (x > 582 && y > 220 && x < 772 && y < 294) //Credits
                        if (click == 1) credits(); else pic = "3d2.png";
                    else
                        if (x > 582 && y > 304 && x < 772 && y < 379) //Help
                            if (click == 1) help(); else pic = "3d3.png";
                        else
                            if (x > 582 && y > 393 && x < 772 && y < 467) //About
                                if (click == 1) about(); else pic = "3d4.png";
                            else
                                if (x > 582 && y > 479 && x < 772 && y < 555) //Exit
                                    if (click == 1) exit(); else pic = "3d5.png";
                                else pic = "1d1.png";
            }
        }
   static void Main(string[] args)
        {
            Graph.skiplogo();
            Graph.initgraph(800, 600);
       mainmenu();
       
        }
    }
}
