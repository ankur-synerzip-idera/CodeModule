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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RxDatabase
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RxDatabaseRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("7ed330c8-5668-4cfa-9ca9-402c4c23b7e2")]
    public partial class RxDatabaseRepository : RepoGenBaseFolder
    {
        static RxDatabaseRepository instance = new RxDatabaseRepository();
        RxDatabaseRepositoryFolders.RxMainFrameAppFolder _rxmainframe;
        RxDatabaseRepositoryFolders.List1000AppFolder _list1000;

        /// <summary>
        /// Gets the singleton class instance representing the RxDatabaseRepository element repository.
        /// </summary>
        [RepositoryFolder("7ed330c8-5668-4cfa-9ca9-402c4c23b7e2")]
        public static RxDatabaseRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RxDatabaseRepository() 
            : base("RxDatabaseRepository", "/", null, 0, false, "7ed330c8-5668-4cfa-9ca9-402c4c23b7e2", ".\\RepositoryImages\\RxDatabaseRepository7ed330c8.rximgres")
        {
            _rxmainframe = new RxDatabaseRepositoryFolders.RxMainFrameAppFolder(this);
            _list1000 = new RxDatabaseRepositoryFolders.List1000AppFolder(this);
        }

#region Variables

        string _lstDepartment = "Project Management";

        /// <summary>
        /// Gets or sets the value of variable lstDepartment.
        /// </summary>
        [TestVariable("1a4b355a-3518-49c1-b7c7-a1c6769e6a6c")]
        public string lstDepartment
        {
            get { return _lstDepartment; }
            set { _lstDepartment = value; }
        }

        string _selGender = "rdbMale";

        /// <summary>
        /// Gets or sets the value of variable selGender.
        /// </summary>
        [TestVariable("04fa194a-83d9-4335-8e49-32152207d5a8")]
        public string selGender
        {
            get { return _selGender; }
            set { _selGender = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7ed330c8-5668-4cfa-9ca9-402c4c23b7e2")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("90b14745-bf25-4b07-9bb2-d31f69970826")]
        public virtual RxDatabaseRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("57208867-ed11-4ec8-924b-0dc686980a77")]
        public virtual RxDatabaseRepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class RxDatabaseRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("90b14745-bf25-4b07-9bb2-d31f69970826")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RxDatabaseRepositoryFolders.RxTabStandardFolder _rxtabstandard;
            RepoItemInfo _testdatabaseInfo;
            RepoItemInfo _btnaddpersonInfo;
            RepoItemInfo _personcountInfo;
            RepoItemInfo _rxbuttonexitInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "90b14745-bf25-4b07-9bb2-d31f69970826", "")
            {
                _rxtabstandard = new RxDatabaseRepositoryFolders.RxTabStandardFolder(this);
                _testdatabaseInfo = new RepoItemInfo(this, "TestDatabase", "?/?/tabpage[@accessiblename='Test database']", 30000, null, "34b9f228-153b-44b4-ae34-1e2747592b0f");
                _btnaddpersonInfo = new RepoItemInfo(this, "BtnAddPerson", "?/?/tabpage[@controlname='RxTabStandard']/button[@controlname='btnAddPerson']", 30000, null, "0716c660-ce8c-4fb8-a033-a58ae01bc4fa");
                _personcountInfo = new RepoItemInfo(this, "PersonCount", "?/?/tabpage[@controlname='RxTabStandard']/text[@controlname='lblNumberOfPersonsNumber']", 30000, null, "2580fade-1b69-498e-a86e-74c7c8e8be71");
                _rxbuttonexitInfo = new RepoItemInfo(this, "RxButtonExit", "button[@controlname='RxButtonExit']", 30000, null, "02058d54-efaf-4a1d-b09d-9d7d8538364d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("90b14745-bf25-4b07-9bb2-d31f69970826")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("90b14745-bf25-4b07-9bb2-d31f69970826")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TestDatabase item.
            /// </summary>
            [RepositoryItem("34b9f228-153b-44b4-ae34-1e2747592b0f")]
            public virtual Ranorex.TabPage TestDatabase
            {
                get
                {
                    return _testdatabaseInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TestDatabase item info.
            /// </summary>
            [RepositoryItemInfo("34b9f228-153b-44b4-ae34-1e2747592b0f")]
            public virtual RepoItemInfo TestDatabaseInfo
            {
                get
                {
                    return _testdatabaseInfo;
                }
            }

            /// <summary>
            /// The BtnAddPerson item.
            /// </summary>
            [RepositoryItem("0716c660-ce8c-4fb8-a033-a58ae01bc4fa")]
            public virtual Ranorex.Button BtnAddPerson
            {
                get
                {
                    return _btnaddpersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnAddPerson item info.
            /// </summary>
            [RepositoryItemInfo("0716c660-ce8c-4fb8-a033-a58ae01bc4fa")]
            public virtual RepoItemInfo BtnAddPersonInfo
            {
                get
                {
                    return _btnaddpersonInfo;
                }
            }

            /// <summary>
            /// The PersonCount item.
            /// </summary>
            [RepositoryItem("2580fade-1b69-498e-a86e-74c7c8e8be71")]
            public virtual Ranorex.Text PersonCount
            {
                get
                {
                    return _personcountInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The PersonCount item info.
            /// </summary>
            [RepositoryItemInfo("2580fade-1b69-498e-a86e-74c7c8e8be71")]
            public virtual RepoItemInfo PersonCountInfo
            {
                get
                {
                    return _personcountInfo;
                }
            }

            /// <summary>
            /// The RxButtonExit item.
            /// </summary>
            [RepositoryItem("02058d54-efaf-4a1d-b09d-9d7d8538364d")]
            public virtual Ranorex.Button RxButtonExit
            {
                get
                {
                    return _rxbuttonexitInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RxButtonExit item info.
            /// </summary>
            [RepositoryItemInfo("02058d54-efaf-4a1d-b09d-9d7d8538364d")]
            public virtual RepoItemInfo RxButtonExitInfo
            {
                get
                {
                    return _rxbuttonexitInfo;
                }
            }

            /// <summary>
            /// The RxTabStandard folder.
            /// </summary>
            [RepositoryFolder("6634980e-930f-41f9-a6d0-229595c55fed")]
            public virtual RxDatabaseRepositoryFolders.RxTabStandardFolder RxTabStandard
            {
                get { return _rxtabstandard; }
            }
        }

        /// <summary>
        /// The RxTabStandardFolder folder.
        /// </summary>
        [RepositoryFolder("6634980e-930f-41f9-a6d0-229595c55fed")]
        public partial class RxTabStandardFolder : RepoGenBaseFolder
        {
            RepoItemInfo _openInfo;
            RepoItemInfo _genderInfo;
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _agevalueInfo;

            /// <summary>
            /// Creates a new RxTabStandard  folder.
            /// </summary>
            public RxTabStandardFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabStandard", "?/?/tabpage[@controlname='RxTabStandard']", parentFolder, 30000, null, false, "6634980e-930f-41f9-a6d0-229595c55fed", "")
            {
                _openInfo = new RepoItemInfo(this, "Open", "combobox[@controlname='cmbDepartment']/button", 30000, null, "33397b0b-43c6-4daa-99a2-c7853656f16f");
                _genderInfo = new RepoItemInfo(this, "Gender", "?/?/radiobutton[@controltext=$selGender]", 30000, null, "a47a714c-11a3-4925-b181-0c2445fd1e45");
                _firstnameInfo = new RepoItemInfo(this, "FirstName", "?/?/text[@accessiblename='First name']", 30000, null, "cdb32e2f-3a94-4215-a4ce-eb4b5d575b1b");
                _lastnameInfo = new RepoItemInfo(this, "LastName", "?/?/text[@accessiblename='Last name']", 30000, null, "ee66a06e-163b-42b6-8abc-248006bf88ab");
                _agevalueInfo = new RepoItemInfo(this, "AgeValue", "?/?/text[@controlname='upDownEdit']", 30000, null, "305b1e85-498e-4d07-9051-6cd79362827e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6634980e-930f-41f9-a6d0-229595c55fed")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6634980e-930f-41f9-a6d0-229595c55fed")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Open item.
            /// </summary>
            [RepositoryItem("33397b0b-43c6-4daa-99a2-c7853656f16f")]
            public virtual Ranorex.Button Open
            {
                get
                {
                    return _openInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Open item info.
            /// </summary>
            [RepositoryItemInfo("33397b0b-43c6-4daa-99a2-c7853656f16f")]
            public virtual RepoItemInfo OpenInfo
            {
                get
                {
                    return _openInfo;
                }
            }

            /// <summary>
            /// The Gender item.
            /// </summary>
            [RepositoryItem("a47a714c-11a3-4925-b181-0c2445fd1e45")]
            public virtual Ranorex.RadioButton Gender
            {
                get
                {
                    return _genderInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The Gender item info.
            /// </summary>
            [RepositoryItemInfo("a47a714c-11a3-4925-b181-0c2445fd1e45")]
            public virtual RepoItemInfo GenderInfo
            {
                get
                {
                    return _genderInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("cdb32e2f-3a94-4215-a4ce-eb4b5d575b1b")]
            public virtual Ranorex.Text FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("cdb32e2f-3a94-4215-a4ce-eb4b5d575b1b")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("ee66a06e-163b-42b6-8abc-248006bf88ab")]
            public virtual Ranorex.Text LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("ee66a06e-163b-42b6-8abc-248006bf88ab")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The AgeValue item.
            /// </summary>
            [RepositoryItem("305b1e85-498e-4d07-9051-6cd79362827e")]
            public virtual Ranorex.Text AgeValue
            {
                get
                {
                    return _agevalueInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AgeValue item info.
            /// </summary>
            [RepositoryItemInfo("305b1e85-498e-4d07-9051-6cd79362827e")]
            public virtual RepoItemInfo AgeValueInfo
            {
                get
                {
                    return _agevalueInfo;
                }
            }
        }

        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("57208867-ed11-4ec8-924b-0dc686980a77")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _seldepartmentInfo;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@controlid='1000']", parentFolder, 30000, null, true, "57208867-ed11-4ec8-924b-0dc686980a77", "")
            {
                _seldepartmentInfo = new RepoItemInfo(this, "selDepartment", "listitem[@text=$lstDepartment]", 30000, null, "b32a1d4e-4dd5-4fee-b85a-452aaf6b98c3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("57208867-ed11-4ec8-924b-0dc686980a77")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("57208867-ed11-4ec8-924b-0dc686980a77")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The selDepartment item.
            /// </summary>
            [RepositoryItem("b32a1d4e-4dd5-4fee-b85a-452aaf6b98c3")]
            public virtual Ranorex.ListItem selDepartment
            {
                get
                {
                    return _seldepartmentInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The selDepartment item info.
            /// </summary>
            [RepositoryItemInfo("b32a1d4e-4dd5-4fee-b85a-452aaf6b98c3")]
            public virtual RepoItemInfo selDepartmentInfo
            {
                get
                {
                    return _seldepartmentInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
