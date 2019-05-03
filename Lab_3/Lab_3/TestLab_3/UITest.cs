using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using System.IO;
using System.Collections.Generic;

namespace TestLab_3
{
    [TestClass]
    public class UITest
    {
        private Application _application;
        private Window _window;
        private TextBox _editPath;
        private ListBox _leftListBox;
        private ListBox _rightListBox;
        private Button _addButton;
        private Button _leftDeleteButton;
        private Button _rightDeleteButton;
        private Button _repositionButton;
        private Button _returnButton;
        private List<string> _correctPath;
        private List<string> _invalidPath;


        public void Init()
        {
            _application = Application.Launch(@"C:\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug\Lab_3.exe");
            _window = _application.GetWindow("Lab_3");
            _editPath = _window.Get<TextBox>(SearchCriteria.ByAutomationId("textBoxPath"));
            _leftListBox = _window.Get<ListBox>("listBoxLeft");
            _rightListBox = _window.Get<ListBox>("listBoxRight");
            _addButton = _window.Get<Button>(SearchCriteria.ByAutomationId("buttonAdd"));
            _leftDeleteButton = _window.Get<Button>(SearchCriteria.ByAutomationId("buttonLeftDelete"));
            _rightDeleteButton = _window.Get<Button>(SearchCriteria.ByAutomationId("buttonRightDelete"));
            _repositionButton = _window.Get<Button>(SearchCriteria.ByAutomationId("buttonLeftRemove"));
            _returnButton = _window.Get<Button>(SearchCriteria.ByAutomationId("buttonRightComeBack"));

            _correctPath = new List<string>();
            _correctPath.Add(@"C:\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug");
            _correctPath.Add(@"C:\Users\Дмитрий\Documents");
            _correctPath.Add(@"D:\Games\Steam");
            _correctPath.Add(@"G:\");
            _correctPath.Add(@"G:\Учеба\TCPP");
            _correctPath.Add(@"D:\Open Server 5.2.9\OSPanel\domains\Coursework");
            _correctPath.Add(@"F:\Cisco Packet Tracer 7.2.1");
            _correctPath.Add(@"C:\Users\Дмитрий\Google Диск");
            _correctPath.Add(@"D:\Program Files (x86)");
            _correctPath.Add(@"C:\Users\Public");

            _invalidPath = new List<string>();
            _invalidPath.Add(@"G\");
            _invalidPath.Add(@"C\Users//\/\/\Public");
            _invalidPath.Add(@"123523534");
            _invalidPath.Add(@"asfdsfdgfgfh");
            _invalidPath.Add(@"asdasd123123");
        }

        [TestMethod]
        public void AddCorrectPathTest()
        {
            Init();
            for (int i = 0; i < _correctPath.Count; i++)
            {
                _editPath.BulkText = _correctPath[i];
                _addButton.Click();
            }
            Assert.AreEqual(_correctPath.Count, _leftListBox.Items.Count);
            _window.Close();
        }

        [TestMethod]
        public void AddInvalidPathTest()
        {
            Init();
            for (int i = 0; i < _invalidPath.Count; i++)
            {
                _editPath.BulkText = _invalidPath[i];
                _addButton.Click();
            }
            Assert.AreEqual(_invalidPath.Count, _rightListBox.Items.Count);
            _window.Close();
        }

        [TestMethod]
        public void AddEmptyPathTest()
        {
            Init();
            _addButton.Click();
            var messageBox = _window.MessageBox("Что-то пошло не так!");
            Assert.AreEqual("Пустая строка!", messageBox.Get<Label>(
                SearchCriteria.ByText("Пустая строка!")).Text);
            messageBox.Close();
            _window.Close();
        }

        [TestMethod]
        public void DeleteLeftListBoxTest()
        {
            Init();
            _editPath.BulkText = @"C:\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug";
            _addButton.Click();
            _leftListBox.Items.Select(0);
            _leftDeleteButton.Click();
            Assert.AreEqual(0, _leftListBox.Items.Count);
            _window.Close();
        }

        [TestMethod]
        public void DeleteRightListBoxTest()
        {
            Init();
            _editPath.BulkText = @"C\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug";
            _addButton.Click();
            _rightListBox.Items.Select(0);
            _rightDeleteButton.Click();
            Assert.AreEqual(0, _rightListBox.Items.Count);
            _window.Close();
        }

        [TestMethod]
        public void RepositionListBoxTest()
        {
            Init();
            _editPath.BulkText = @"C:\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug";
            _addButton.Click();
            _leftListBox.Items.Select(0);
            _repositionButton.Click();
            Assert.AreEqual(1, _rightListBox.Items.Count);
            _window.Close();
        }

        [TestMethod]
        public void ReturnTextBoxTest()
        {
            Init();
            _editPath.BulkText = @"C\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug";
            _addButton.Click();
            _rightListBox.Items.Select(0);
            _returnButton.Click();
            Assert.AreEqual(@"C\Study\Тестирование ПО\Lab_3\Lab_3\Lab_3\bin\Debug", _editPath.BulkText);
            _window.Close();
        }

        [TestMethod]
        public void NothingReturnTextBoxTest()
        {
            Init();
            _returnButton.Click();
            var messageBox = _window.MessageBox("Что-то пошло не так!");
            Assert.AreEqual("Вы не выбрали строку для повторной проверки!", messageBox.Get<Label>(
                SearchCriteria.ByText("Вы не выбрали строку для повторной проверки!")).Text);
            messageBox.Close();
            _window.Close();
        }
    }
}
