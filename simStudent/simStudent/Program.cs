﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simStudent
{
    class Program
    {
        static void Main(string[] args){
            Boolean dead = false;
            Student you = new Student("123456", 21, 15, new DateTime(05/ 11/2000), "you", 3.7f, 50, 50, 50, 50, 50);
            Console.WriteLine("Welcom to student Life Simulator 2000!\nPlease start your day below");
            while (dead == false)
            {
                
                Console.WriteLine(you.ToString());

                Console.WriteLine("Options");
                Console.WriteLine("1: Sleep");
                Console.WriteLine("2: Study");
                Console.WriteLine("3: Eat");
                Console.WriteLine("4: Shop");
                Console.WriteLine("5: Game");
                Console.WriteLine("6: Workout");
                Console.WriteLine("7: Quit");
                int selection = int.Parse(Console.ReadLine());
                if(selection == 1)
                {
                    Console.WriteLine("How long do you want to sleep for?");
                    int time = int.Parse(Console.ReadLine());
                    you.sleep(time);
                    dead = you.checkIfDead();
                }
                else if(selection == 2)
                {
                    Console.WriteLine("How long do you want to study for?");
                    int time = int.Parse(Console.ReadLine());
                    you.study(time);
                    dead = you.checkIfDead();
                }
                else if (selection == 3)
                {
                    Console.WriteLine("How long do you want to eat for?");
                    int time = int.Parse(Console.ReadLine());
                    you.eat(time);
                    dead = you.checkIfDead();
                }
                else if (selection == 4)
                {
                    Console.WriteLine("How long do you want to shop for?");
                    int time = int.Parse(Console.ReadLine());
                    you.shopping(time);
                    dead = you.checkIfDead();
                }
                else if (selection == 5)
                {
                    Console.WriteLine("How long do you want to game for?");
                    int time = int.Parse(Console.ReadLine());
                    you.playedVideoGames(time);
                    dead = you.checkIfDead();
                }
                else if (selection == 6)
                {
                    Console.WriteLine("How long do you want to workout for?");
                    int time = int.Parse(Console.ReadLine());
                    you.workout(time);
                    dead = you.checkIfDead();
                }
                else if (selection == 7)
                {
                    Console.WriteLine("Thank you good bye");
                    dead = true;
                }
                else
                {
                    Console.WriteLine("Input not valid. Try again");
                }
            }
            
            Console.ReadLine();


        }


    }


}
