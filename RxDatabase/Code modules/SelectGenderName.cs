/*
 * Created by Ranorex
 * User: smitar
 * Date: 18-06-2019
 * Time: 04:53 PM
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
    /// Description of SelectGenderName.
    /// </summary>
    [TestModule("110C7E29-9014-45D3-B843-9D656D59FF67", ModuleType.UserCode, 1)]
    public class SelectGenderName : ITestModule
    {
    	
    		private static RxDatabaseRepository myRepo;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectGenderName()
        {
            // Do not delete - a parameterless constructor is required!
             myRepo = new RxDatabaseRepository();
        }
       
        [TestVariable("f5507f73-7b75-4870-9070-e4cc6a10949b")]
        public string varSelectGender
        {
        	get { return myRepo.selGender; }
        	set { 
        		myRepo.selGender = value; 
        	myRepo.RxMainFrame.RxTabStandard.Gender.Select();
        	
        	}
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
