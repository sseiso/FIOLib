﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCheckLibrary;

namespace StringCheckLibraryTests
{
    [TestClass]
    public class StringCheckTests
    {
        [TestMethod]
        ///<summary>
        ///Поле ввода данных ФИО пустое
        ///</summary>
        public void CheckName_isEmpty_falseReturned()
        {
            //Arrange
            string stringName = "";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Assert
            Assert.AreEqual(false,result);
        }
    }
}
