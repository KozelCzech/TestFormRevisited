
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.UIA2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Automation;

namespace TestFormRevisitedTests
{
    [TestClass]
    public class UITest
    {
        string _pictureFolderPath = @"C:\Users\kopacek\Desktop\testPhotos\";
        string _executablePath = @"C:\Users\kopacek\Desktop\Self-Study\TestFormRevisited\TestFormRevisited\bin\Debug\net7.0-windows\TestFormRevisited.exe";

        [TestMethod]
        public void AddDataToListAutomation()
        {
            var app = Application.Launch(_executablePath);
            

            try
            {
                using (var automation = new UIA2Automation())
                {
                    var mainWindow = app.GetMainWindow(automation);

                    if (mainWindow != null)
                    {
                        var addButton = mainWindow.FindFirstDescendant(b => b.ByAutomationId("addButton"));
                        var screenBeforeClick = mainWindow.Capture();

                        addButton.Click();

                        var screenAfterClick = mainWindow.Capture();

                        var textBox1 = mainWindow.FindFirstDescendant(b => b.ByAutomationId("textBox1"));
                        var textBox2 = mainWindow.FindFirstDescendant(b => b.ByAutomationId("textBox2"));
                        var textBox3 = mainWindow.FindFirstDescendant(b => b.ByAutomationId("textBox3"));

                        textBox1.Click();
                        Keyboard.Type("abc");

                        textBox2.Click();
                        Keyboard.Type("abc");

                        textBox3.Click();
                        Keyboard.Type("12f3a");

                        var screenAfterTextInput = mainWindow.Capture();

                        var saveButton = mainWindow.FindFirstDescendant(b => b.ByAutomationId("saveButton"));

                        saveButton.Click();

                        var screenAfterDataSaved = mainWindow.Capture();


                        screenBeforeClick.Save(Path.Combine(_pictureFolderPath, @"AddDataToList\1_before_click.png"));
                        screenAfterClick.Save(Path.Combine(_pictureFolderPath, @"AddDataToList\2_after_click.png"));
                        screenAfterTextInput.Save(Path.Combine(_pictureFolderPath, @"AddDataToList\3_after_text_input.png"));
                        screenAfterDataSaved.Save(Path.Combine(_pictureFolderPath, @"AddDataToList\4_after_data_saved.png"));
                    }
                }
            }
            finally
            {
                app.Close();
            }
        }


        [TestMethod]
        public void DeleteDataFromListAutomation()
        {
            var app = Application.Launch(_executablePath);
            try
            {
                using (var automation = new UIA2Automation())
                {
                    var mainWindow = app.GetMainWindow(automation);
                    var beforeSelect = mainWindow.Capture();

                    
                    var dataGridView = mainWindow.FindFirstDescendant(b => b.ByAutomationId("dataGridView1"));
                    var row = dataGridView.FindFirstDescendant(b => b.ByName("Row 0"));
                    
                    row.Click();
                    var afterRowClick = mainWindow.Capture();

                    var removeButton = mainWindow.FindFirstDescendant(b => b.ByAutomationId("removeButton"));
                    removeButton.Click();
                    var afterDeleteRow = mainWindow.Capture();


                    beforeSelect.Save(Path.Combine(_pictureFolderPath, @"DeleteDataFromList\1_before_select.png"));
                    afterRowClick.Save(Path.Combine(_pictureFolderPath, @"DeleteDataFromList\2_after_select.png"));
                    afterDeleteRow.Save(Path.Combine(_pictureFolderPath, @"DeleteDataFromList\3_after_delete.png"));
                }
            }
            finally
            {
                app.Close();
            }
        }
    }
}
