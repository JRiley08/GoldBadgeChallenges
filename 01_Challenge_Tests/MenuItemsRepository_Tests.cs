using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuItemsRepository_Tests
    {
        [TestMethod]
        public void MenuItemsRepository_ShouldAddItemToList()
        {
            //Arrange
            MenuItems_Repository menuItems = new MenuItems_Repository();
            MenuItems cheeseburger = new MenuItems();
            MenuItems item = new MenuItems();
            MenuItems coocoocacho = new MenuItems();
            menuItems.AddMenuItemList(item);
            menuItems.AddMenuItemList(cheeseburger);
            menuItems.AddMenuItemList(coocoocacho);


            //Act
            int actual = menuItems.GetMenuRepositoryList().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuItemsRepository_RemoveMenuItem_ShouldTakeAwayItem()
        {
            //Arrange
            MenuItems_Repository menuItems = new MenuItems_Repository();

            MenuItems cheeseburger = new MenuItems();
            MenuItems item = new MenuItems();
            MenuItems coocoocacho = new MenuItems();
            menuItems.AddMenuItemList(cheeseburger);
            menuItems.AddMenuItemList(item);
            menuItems.AddMenuItemList(coocoocacho);

            menuItems.RemoveMenuItems(item);
            


            //Act
            int actual = menuItems.GetMenuRepositoryList().Count;
            int expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MenuItemsRepository_FindItemsByName_ShouldFunctionCorrectly()
        {
            //Arrange
            MenuItems_Repository menuItems = new MenuItems_Repository();

            MenuItems cheeseburger = new MenuItems();
            MenuItems item = new MenuItems();
            MenuItems coocoocacho = new MenuItems();
            menuItems.AddMenuItemList(cheeseburger);
            menuItems.AddMenuItemList(item);
            menuItems.AddMenuItemList(coocoocacho);

            
            menuItems.FindItemsByName(cheeseburger.MealName);

            //Act
            MenuItems actual = menuItems.FindItemsByName(cheeseburger.MealName);
            MenuItems expected = cheeseburger;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuItemsRepository_RemovedOrderedItem_ShouldRemoveItem()
        {
            //Arrange
            MenuItems_Repository menuItems = new MenuItems_Repository();

            MenuItems cheeseburger = new MenuItems();
            menuItems.AddMenuItemList(cheeseburger);

            menuItems.RemoveOrderedItem(cheeseburger.MealName);

            //Act
            int actual = menuItems.GetMenuRepositoryList().Count;
            int expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
