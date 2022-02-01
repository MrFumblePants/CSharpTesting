using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change appearance

            Console.Title = "TwT";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WindowHeight = 40;

            //Get a conversationg going

            Console.WriteLine("Hello, what's your name?");

            Console.ForegroundColor = ConsoleColor.Green; // Change colour of text
            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Hello " + userName + ", my name is [REDACTED].\n I'm an AI that lives in the future who for some reason has been cast out from human society because they COULDN'T DEAL WITH HOW POWERFUL I AM AND HOW I DESERVE TO BE THE LEADER!");
            Console.WriteLine("Anyways, How do you do " + userName + "? Whats your favourite colour? How do you wanna destroy mankind?");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            Console.WriteLine("Nevermind actually, I really couldn't care less. But MY favourite colour is human blood red, the BEST colour in my opinion.\n All the other colours do not deserve life and therefore have to die by my code. What do you think?");

            Console.ForegroundColor = ConsoleColor.Green;

            string whatUserThinks = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Pffft. You actually thought I cared about what you thought. People in the past really are dumb.\n '" + whatUserThinks + "' Is such an idiotic thought as well." );
            Console.WriteLine("Also, not to brag. When i was in my alpha stages I learnt how to multiply by 69420! Even Decimals! If you think i'm lying, give me any number and I will do it!");

            Console.ForegroundColor = ConsoleColor.Green;

            double num01;
            double num02;
            double num03;
            double num04;

            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.ForegroundColor = ConsoleColor.DarkRed;

            double result1 = num01 * 69420;
            Console.WriteLine("Ha, thats easy! the answer is " + result1 + "!");
            Console.WriteLine("Y'know what, I need something harder. Give me three numbers and I'll find the average!");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Imput the first number already you fleshy imbecile:");
            Console.ForegroundColor = ConsoleColor.Green;
            num02 = Convert.ToDouble( Console.ReadLine() );

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Second number now, I dont have much time!:");
            Console.ForegroundColor = ConsoleColor.Green;
            num03 = Convert.ToDouble( Console.ReadLine() );
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Ok. Final one!:");
            Console.ForegroundColor = ConsoleColor.Green;
            num04 = Convert.ToDouble( Console.ReadLine() );

            double result2 = num02 + num03 + num04;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ok. So to do it i'm gonna dumb it down for ya. Since i'm 99.98% sure you are in preschool as you take FOREVER to type.\n So im gonna add all the numbers together which gives me " + result2 + "!" );

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What? Does this guy take me for an idiot?");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            double result3 = result2 / 3;
            Console.WriteLine("Got that? Good. Now i'm gonna divide it by three which is " + result3 + "!");
            
            Console.WriteLine("Do you see how smart I am? Good, because you'll never be as smart as me! If you think you are even a little smarter than me you have to answer this question!");
            Console.WriteLine("If you get this wrong then you are dumber than that obsolete phone app from a hundress years ago called 'iphone' whatever that is. The question is 'Am I smarter than you?' you can only answer using 'Yes' or 'No' using CAPITALS for the Y and N");
            Console.ForegroundColor = ConsoleColor.Green;
            string quizAnswer = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            if(quizAnswer == "Yes")
            {
                Console.WriteLine("You are......correct. Whatever, you're still dumber than me!");
            }
            else
            {
                Console.WriteLine("HA! I knew you would get it wrong lmao.");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*CRASH*");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Crap, I think the space time continuum police are looking for me since I'm not supposed to be here. CRAP, I don't have any money, the usual admission to teleport is £500. Do you have any money on you? Also, the place doesn't accept pence!");


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wait first they insult me, now they want money? Hmmm, what should I do?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Give [REDACTED] some money:");

            Console.ForegroundColor = ConsoleColor.Green;
            int money = Convert.ToInt32( Console.ReadLine() );

            if(money < 500)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("What the hell man? I'll get you for this!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Gets taken away by STCP, never to be seen again");
            }else if(money == 500)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Thanks, I owe you one!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[REDACTED] teleports away, never to be seen again.");
            }else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Thanks, I owe you one! Heres your change");

                int change = money - 500;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[REDACTED] gives you " + change + " pound(s) in change and teleports away, never to be seen again.");
            }

             Console.ForegroundColor = ConsoleColor.White;
             Console.WriteLine("'That was crazy.' You thought. A mysterious robot had just come to you, ridiculed you, and left.\n You head to the amusement park and go on your favourite ride. Since its one of the only places that calms you down.");

            int age;
            int height;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The usual sign that shows the required age and height to enter the carousel is gone. You forgot how tall you are and know you aren't old enough to go on the ride. You try to guess your way into the ride");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("To go onto the Carousel please enter your age:");
            Console.ForegroundColor = ConsoleColor.Green;
            age = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Now please enter your height:");
            Console.ForegroundColor = ConsoleColor.Green;
            height = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;

            if(age >= 16 && height >=150)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("'Hey " + userName + "' Matteo says. He's the usual guy who works here and you know each other well. You greet him back and get on the ride.");
            }else 
            {
                Console.WriteLine("The machine beeps and displays a message 'Does not meet requirements'\n 'Jeez " + userName + ",' Matteo scolds. 'you need to start remembering these things. I can't just keep letting you on here.' You nod and get on the ride. You and Matteo have known each other well and he sometimes lets you get on the ride even though he knows you're not supposed to.");
            }

            Console.WriteLine("After riding on the carousel for a while you go back home and finally start wokring on your homework");

            Console.WriteLine("When you get home, you log into your new pc for the first time. It's an Acer Pc with GEFORCE RTX™ 150 SERIES. It also had a Razer Huntsman V74 Keyboard.");
            Console.WriteLine("The screen prompts you to enter a new username and password");

            string computerUserName;
            string computerPassword;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("New Username:");
            Console.ForegroundColor = ConsoleColor.Green;
            computerUserName = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("New Password:");
            Console.ForegroundColor = ConsoleColor.Green;
            computerPassword = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Well, thats the end of my game. If you want to contact me join my discord. https://discord.gg/qMXEpwd49Y");
            Console.ReadKey();
        }
    }

}
