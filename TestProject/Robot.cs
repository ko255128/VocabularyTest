using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace TestProject
{
    /// <summary>
    /// A class that finds the specific GUI control by using AccessibleName
    /// </summary>
    class Robot
    {
        #region Private Constants
        /// <summary>
        /// The exception message that is thrown when the specific control is not found
        /// </summary>
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";

        /// <summary>
        /// The name of Microsoft Active Accessibility technology
        /// </summary>
        private const string MSAA_TECHNOLOGY = "MSAA";
        #endregion

        #region Static Fields
        private static Dictionary<string, UITestControl> _cache;
        private static ApplicationUnderTest _aut;
        private static UITestControl _root;
        #endregion

        #region Static Properties
        /// <summary>
        /// Gets the main window to search child control
        /// </summary>
        public static UITestControl MainWindow
        {
            get { return _root; }
        }
        #endregion

        #region Preparation and Clean Methods
        /// <summary>
        /// Initializes the Finder
        /// </summary>
        /// <param name="title">The title of the main window</param>
        /// <returns>The found main window</returns>
        /// <exception cref="Exception">If the main window is not found</exception>
        public static UITestControl Initialize(string path, string title)
        {
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Playback.PlaybackSettings.ThinkTimeMultiplier = 0.0d;
            Playback.PlaybackSettings.SkipSetPropertyVerification = true;
            Playback.PlaybackSettings.ShouldSearchFailFast = true;
            _aut = ApplicationUnderTest.Launch(path);

            _cache = new Dictionary<string, UITestControl>();
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            CacheComponentFound(window, title);
            _root = window;
            return _root;
        }

        /// <summary>
        /// Clears all cached controls
        /// </summary>
        public static void CleanUp()
        {
            _cache.Clear();
            _root = null;
            _aut.Close();
        }
        #endregion

        #region Find Methods

        /// <summary>
        /// Finds the winControl and return the found control
        /// </summary>
        /// <param name="type">Control's type</param>
        /// <param name="name">The name for the  control</param>
        /// <param name="parent">This control belongs which parent control</param>
        /// <exception cref="Exception">If the control is not found</exception>
        private static WinControl FindWinControl(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                if (_cache[name].GetType() == type)
                    return (WinControl)_cache[name];
                else
                {
                    WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                    control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                    control.Find();
                    return control;
                }
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                CacheComponentFound(control, name);
                return control;
            }
        }

        /// <summary>
        /// Finds the specific control and caches the found control
        /// </summary>
        /// <param name="control">The specific control to find</param>
        /// <param name="name">The name for the specific control</param>
        /// <exception cref="Exception">If the control is not found</exception>
        private static void CacheComponentFound(UITestControl control, string name)
        {
            control.Find();
            if (!control.Exists)
            {
                throw new Exception(CONTROL_NOT_FOUND_EXCEPTION);
            }
            _cache.Add(name, control);
        }

        #endregion

        /// <summary>
        /// Click a list of menuItems
        /// </summary>
        /// <param name="path">The menuItems' path</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickMenuItem(string[] path)
        {
            foreach (string item in path)
            {
                Mouse.Click((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            }
        }

        public static void AssertMenuItemEnable(string item, bool assertValue)
        {
            WinMenuItem control = ((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            Assert.AreEqual(assertValue, control.Enabled);
        }

        public static void AssertMenuItemChecked(string name, bool assertValue)
        {
            WinMenuItem control = (WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), name, _root);
            Assert.AreEqual(assertValue, control);
        }

        /// <summary>
        /// Click the specific button
        /// </summary>
        /// <param name="name">The button's name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickButton(string name)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Mouse.Click(button);
        }

        /// <summary>
        /// Click the specific radioButton
        /// </summary>
        /// <param name="name">The radioButton's name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void ClickRadio(string name)
        {
            Mouse.Click((WinRadioButton)Robot.FindWinControl(typeof(WinRadioButton), name, _root));
        }

        /// <summary>
        /// Set the specific edit a key
        /// </summary>
        /// <param name="name">The edit's name</param>
        /// <param name="key">The value you want to set</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetEdit(string name, string keys)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            if (edit.Text != keys)
                edit.Text = keys;
        }

        /// <summary>
        /// Set a target to the specific comboBox
        /// </summary>
        /// <param name="name">The comboBox's name</param>
        /// <param name="targetName">The value you want to select</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetComboBox(string name, string targetName)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            if (comboBox.SelectedItem != targetName)
                comboBox.SelectedItem = targetName;
        }

        /// <summary>
        /// Set the specific checkBox isChecked
        /// </summary>
        /// <param name="name">The checkBox's name</param>
        /// <param name="isChecked">true if you checked</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void SetCheckBox(string name, bool isChecked)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            if (checkBox.Checked != isChecked)
                checkBox.Checked = isChecked;
        }

        public static void AssertCheckBox(string name, bool assertValue)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            Assert.AreEqual(assertValue, checkBox.Checked);
        }


        /// <summary>
        /// Assert the specific edit's text
        /// </summary>
        /// <param name="name">The edit's name</param>
        /// <param name="assertValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertEdit(string name, string assertValue)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(edit.Text, assertValue);
        }

        /// <summary>
        /// Assert the specific window is exist and close the window
        /// </summary>
        /// <param name="name">The window's title name</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertWindow(string name)
        {
            const string KEY_TEXT = "\n";
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), name, null);
            Keyboard.SendKeys(window, KEY_TEXT);
        }

        public static void ClickWindowButton(string windowName, string buttonName)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), windowName, null);
            Mouse.Click((WinButton)Robot.FindWinControl(typeof(WinButton), buttonName, window));
        }

        public static void ClickWindowHyperLink(string windowName, string hyperLinkName)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), windowName, null);
            Mouse.Click((WinHyperlink)Robot.FindWinControl(typeof(WinHyperlink), hyperLinkName, window));
        }

        /// <summary>
        /// Assert the specific text's displayText
        /// </summary>
        /// <param name="name">The text's name</param>
        /// <param name="assertValue">expected value you want to assert</param>
        /// <exception cref="Exception">If the control is not found</exception>
        public static void AssertText(string name, string assertValue)
        {
            WinText text = (WinText)Robot.FindWinControl(typeof(WinText), name, _root);
            Assert.AreEqual(text.DisplayText, assertValue);
        }

        public static void AssertWindowText(string windowName, string name, string assertValue)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), windowName, null);
            WinText text = (WinText)Robot.FindWinControl(typeof(WinText), name, window);
            Assert.AreEqual(text.DisplayText, assertValue);
        }
    }
}
