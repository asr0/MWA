using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;

namespace ModernWebStore.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Bolos");
            var product = new Product("Mouse","Mouse da xuxa",20,10,5);

            //Salvar Categoria
        }
    }
}
