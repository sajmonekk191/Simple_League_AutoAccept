using System;
using System.Threading;
using System.Windows.Forms;

namespace League_of_Legends_AutoAccept
{
    class Program
    {
        static bool select = false;
        static bool Activated = false;
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(70);
            timer.Elapsed += SelectPage;
            timer.Enabled = true;
            Thread animate = new Thread(AnimatedName);
            animate.Start();
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
            Console.WriteLine("   Enable AutoAccept  <-");
            Console.WriteLine("   Exit");
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
            short keyDown = Essentials.Keyboard.GetAsyncKeyState(Keys.Down);
            short keyUP = Essentials.Keyboard.GetAsyncKeyState(Keys.Up);
            short keyW = Essentials.Keyboard.GetAsyncKeyState(Keys.W);
            short keyS = Essentials.Keyboard.GetAsyncKeyState(Keys.S);
            short keyEnter = Essentials.Keyboard.GetAsyncKeyState(Keys.Enter);
            short keySpace = Essentials.Keyboard.GetAsyncKeyState(Keys.Space);
            bool keyDownIsPressed = ((keyDown >> 15) & 0x0001) == 0x0001;
            bool keyUpIsPressed = ((keyUP >> 15) & 0x0001) == 0x0001;
            bool keyWIsPressed = ((keyW >> 15) & 0x0001) == 0x0001;
            bool keySIsPressed = ((keyS >> 15) & 0x0001) == 0x0001;
            bool keyEnterIsPressed = ((keyEnter >> 15) & 0x0001) == 0x0001;
            bool keySpaceIsPressed = ((keySpace >> 15) & 0x0001) == 0x0001;
            if (keyDownIsPressed && !select || keySIsPressed && !select)
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
                if(activated)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("   Disabled AutoAccept");
                }
                else Console.WriteLine("   Disabled AutoAccept");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   Exit <-");
                select = true;
            }
            else if (keyUpIsPressed && select || keyWIsPressed && select)
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
                if (activated)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("   Enabled AutoAccept  <-");
                }
                else Console.WriteLine("   Enabled AutoAccept  <-");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   Exit");
                select = false;
            }
            else if (keyEnterIsPressed || keySpaceIsPressed)
            {
                if (!select) Activated = true;
                else Environment.Exit(0);
            }
        }

    }
}
