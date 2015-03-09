using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentorStore.BL;
using MentorStore.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.BL
{
    [TestClass()]
    public class MainLogicTests
    {
        private readonly  MainLogic<Category> _categoryMainLogic = new MainLogic<Category>();

        [TestMethod()]
        public void AddEntityTest()
        {
            Category cat = new Category();
            cat.CategoryName = "UnitTest";
            int before = _categoryMainLogic.GetAll().Count();
            _categoryMainLogic.AddEntity(cat);
            int after = _categoryMainLogic.GetAll().Count();

            Assert.IsTrue(after > before);
        }
        
        [TestMethod()]
        public void GetAll()
        {
            Category cat1 = new Category();
            Category cat2 = new Category();

            cat1.CategoryName = "UnitTest1";
            cat2.CategoryName = "UnitTest2";
            _categoryMainLogic.AddEntity(cat1);
            _categoryMainLogic.AddEntity(cat2);

            int quantity = _categoryMainLogic.GetAll().Count();

            Assert.AreEqual(2, quantity);
        }
    }
}
