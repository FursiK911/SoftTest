﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1_Project;

namespace Lab_1_Test
{
    [TestClass]
    public class StringFormatterTest
    {
        [TestMethod]
        public void EmptyString()
        {
            StringFormatter stringFormatter = new StringFormatter();
            Assert.AreEqual("", stringFormatter.ShortFileString(""));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullString()
        {
            StringFormatter stringFormatter = new StringFormatter();
            stringFormatter.ShortFileString(null);
        }

        [TestMethod]
        public void StandartString()
        {
            StringFormatter stringFormatter = new StringFormatter();
            Assert.AreEqual(@"0_GOLEM_FALLING DOWN_000.TMP", stringFormatter.ShortFileString(@"D:\Учеба\Для игр\Sprite_Golems\Golem_1\PNG\PNG Sequences\Falling Down\0_Golem_Falling Down_000.png"));
        }
    }
}
