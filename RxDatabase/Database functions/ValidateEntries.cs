﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace RxDatabase.Database_functions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateEntries recording.
    /// </summary>
    [TestModule("3403f9fd-88eb-4d86-8637-223b8e6aae26", ModuleType.Recording, 1)]
    public partial class ValidateEntries : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RxDatabase.RxDatabaseRepository repository.
        /// </summary>
        public static global::RxDatabase.RxDatabaseRepository repo = global::RxDatabase.RxDatabaseRepository.Instance;

        static ValidateEntries instance = new ValidateEntries();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateEntries()
        {
            intDBEntries = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateEntries Instance
        {
            get { return instance; }
        }

#region Variables

        string _intDBEntries;

        /// <summary>
        /// Gets or sets the value of variable intDBEntries.
        /// </summary>
        [TestVariable("4fbace8e-4e7c-46dc-806e-294b60737dcc")]
        public string intDBEntries
        {
            get { return _intDBEntries; }
            set { _intDBEntries = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$intDBEntries) on item 'RxMainFrame.PersonCount'.", repo.RxMainFrame.PersonCountInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.RxMainFrame.PersonCountInfo, "Text", intDBEntries);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
