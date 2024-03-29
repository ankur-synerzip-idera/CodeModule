﻿/*
 * Created by Ranorex
 * User: smitar
 * Date: 18-06-2019
 * Time: 05:44 PM
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
    /// Description of StartAUTUserCode.
    /// </summary>
    [TestModule("74EA430E-AC58-4419-8AEF-9A2E8CB26C73", ModuleType.UserCode, 1)]
    public class StartAUTUserCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUTUserCode()
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
        }
    }
}
