using System;
using System.Collections.Generic;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Cafe_Tests
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void AddMenuItemToTheDirectory_ShouldGetCorrectBoolean()
        {
            // Arrange
            MenuItem menuItem = new MenuItem();
            MenuRepository repository = new MenuRepository();
            // Act
            bool addMenuItem = repository.AddMenuItemToDirectory(menuItem);
            // Assert
            Assert.IsTrue(addMenuItem)
        }
        [TestMethod]
        public void GetMenuDirectory_ShouldReturnMenuDirectory()
        {
            // Arrange
            MenuItem menuItem = new MenuItem
            MenuRepository repository = newMenuRepository();
            repository.AddMenuItemToDirectory(menuItem);
            // Act
            List<MenuItem> listOfContents();
            // Assert
            bool directoryHasContent = directoryHasContent.Contains(menuItem);
            Assert.IsTrue(directoryHascontent);
        }
        private menuRepository _repo;
        private menuItem _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new menuRepository();
            _content = new MenuItem(5, "ham sandwich", "ham on bread", new List<string>(),{ "bread", "lettuce", "mayo", "pickle" }, 6.00m;
            _repo.AddMenuItemToDirectory(_content);
        }
        [TestMethod]
        public void GetMenuItemByName_ShouldReturnCorrectMenuItem()
        {
            //Arrange 
            //ACT
            MenuItem searchResult = _repo.GetMenuItemsByName("ham sandwich");
            //ASSERT 
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        [TestMethod]
        public void UpdateExistingMenu_ShouldReturnTrue()
        {
            //arrange 
            //ACT 
            MenuItem newMenuItem = new MenuItem(5, "ham sandwich", "ham on bread", new List<string>(),{ "bread", "lettuce", "mayo", "pickle" }, 6.00m;
            MenuItem searchResult = _repo.GetMenuItemsByName("ham sandwich");
            bool updateResult = _repo.UpdateMenuItem("hamburger", newMenuItem);
            Assert.IsTrue(updateResult);
        }
    }
}

