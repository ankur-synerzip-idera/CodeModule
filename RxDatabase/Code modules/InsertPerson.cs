/*
 * Created by Ranorex
 * User: smitar
 * Date: 18-06-2019
 * Time: 04:37 PM
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
    /// Description of InsertPerson.
    /// </summary>
    [TestModule("5A4D2481-167F-4A0C-A439-E8CB3CBCB43C", ModuleType.UserCode, 1)]
    public class InsertPerson : ITestModule
    {
    	private static RxDatabaseRepository myRepo;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertPerson()
        {
            // Do not delete - a parameterless constructor is required!
             myRepo = new RxDatabaseRepository();
        }
        string _FirstName = "testJohn";
        [TestVariable("b9bfc82d-4df2-4505-abe3-8a82487939d4")]
        public string FirstName
        {
        	get { return _FirstName; }
        	set { 
        		
        		_FirstName = value;        		
        		myRepo.RxMainFrame.RxTabStandard.FirstName.TextValue = value;
        	}
        }
        string _varLastName = "DB";
        [TestVariable("89c92d6b-33f4-4439-881d-04ae740ac16f")]
        public string varLastName
        {
        	get { return _varLastName; }
        	set {
        		_varLastName = value;
        		myRepo.RxMainFrame.RxTabStandard.LastName.TextValue = value;
        	}
        }
        string _Age = "45";
        [TestVariable("3f7ad6a1-0ef5-4500-a43b-2af95a54a978")]
        public string Age
        {
        	get { return _Age; }
        	set {
        		_Age = value; 
        		myRepo.RxMainFrame.RxTabStandard.AgeValue.TextValue = value;
        	
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
