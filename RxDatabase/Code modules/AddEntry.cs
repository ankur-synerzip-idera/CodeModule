/*
 * Created by Ranorex
 * User: smitar
 * Date: 18-06-2019
 * Time: 05:04 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace RxDatabase.Code_modules
{
    /// <summary>
    /// Description of AddEntry.
    /// </summary>
    [TestModule("7752D446-D7B5-4EC1-B308-8761314AD7DD", ModuleType.UserCode, 1)]
    public class AddEntry : ITestModule
    {
        public static RxDatabaseRepository repo;
    	/// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEntry()
        {
            // Do not delete - a parameterless constructor is required!
        }

        
        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            repo=new RxDatabaseRepository();
            var btn=repo.RxMainFrame.BtnAddPerson;
            btn.Click();
        }
    }
}
