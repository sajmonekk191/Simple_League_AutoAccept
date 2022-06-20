using System;
using System.Threading;
using System.Windows.Forms;

namespace League_of_Legends_AutoAccept
{
    class Program
    {
        static bool select = false;
        public static bool Activated = false;
        public static System.Timers.Timer timer = new System.Timers.Timer(100);
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            timer.Enabled = true;
            timer.Elapsed += SelectPage;
            Thread animate = new Thread(AnimatedName);
            animate.Start();
            PrintLobby(3);
        }
        static void AnimatedName()
        {
            string nll = "";
            string tit = "League of Legends AutoAccept by skk11";
            while (true)
            {
                for (int i = 0; i < tit.Length; i++)
                {
                    Console.Title = nll += tit[i];
                    Thread.Sleep(80);
                }
                nll = "";
            }
        }
        static void SelectPage(Object source, System.Timers.ElapsedEventArgs e)
        {
            lw(Activated);
        }
        static void lw(bool activated)
        {
            short keyDown = Essentials.Imports.GetAsyncKeyState(Keys.Down);
            short keyUP = Essentials.Imports.GetAsyncKeyState(Keys.Up);
            short keyW = Essentials.Imports.GetAsyncKeyState(Keys.W);
            short keyS = Essentials.Imports.GetAsyncKeyState(Keys.S);
            short keyEnter = Essentials.Imports.GetAsyncKeyState(Keys.Enter);
            short keySpace = Essentials.Imports.GetAsyncKeyState(Keys.Space);
            bool keyDownIsPressed = ((keyDown >> 15) & 0x0001) == 0x0001;
            bool keyUpIsPressed = ((keyUP >> 15) & 0x0001) == 0x0001;
            bool keyWIsPressed = ((keyW >> 15) & 0x0001) == 0x0001;
            bool keySIsPressed = ((keyS >> 15) & 0x0001) == 0x0001;
            bool keyEnterIsPressed = ((keyEnter >> 15) & 0x0001) == 0x0001;
            bool keySpaceIsPressed = ((keySpace >> 15) & 0x0001) == 0x0001;
            if (keyDownIsPressed && !select || keySIsPressed && !select)
            {
                PrintLobby(1);
                select = true;
            }
            else if (keyUpIsPressed && select || keyWIsPressed && select)
            {
                PrintLobby(0);
                select = false;
            }
            else if (keyEnterIsPressed || keySpaceIsPressed)
            {
                if (!select)
                {
                    if(!Activated) Activated = true;
                    else Activated = false;

                    PrintLobby(0);
                }
                else Environment.Exit(0);
            }

            if (Activated)
            {
                Essentials.AutoAccept.FindMatch();
            }
            
        }
        static void PrintLobby(int part)
        {
            switch (part)
            {
                case 0:
                    {
                        Console.Clear();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"        #                           #                                      
       # #   #    # #####  ####    # #    ####   ####  ###### #####  ##### 
      #   #  #    #   #   #    #  #   #  #    # #    # #      #    #   #   
     #     # #    #   #   #    # #     # #      #      #####  #    #   #   
     ####### #    #   #   #    # ####### #      #      #      #####    #   
     #     # #    #   #   #    # #     # #    # #    # #      #        #   
     #     #  ####    #    ####  #     #  ####   ####  ###### #        #   
                                                                       ");
                        Console.ResetColor();
                        if (Activated)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("   Enabled AutoAccept  <-");
                        }
                        else Console.WriteLine("   Disabled AutoAccept  <-");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   Exit");
                    }
                    break;
                case 1:
                    {
                        Console.Clear();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"        #                           #                                      
       # #   #    # #####  ####    # #    ####   ####  ###### #####  ##### 
      #   #  #    #   #   #    #  #   #  #    # #    # #      #    #   #   
     #     # #    #   #   #    # #     # #      #      #####  #    #   #   
     ####### #    #   #   #    # ####### #      #      #      #####    #   
     #     # #    #   #   #    # #     # #    # #    # #      #        #   
     #     #  ####    #    ####  #     #  ####   ####  ###### #        #   
                                                                       ");
                        Console.ResetColor();
                        if (Activated)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("   Enabled AutoAccept");
                        }
                        else Console.WriteLine("   Disabled AutoAccept");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   Exit <-");
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(@"        #                           #                                      
       # #   #    # #####  ####    # #    ####   ####  ###### #####  ##### 
      #   #  #    #   #   #    #  #   #  #    # #    # #      #    #   #   
     #     # #    #   #   #    # #     # #      #      #####  #    #   #   
     ####### #    #   #   #    # ####### #      #      #      #####    #   
     #     # #    #   #   #    # #     # #    # #    # #      #        #   
     #     #  ####    #    ####  #     #  ####   ####  ###### #        #   
                                                                       ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("   Disabled AutoAccept  <-");
                    Console.WriteLine("   Exit");
                    break;
            }
        }

    }
}
