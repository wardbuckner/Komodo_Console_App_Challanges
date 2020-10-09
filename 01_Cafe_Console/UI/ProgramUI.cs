using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe_Console.UI
    //Inspired by 08 streaming content console UI ProgramUI
{
    public class ProgramUI
    {
        private readonly MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            SeedContent();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Please select one of the following: \n" +
                    "1.  Show Cafe Menu Items\n" +
                    "2.  Create A New Menu Item\n" +
                    "3.  Make Changes To A Menu Item\n" +
                    "4.  Delete A Menu Item\n" +
                    "5.  Exit");

                // Console.Clear();
                string consoleInput = Console.ReadLine();

                switch (consoleInput)
                {
                    case "1":
                        ShowCafeMenuItems();
                        break;
                    case "2":
                        CreateANewMenuItem();
                        break;
                    case "3":
                        Make ChangesToAMenuItem();
                        break;
                    case "4":
                        DeleteAMenuItem();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void ShowCafeMenuItems()
        {
            Console.Clear();
            List<MenuItem> menuDirectory = _menuRepo.ShowCafeMenuItems();
            foreach (MenuItem item in menuDirectory)
            {
  
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        // Create A New Menu Item
        // Make Changes To A Menu Item
        // Delete A Menu Item
       