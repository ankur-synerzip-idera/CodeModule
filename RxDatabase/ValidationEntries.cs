/*
 * Created by Ranorex
 * User: smitar
 * Date: 18-06-2019
 * Time: 05:07 PM
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

namespace RxDatabase
{
    /// <summary>
    /// Description of ValidationEntries.
    /// </summary>
    [TestModule("6A34E098-B2F0-4B2D-A9E8-2B3AA8AF1E36", ModuleType.UserCode, 1)]
    public class ValidationEntries : ITestModule
    {
    	public static RxDatabaseRepository repo;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidationEntries()
        {
            // Do not delete - a parameterless constructor is required!
        }

		string _validateEntryNumber = "";
		[TestVariable("2f96d556-10a1-403c-8674-0d921769b562")]
		public string validateEntryNumber
		{
			get { return _validateEntryNumber; }
			set {
				
				_validateEntryNumber = value; }
				
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
            
            if(Validate.Equals(repo.RxMainFrame.PersonCount.TextValue,validateEntryNumber))
            {
            	Report.Success("Validation","Entry number correctly displayed!!!");
            	
            }
            else
            {
            	Report.Failure("Validation","Invalid number Entry!!!");
            }
        }
    }
}
