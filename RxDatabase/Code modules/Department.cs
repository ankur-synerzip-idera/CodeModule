/*
 * Created by Ranorex
 * User: smitar
 * Date: 18-06-2019
 * Time: 04:59 PM
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
    /// Description of Department.
    /// </summary>
    [TestModule("FD7780D9-44AB-4FDA-82D2-4001FB88BDA2", ModuleType.UserCode, 1)]
    public class Department : ITestModule
    {
    	public static RxDatabaseRepository repo;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Department()
        {
            // Do not delete - a parameterless constructor is required!
            repo=new RxDatabaseRepository();
        }

[TestVariable("6c30508a-73d1-4432-9ab4-cb500ebb5295")]
public string VarDepartment
{
	get { return repo.lstDepartment; }
	set {
		repo.lstDepartment= value;
		repo.RxMainFrame.RxTabStandard.Open.Click();
		repo.List1000.selDepartment.Click();
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
