using BakingApp.L0.AdataAccess.Domain;
using BakingApp.L0.AdataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void TestCreate()
        {
            // Arrange
            var nouveauCompte = new Compte { Numero = "C4000", Proprietaire = "Seifeddine", Solde = 4000M };
            var underTest = new ComptesRepositoryImpl_EF();
            // Act
            underTest.Create(nouveauCompte);
            // Assert
        }

        [TestMethod]
        public void TestFindById_Nominal()
        {
            // Arrange
            var numero = "C4000";
            var expected = new Compte { Numero = "C4000", Proprietaire = "Seifeddine", Solde = 4000M };
            var underTest = new ComptesRepositoryImpl_EF();
            // Act
            var actual = underTest.FindById(numero);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFindById_Degrade()
        {
            // Arrange
            var numero = "AAAA";var underTest = new ComptesRepositoryImpl_EF();
            // Act
            var actual = underTest.FindById(numero);
            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestFindAll()
        {
            // Arrange
            var underTest = new ComptesRepositoryImpl_EF();
            // Act
            var actual = (List<Compte>) underTest.FindAll();
            // Assert
            Assert.AreEqual(actual.Count, 4);
        }
    }
}
