﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warewolf.UITests.Common;

namespace Warewolf.UITests.DebugInputWindow
{
    [CodedUITest]
    public class SaveDialogWindowTets
    {
        const string TestingWF = "TestingWF";
        const string InvalidName = "Inv@lid N&m#";
        const string NameHasWhiteSpace = "Test ";
        const string ValidWFName = "ValidWFName";

        [TestMethod]
        public void SaveDialogWindowUITets()
        {
            Uimap.Click_New_Workflow_Ribbon_Button();
            Uimap.Drag_Toolbox_MultiAssign_Onto_DesignSurface();
            Uimap.Open_Assign_Tool_Large_View();
            Uimap.Enter_Text_Into_Assign_Large_View_Row1_Variable_Textbox_As_SomeVariable();
            Uimap.Assign_Value_To_Variable_With_Assign_Tool_large_View_Row_1();
            Uimap.Click_Save_Ribbon_Button_to_Open_Save_Dialog();
            Uimap.Remove_WorkflowName_From_Save_Dialog();
            Uimap.Enter_Service_Name_Into_Save_Dialog(TestingWF);
            Uimap.Click_SaveDialog_Save_Button();
            Uimap.Click_Close_Workflow_Tab_Button();
            Uimap.Click_Duplicate_From_ExplorerContextMenu(TestingWF);
            Uimap.Enter_Service_Name_Into_Save_Dialog(TestingWF, true, saveOrDuplicate: Common.SaveOrDuplicate.Duplicate);
            Uimap.Enter_Service_Name_Into_Save_Dialog(InvalidName, invalid: true, saveOrDuplicate: SaveOrDuplicate.Duplicate);
            Uimap.Enter_Service_Name_Into_Save_Dialog(NameHasWhiteSpace, nameHasWhiteSpace: true, saveOrDuplicate: SaveOrDuplicate.Duplicate);
            Uimap.Enter_Service_Name_Into_Save_Dialog(ValidWFName, saveOrDuplicate: SaveOrDuplicate.Duplicate);
            Uimap.Click_Duplicate_From_Duplicate_Dialog();
        }

        #region Additional test attributes
        
        [TestInitialize()]
        public void MyTestInitialize()
        {
#if !DEBUG
            Uimap.CloseHangingDialogs();
#endif
            Console.WriteLine("Test \"" + TestContext.TestName + "\" starting on " + Environment.MachineName);
        }
        
        [TestCleanup()]
        public void MyTestCleanup()
        {
            Playback.PlaybackError -= Uimap.OnError;
            var resourcesFolder = Environment.ExpandEnvironmentVariables("%programdata%") + @"\Warewolf\Resources";
            File.Delete(resourcesFolder + @"\" + ValidWFName + ".xml");
            File.Delete(resourcesFolder + @"\" + TestingWF + ".xml");
        }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        UIMap Uimap
        {
            get
            {
                if (_uiMap == null)
                {
                    _uiMap = new UIMap();
                }

                return _uiMap;
            }
        }

        private UIMap _uiMap;

        #endregion
    }
}