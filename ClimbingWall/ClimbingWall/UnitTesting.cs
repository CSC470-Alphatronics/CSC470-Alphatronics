using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liphsoft.Crypto.Argon2;

namespace ClimbingWall
{
    [TestClass()]
    public class UnitTesting
    {
        [TestMethod()]
        public void PositiveIntInputValidation1()
        {
            Assert.IsTrue(DatabaseInputValidation.uintIsValid("42"));
        }
        [TestMethod()]
        public void PositiveIntInputValidation2()
        {
            Assert.IsTrue(DatabaseInputValidation.uintIsValid("0"));
        }
        [TestMethod()]
        public void PositiveIntInputValidation3()
        {
            Assert.IsFalse(DatabaseInputValidation.uintIsValid("-42"));
        }
        [TestMethod()]
        public void PositiveIntInputValidation4()
        {
            Assert.IsFalse(DatabaseInputValidation.uintIsValid("42.0"));
        }
        [TestMethod()]
        public void PositiveIntInputValidation5()
        {
            Assert.IsFalse(DatabaseInputValidation.uintIsValid("sad"));
        }
        [TestMethod()]
        public void PositiveIntInputValidation6()
        {
            Assert.IsTrue(DatabaseInputValidation.uintIsValid(""));
        }
        [TestMethod()]
        public void NameInputValidation1()
        {
            Assert.IsTrue(DatabaseInputValidation.nameIsValid("John Dickenson"));
        }
        [TestMethod()]
        public void NameInputValidation2()
        {
            Assert.IsTrue(DatabaseInputValidation.nameIsValid(""));
        }
        [TestMethod()]
        public void NameInputValidation3()
        {
            Assert.IsFalse(DatabaseInputValidation.nameIsValid("a32d"));
        }
        [TestMethod()]
        public void NameInputValidation4()
        {
            Assert.IsFalse(DatabaseInputValidation.nameIsValid("#######"));
        }
        [TestMethod()]
        public void StringInputValidation1()
        {
            Assert.IsFalse(DatabaseInputValidation.stringIsValid("sagd325g##@@!ADSF2357hsdakf2!@^$#&$!!$#"));
        }
        [TestMethod()]
        public void StringInputValidation2()
        {
            Assert.IsTrue(DatabaseInputValidation.stringIsValid(""));
        }
        [TestMethod()]
        public void StringInputValidation3()
        {
            Assert.IsFalse(DatabaseInputValidation.mandatoryStringIsValid("", 1));
        }
        [TestMethod()]
        public void HashingAlgorithm1()
        {
           // first value is encrypted password GLaDOS
            var hasher = new PasswordHasher();
            Assert.IsTrue(hasher.Verify("$argon2i$v=19$m=8192,t=3,p=1$E9cHwbyrc1K/UaOQiPSzhQ$yMscuizZaVMp71eoK2Hv1ZjeF4Xbd0zKT6A3pphsvYo", "GLaDOS"));
        }
        [TestMethod()]
        public void HashingAlgorithm2()
        {
            // first value is encrypted password GLaDOS
            var hasher = new PasswordHasher();
            Assert.IsFalse(hasher.Verify("$argon2i$v=19$m=8192,t=3,p=1$E9cHwbyrc1K/UaOQiPSzhQ$yMscuizZaVMp71eoK2Hv1ZjeF4Xbd0zKT6A3pphsvYo", "GLADOS"));
        }
        [TestMethod()]
        public void HashingAlgorithm3()
        {
            // first value is encrypted password GLaDOS
            var hasher = new PasswordHasher();
            Assert.IsFalse(hasher.Verify("$argon2i$v=19$m=8192,t=3,p=1$E9cHwbyrc1K/UaOQiPSzhQ$yMscuizZaVMp71eoK2Hv1ZjeF4Xbd0zKT6A3pphsvYo", "46hsjdgnj"));
        }
        [TestMethod()]
        public void HashingAlgorithm4()
        {
            // first value is encrypted password GLaDOS
            var hasher = new PasswordHasher();
            Assert.IsFalse(hasher.Verify("$argon2i$v=19$m=8192,t=3,p=1$E9cHwbyrc1K/UaOQiPSzhQ$yMscuizZaVMp71eoK2Hv1ZjeF4Xbd0zKT6A3pphsvYo", "#()$*jslgnodfsiSDF"));
        }/*
        [TestMethod()]
        public void DatabaseConnection()
        {
            try
            {
                Database.Instance.connect();
            }
            catch
            {
                Assert.Fail();
            }
            Assert.IsTrue(true);
        }*/
    }
}
