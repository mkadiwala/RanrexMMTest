///////////////////////////////////////////////////////////////////////////////
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

namespace Zoom_Web
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddUser recording.
    /// </summary>
    [TestModule("0e70d5ac-072a-4e58-a2a5-c18a5c64d51b", ModuleType.Recording, 1)]
    public partial class AddUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Zoom_WebRepository repository.
        /// </summary>
        public static Zoom_WebRepository repo = Zoom_WebRepository.Instance;

        static AddUser instance = new AddUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddUser()
        {
            FirstName = "Mubin";
            LstName = "Kad";
            Gender = "male";
            Category = "Music";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddUser Instance
        {
            get { return instance; }
        }

#region Variables

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("754e556e-244d-439a-8a70-8be3aafd87b6")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _LstName;

        /// <summary>
        /// Gets or sets the value of variable LstName.
        /// </summary>
        [TestVariable("5c6e7513-caf7-4fe0-a0c4-20aa3a279d85")]
        public string LstName
        {
            get { return _LstName; }
            set { _LstName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("162095fa-201a-4722-b135-a82b762480e2")]
        public string Gender
        {
            get { return repo.Gender; }
            set { repo.Gender = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Category.
        /// </summary>
        [TestVariable("3b8c95c3-31a2-4a00-8440-9ab2e9afa3fd")]
        public string Category
        {
            get { return repo.Category; }
            set { repo.Category = value; }
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Textboxes.FirstName' at Center.", repo.ApplicationUnderTest.Textboxes.FirstNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Textboxes.FirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'ApplicationUnderTest.Textboxes.FirstName'.", repo.ApplicationUnderTest.Textboxes.FirstNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Textboxes.FirstName.PressKeys(FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Textboxes.LastName' at Center.", repo.ApplicationUnderTest.Textboxes.LastNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Textboxes.LastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'yourtext' with focus on 'ApplicationUnderTest.Textboxes.LastName'.", repo.ApplicationUnderTest.Textboxes.LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Textboxes.LastName.PressKeys("yourtext");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Buttons.Gender' at 6;10.", repo.ApplicationUnderTest.Buttons.GenderInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Buttons.Gender.Click("6;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Category' at 60;12.", repo.ApplicationUnderTest.CategoryInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Category.Click("60;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Buttons.InputTagAdd' at 11;13.", repo.ApplicationUnderTest.Buttons.InputTagAddInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Buttons.InputTagAdd.Click("11;13");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
