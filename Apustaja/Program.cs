using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apustaja
{
    class Program
    {
        private String[] commandList = { "Help", "Give date", "Give time", "Stop"};//"Edit shoppinglist", "Instructions" };
        private bool status = false;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


        /// <summary>
        /// Prints out introduction stuff
        /// </summary>
        public static void Start()
        {
            Console.WriteLine("Hello, I am Apustaja.");
            Console.WriteLine("If you need help, type Help as a command");
        }


        /// <summary>
        /// Ran after everytime a command is performed to ask a new command
        /// </summary>
        public void AfterCommand()
        {
            
            String command = Console.ReadLine();
            WhatCommand(command);
        }


        /// <summary>
        /// Searches for the given command, TODO: toimimaan commandListillä
        /// </summary>
        /// <param name="input"></param>
        public void WhatCommand(String input)
        {
            StringBuilder commands = new StringBuilder();
            StreamReader sr = new StreamReader("C:\\Ohjelmointijuttui\\Apustaja\\commands.txt");

            try
            {
                
            }catch
            {

            }

            switch(input)
            {
                case "Help":
                    Help();
                    break;

                case "Give date":
                    GiveDate("Date");
                    break;

                case "Give time":
                    GiveDate("Time");
                    break;

                //not working
                //case "Edit shoppinglist":
                //    EditShoppinglist();
                //    break;

                case "Stop":
                    Status=false;
                    break;

                default:
                    Console.WriteLine("That command is not recognized, write \"Help" + "for a list of commands");
                    AfterCommand();
                    break;
            }
        }
        /// <summary>
        /// Maini jutttui bro
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.status = true;
            Start();
            String command;

            while (prog.Status != false)
            {
                Console.WriteLine("Waiting for command");
                command = Console.ReadLine();
                prog.WhatCommand(command);
            }
        }

        /// <summary>
        /// Prints out a list of usable commands
        /// </summary>
        public void Help()
        {
            Console.WriteLine("Existing commands are: ");
            for (int i= 0; i<commandList.Length; i++)
            {
                Console.Write(commandList[i] + ", ");
            }
            Console.Write("\n");
            AfterCommand();
        }


        /// <summary>
        /// Prints out the time or the date of today depending on the parameter format
        /// </summary>
        /// <param name="format"> If user wants to know time or date</param>
        public void GiveDate(String format)
        {
            DateTime date = DateTime.Now;
            if (format == "Date")
            {
                Console.WriteLine("Today is: " + date.Day + "." + date.Month + "." + date.Year);
            }
            if (format == "Time")
            {
                Console.WriteLine("The clock is: " + date.TimeOfDay);
            }
            AfterCommand();
        }

        public void EditShoppinglist()
        {

        }
    }
}
