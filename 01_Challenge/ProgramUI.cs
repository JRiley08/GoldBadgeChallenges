using System;
using System.Collections.Generic;

namespace _01_Challenge
{
    public class ProgramUI
    {
        MenuItems_Repository _menuRepo = new MenuItems_Repository();

        public void Run()
        {
            bool running = true;
            while (running)
            {

                Console.WriteLine("What option would you like to select?\n" +
                    "1.Add item to menu\n" +
                    "2.Display list\n" +
                    "3.Remove item\n" +
                    "4.Exit");

                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        AddMenuItem();
                        break;
                    case 2:
                        DisplayList();
                        break;
                    case 3:
                        RemoveItem();
                        break;
                    case 4:
                        running = false;
                        break;
                }

            }
        }




        public void AddMenuItem()
        {
            //MealNumber MealName Description ListOfIngredients Price
            MenuItems newMenu = new MenuItems();

            Console.WriteLine("Enter the meal number");
            string mealNumberAsString = Console.ReadLine();
            newMenu.MealNumber = int.Parse(mealNumberAsString);

            Console.WriteLine("Enter the meal name");
            newMenu.MealName = Console.ReadLine();

            Console.WriteLine("Enter the Description of the meal");
            newMenu.Description = Console.ReadLine();

            Console.WriteLine("Enter the list of ingredients for the selected meal");
            newMenu.ListOfIngredients = Console.ReadLine();

            Console.WriteLine("Enter the price of the selected meal");
            string priceAsString = Console.ReadLine();
            newMenu.Price = decimal.Parse(priceAsString);

            
            Console.Clear();

            _menuRepo.AddMenuItemList(newMenu);
        }

        private void DisplayList()
        {
            List<MenuItems> menulist = _menuRepo.GetMenuRepositoryList();

            foreach (MenuItems items in menulist)
            {
                Console.WriteLine($"#{items.MealNumber} {items.MealName} {items.Description} {items.ListOfIngredients} {items.Price}");
            }

            Console.ReadKey();
            Console.Clear();

        }

        private void RemoveItem()
        {
            Console.WriteLine("What is the item you would like to remove?");
            string mealName = Console.ReadLine();
            Console.WriteLine("Item Successfully removed");

            Console.ReadKey();
            Console.Clear();

            _menuRepo.RemoveOrderedItem(mealName);
        }

        

    }
}