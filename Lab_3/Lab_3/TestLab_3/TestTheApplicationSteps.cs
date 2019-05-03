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
using TechTalk.SpecFlow;

namespace TestLab_3
{
    [Binding]
    public class TestTheApplicationSteps
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
        private string _path;

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
        }

        [Given(@"I have valid path D:\\Coursework\\app")]
        public void GivenIHaveValidPathDCourseworkApp()
        {
            Init();
            _path = "D:\\Coursework\\app";
        }

        [Given(@"I have invalid path D\\Coursework\\app")]
        public void GivenIHaveInvalidPathDCourseworkApp()
        {
            Init();
            _path = "D\\Coursework\\app";
        }

        [Given(@"I have empty path")]
        public void GivenIHaveEmptyPath()
        {
            Init();
            _path = "D\\Coursework\\app";
        }

        [Given(@"I have valid path D:\\Open Server (.*)\.(.*)\\OSPanel\\domains")]
        public void GivenIHaveValidPathDOpenServer_OSPanelDomains(Decimal p0, int p1)
        {
            Init();
            _path = @"D:\Open Server 5.2.9\OSPanel\domains";
        }

        [Given(@"I have invalid path D\\Open Server (.*)\.(.*)\\OSPanel\\domains")]
        public void GivenIHaveInvalidPathDOpenServer_OSPanelDomains(Decimal p0, int p1)
        {
            Init();
            _path = @"D\Open Server 5.2.9\OSPanel\domains";
        }

        [Given(@"I have empty right list")]
        public void GivenIHaveEmptyRightList()
        {
            Init();
            _path = "";
        }

        [When(@"I add a valid path to a text field")]
        public void WhenIAddAValidPathToATextField()
        {
            _editPath.BulkText = _path;
        }

        [When(@"I click on the add button to add the entry to the left list")]
        public void WhenIClickOnTheAddButtonToAddTheEntryToTheLeftList()
        {
            _addButton.Click();
        }

        [When(@"I add a invalid path to a text field")]
        public void WhenIAddAInvalidPathToATextField()
        {
            _editPath.BulkText = _path;
        }

        [When(@"I click on the add button to add the entry to the right list")]
        public void WhenIClickOnTheAddButtonToAddTheEntryToTheRightList()
        {
            _addButton.Click();
        }

        [When(@"I click on the add button to get a warning")]
        public void WhenIClickOnTheAddButtonToGetAWarning()
        {
            _addButton.Click();
        }

        [When(@"I select the desired entry in the left list")]
        public void WhenISelectTheDesiredEntryInTheLeftList()
        {
            _leftListBox.Items.Select(0);
        }
        
        [When(@"I click on the delete button to remove entries from the left list")]
        public void WhenIClickOnTheDeleteButtonToRemoveEntriesFromTheLeftList()
        {
            _leftDeleteButton.Click();
        }
        
        [When(@"I select the desired entry in the right list")]
        public void WhenISelectTheDesiredEntryInTheRightList()
        {
            _rightListBox.Items.Select(0);
        }
        
        [When(@"I click on the delete button to remove entries from the right list")]
        public void WhenIClickOnTheDeleteButtonToRemoveEntriesFromTheRightList()
        {
            _rightDeleteButton.Click();
        }
        
        [When(@"I click on the remove button to moving an entry from the left list to the right")]
        public void WhenIClickOnTheRemoveButtonToMovingAnEntryFromTheLeftListToTheRight()
        {
            _repositionButton.Click();
        }
        
        [When(@"I click on the move button to moving an entry from the left list to the text field")]
        public void WhenIClickOnTheMoveButtonToMovingAnEntryFromTheLeftListToTheTextField()
        {
            _returnButton.Click();
        }
        
        [Then(@"A new entry appears in the left list")]
        public void ThenANewEntryAppearsInTheLeftList()
        {
            Assert.AreEqual(1, _leftListBox.Items.Count);
            _window.Close();
        }
        
        [Then(@"A new entry appears in the right list")]
        public void ThenANewEntryAppearsInTheRightList()
        {
            Assert.AreEqual(1, _rightListBox.Items.Count);
            _window.Close();
        }
        
        [Then(@"There was a warning about an empty path")]
        public void ThenThereWasAWarningAboutAnEmptyPath()
        {
            var messageBox = _window.MessageBox("Что-то пошло не так!");
            Assert.AreEqual("Пустая строка!", messageBox.Get<Label>(
                SearchCriteria.ByText("Пустая строка!")).Text);
            messageBox.Close();
            _window.Close();
        }
        
        [Then(@"The entries is removed from the left list")]
        public void ThenTheEntriesIsRemovedFromTheLeftList()
        {
            Assert.AreEqual(0, _leftListBox.Items.Count);
            _window.Close();
        }
        
        [Then(@"The entries is removed from the right list")]
        public void ThenTheEntriesIsRemovedFromTheRightList()
        {
            Assert.AreEqual(0, _rightListBox.Items.Count);
            _window.Close();
        }
        
        [Then(@"The entries is moving from the left list to the right")]
        public void ThenTheEntriesIsMovingFromTheLeftListToTheRight()
        {
            Assert.AreEqual(1, _rightListBox.Items.Count);
            _window.Close();
        }
        
        [Then(@"The entries is moving from the right list to the text field")]
        public void ThenTheEntriesIsMovingFromTheRightListToTheTextField()
        {
            Assert.AreEqual(@"D\Open Server 5.2.9\OSPanel\domains", _editPath.BulkText);
            _window.Close();
        }
        
        [Then(@"There was a warning about an empty entry")]
        public void ThenThereWasAWarningAboutAnEmptyEntry()
        {
            var messageBox = _window.MessageBox("Что-то пошло не так!");
            Assert.AreEqual("Вы не выбрали строку для повторной проверки!", messageBox.Get<Label>(
                SearchCriteria.ByText("Вы не выбрали строку для повторной проверки!")).Text);
            messageBox.Close();
            _window.Close();
        }
    }
}
