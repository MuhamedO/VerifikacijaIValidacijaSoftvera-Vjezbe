﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kupid;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace KupidTest
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Test()
        {
            Komunikator k = new Komunikator();
            int size = 10000;

            Assert.AreEqual(0, k.Korisnici.Count());

            for (int i = 0; i < size; i++)
            {
                Korisnik kk = new Korisnik("user" + i.ToString(), "pass*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false);
                k.RadSaKorisnikom(kk, 0);
                //Assert.ThrowsException<InvalidOperationException>(() => k.RadSaKorisnikom(kk, 0));
            }
            Assert.AreEqual(size, k.Korisnici.Count());

            for (int i = 0; i < size; i++)
            {
                Korisnik kk = k.Korisnici[0];
                k.RadSaKorisnikom(kk, 1);
                //Assert.ThrowsException<InvalidOperationException>(() => k.RadSaKorisnikom(kk, 1));
            }
            Assert.AreEqual(0, k.Korisnici.Count());
        }

    }
}