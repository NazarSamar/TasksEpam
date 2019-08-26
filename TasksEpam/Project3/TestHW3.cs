﻿// <auto-generated />
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TasksEpam.Project3
{

    [TestFixture]
    class TestHW3
    {
        [TestCase]
        public void TestGenerate_ExpectEqual()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < 20; ++i)
            {
                string str = Task3.Generate();
                Assert.AreEqual(4, str.Length);
                strings.Add(str);
            }
            Assert.AreEqual(20, strings.Count);
        }

        [TestCase]
        public void TestRemove_ExpectEqual()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < 100; ++i)
            {
                strings.Add(Task3.Generate());
            }
            Assert.AreEqual(100, strings.Count);
            Task3.Remove(ref strings);
            strings.RemoveAll(x => x[0] == 'Z');
            var to_check_list = strings.Distinct().ToList();
            Assert.AreEqual(to_check_list.Count, strings.Count);
        }

        [TestCase]
        public void TestDisplayPage_NotValidParams_EqualException()
        {
            Assert.Throws<Exception>(() => Task3.DisplayPage(-2));
        }

        [TestCase]
        public void TestSort_ExpectEqual()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < 20; ++i)
            {
                strings.Add(Task3.Generate());
            }

            var to_check_list = strings.OrderByDescending(x => x).ToList();
            Assert.AreEqual(to_check_list[0], strings[0]);
        }
    }
}
