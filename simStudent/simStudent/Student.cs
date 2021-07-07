using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simStudent
{
    class Student{
        private string studentId;
        private uint age;
        private uint numCreditHours;
        private DateTime dateOfBirth;
        private String name;
        private float gpa;
        private double energy;
        private double satiation;
        private double health;
        private double happiness;
        private double money;

        #region Feilds
        public Student(){
            this.studentId = "000000";
            this.age = 0;
            this.numCreditHours = 0;
            this.dateOfBirth = new DateTime(0);
            this.name = "John Doe";
            this.gpa = 2.0f;
            this.energy = 50;
            this.satiation = 50;
            this.health = 50;
            this.happiness = 50;
            this.money = 50;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constuctor for student class
        /// </summary>
        /// <param name="studentId">Student Id number (6 digits)</param>
        /// <param name="age">Students Age</param>
        /// <param name="numCreditHours">How many credit hours the student has</param>
        /// <param name="dateOfBirth">Students DOB</param>
        /// <param name="name">The studnets name</param>
        /// <param name="gpa">The students GPA</param>
        /// <param name="energy">The students energy level</param>
        /// <param name="satiation">The students satiation level</param>
        /// <param name="health"></param>
        /// <param name="happiness"></param>
        /// <param name="money"></param>
        /// 
        public Student(string studentId, uint age, uint numCreditHours, DateTime dateOfBirth, string name, float gpa, double energy, double satiation, double health, double happiness, double money){
            this.studentId = studentId;
            this.age = age;
            this.numCreditHours = numCreditHours;
            this.dateOfBirth = dateOfBirth;
            this.name = name;
            this.gpa = gpa;
            this.energy = energy;
            this.satiation = satiation;
            this.health = health;
            this.happiness = happiness;
            this.money = money;
        }
        
        #endregion

        #region Properties
        public string StudentId { get => studentId; set => studentId = value; }
        public uint Age { get => age; set => age = value; }
        public uint NumCreditHours { get => numCreditHours; set => numCreditHours = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Name { get => name; set => name = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        public double Energy { get => energy; set => energy = value; }
        public double Satiation { get => satiation; set => satiation = value; }
        public double Health { get => health; set => health = value; }
        public double Happiness { get => happiness; set => happiness = value; }
        public double Money { get => money; set => money = value; }
        #endregion

        #region behaviors
        /// <summary>
        /// The Student studies for a given number of hours
        /// </summary>
        /// <param name="hours">How long the student studies for</param>
        public void study(int hours){
            if(hours > 0)
            {
                if (hours > 1)
                {
                    Console.WriteLine($"{name} studies for {hours} hours.");
                }
                else if (hours == 1)
                {
                    Console.WriteLine($"{name} studies for an hour.");
                }
                for (int elaspsedTime = 0; elaspsedTime < hours; elaspsedTime++)
                {
                    Gpa += 0.05f;
                    Energy -= 5;
                    Happiness -= 5;
                    Satiation -= 5;
                }
            }
            
        }
        
        /// <summary>
        /// The Student sleeps for a given number of hours
        /// </summary>
        /// <param name="hours">How long the student sleeps for</param>
        public void sleep(int hours){
            if (hours > 0)
            {
                if (hours > 1)
                {
                    Console.WriteLine($"{name} sleeps for {hours} hours.");
                }
                else if (hours == 1)
                {
                    Console.WriteLine($"{name} sleeps for an hour.");
                }
                for (int elaspsedTime = 0; elaspsedTime < hours; elaspsedTime++)
                {
                    Energy += 10;
                    Happiness += 5;
                    Satiation -= 5;
                }
            }
        }

        /// <summary>
        /// The Student eats for a given number of hours
        /// </summary>
        /// <param name="hours">How long the student eats for</param>
        public void eat(int hours)
        {
            if (hours > 0)
            {
                if (hours > 1)
                {
                    Console.WriteLine($"{name} ate for {hours} hours.");
                }
                else if (hours == 1)
                {
                    Console.WriteLine($"{name} ate for an hour.");
                }
                for (int elaspsedTime = 0; elaspsedTime < hours; elaspsedTime++)
                {
                    Energy += 10;
                    Happiness += 5;
                    Satiation += 5;
                }
            }
        }

        /// <summary>
        /// The Student went shopping for a given number of hours
        /// </summary>
        /// <param name="hours">How long the student shopped for</param>
        public void shopping(int hours)
        {
            if (hours > 0)
            {
                if (hours > 1)
                {
                    Console.WriteLine($"{name} was shopping for {hours} hours.");
                }
                else if (hours == 1)
                {
                    Console.WriteLine($"{name} shopped for an hour.");
                }
                for (int elaspsedTime = 0; elaspsedTime < hours; elaspsedTime++)
                {
                    Energy -= 10;
                    Happiness += 5;
                    Money -= 10;
                }
            }
        }

        /// <summary>
        /// The Student played video games for a given number of hours
        /// </summary>
        /// <param name="hours">How long the student gammed for</param>
        public void playedVideoGames(int hours)
        {
            if (hours > 0)
            {
                if (hours > 1)
                {
                    Console.WriteLine($"{name} was gamming for {hours} hours.");
                }
                else if (hours == 1)
                {
                    Console.WriteLine($"{name} gammed for an hour.");
                }
                for (int elaspsedTime = 0; elaspsedTime < hours; elaspsedTime++)
                {
                    Energy -= 5;
                    Happiness += 10;
                    Gpa -= 0.05f;
                    Health -= 5;
                }
            }
        }

        /// <summary>
        /// The Student worked out for a given number of hours
        /// </summary>
        /// <param name="hours">How long the student worked out for</param>
        public void workout(int hours)
        {
            if (hours > 0)
            {
                if (hours > 1)
                {
                    Console.WriteLine($"{name} was gamming for {hours} hours.");
                }
                else if (hours == 1)
                {
                    Console.WriteLine($"{name} gammed for an hour.");
                }
                for (int elaspsedTime = 0; elaspsedTime < hours; elaspsedTime++)
                {
                    Energy -= 10;
                    Happiness += 5;
                    Health += 5;
                    Gpa -= 0.05f;
                }
            }
        }






        #endregion

        #region utilites 
        public override string ToString(){
            return $"SID: {studentId} Name:{Name} DOB: {DateOfBirth.ToShortDateString()} GPA: {Gpa} Energy: {Energy} satiation: {Satiation} Happiness: {Happiness} Health: {Health} Money: {Money}";
        }

        public Boolean checkIfDead()
        {
            if(Gpa <= 0)
            {
                Console.WriteLine("You dropped out and died");
                return true;
            }
            else if(Energy <= 0)
            {
                Console.WriteLine("You are antimatter and are dead");
                return true;
            }
            else if(Satiation <= 0)
            {
                Console.WriteLine("You died of hunger");
                return true;
            }
            else if(Happiness <= 0)
            {
                Console.WriteLine("You died of saddness");
                return true;
            }
            else if(Health <= 0)
            {
                Console.WriteLine("Your health was too low and died");
                return true;
            }
            else if(Money <= 0)
            {
                Console.WriteLine("You have no money and died");
                return true;
            }
            return false;
        }

        #endregion
    }
}
