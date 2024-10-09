using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCTInvestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTInvestApp.Tests
{
    [TestClass()]
    public class GetSendFormViewModelTests
    {
        private Dictionary<string, string> _hexCodesPlug = new();

        private const string REAL_HEX_CODE = "304DB75F196000180001C13A";

        public GetSendFormViewModelTests()
        {
            _hexCodesPlug.Add(REAL_HEX_CODE,"ObgectName");
        }

        //---------------------------------------------
        // Test entered hexcodes
        //---------------------------------------------
        [TestMethod()]
        public void AddToTakerDbTest_Not24SimbolCode_returnEmptyDB()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string not24simbolCode = "00000000000000000000A";

            //act
            FormVM.TakerRichTextBox = not24simbolCode;
            FormVM.AddToTakerDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 0);
        }
        [TestMethod()]
        public void AddToTakerDbTest_NotHEXCode_returnEmptyDB()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string notHEXCode = "00000000000000000000AMMM";

            //act
            FormVM.TakerRichTextBox = notHEXCode;
            FormVM.AddToTakerDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 0);
        }
        [TestMethod()]
        public void AddToTakerDbTest_doStringEmpty_returnEmptyDB()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string emptyString = string.Empty;

            //act
            FormVM.TakerRichTextBox = emptyString;
            FormVM.AddToTakerDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 0);
        }
        [TestMethod()]
        public void AddToSenderDbTest_Not24SimbolCode_returnEmptyDB()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string not24simbolCode = "00000000000000000000A";

            //act
            FormVM.SenderRichTextBox = not24simbolCode;
            FormVM.AddToSenderDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 0);
        }
        [TestMethod()]
        public void AddToSenderDbTest_NotHEXCode_returnEmptyDB()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string notHEXCode = "00000000000000000000AMMM";

            //act
            FormVM.SenderRichTextBox = notHEXCode;
            FormVM.AddToSenderDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 0);
        }
        [TestMethod()]
        public void AddToSenderDbTest_doStringEmpty_returnEmptyDB()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string emptyString = string.Empty;

            //act
            FormVM.SenderRichTextBox = emptyString;
            FormVM.AddToSenderDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 0);
        }

        [TestMethod()]
        public void AddToTakerDbTest_AddLowerHexCode_returnAddedHexCode()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();
            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            string not24simbolCode = REAL_HEX_CODE.ToLower();

            //act
            FormVM.TakerRichTextBox = not24simbolCode;
            FormVM.AddToTakerDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView[0].Id == REAL_HEX_CODE);
        }


        //---------------------------------------------
        // Test: delete from db, when we add to another db
        //---------------------------------------------

        [TestMethod()]
        public void AddAllFromFieldTest_doAddtoTaker2Code_AddtoSender1Code_returnTaker1Code()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();

            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            //act
            //Добавляем 2
            FormVM.TakerRichTextBox = REAL_HEX_CODE;
            FormVM.AddToTakerDb();
            FormVM.TakerRichTextBox = REAL_HEX_CODE;
            FormVM.AddToTakerDb();

            //добавляем 1
            FormVM.SenderRichTextBox = REAL_HEX_CODE;
            FormVM.AddToSenderDb();

            //assert
            Assert.IsTrue(FormVM.TakerDataGridView.Count == 1);
        }
        [TestMethod()]
        public void AddAllFromFieldTest_doAddtoSender2Code_addtoTaker1Code_returnTaker1Code()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();

            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            //act
            //Добавляем 2
            FormVM.SenderRichTextBox = REAL_HEX_CODE;
            FormVM.AddToSenderDb();
            FormVM.SenderRichTextBox = REAL_HEX_CODE;
            FormVM.AddToSenderDb();

            //Добавляем 1
            FormVM.TakerRichTextBox = REAL_HEX_CODE;
            FormVM.AddToTakerDb();

            //assert
            Assert.IsTrue(FormVM.SenderDataGridView.Count == 1);
        }


        //---------------------------------------------
        // Test cleaner
        //---------------------------------------------
        [TestMethod()]
        public void CleanTest_doAddtoSender2Code_addtoTaker1Code_returnAlldbCleaned()
        {
            //arrange
            ISimpleFormComands myPlug = new PlugClass();

            GetSendFormViewModel FormVM = new(myPlug, _hexCodesPlug);

            //act
            FormVM.SenderRichTextBox = REAL_HEX_CODE;
            FormVM.AddToSenderDb();
            FormVM.SenderRichTextBox = REAL_HEX_CODE;
            FormVM.AddToSenderDb();
            FormVM.TakerRichTextBox = REAL_HEX_CODE;
            FormVM.AddToTakerDb();

            FormVM.CleanBothForm();

            //assert
            Assert.IsTrue((FormVM.SenderDataGridView.Count == 0) 
                            && (FormVM.TakerDataGridView.Count == 0));
        }




    }



    class PlugClass : ISimpleFormComands
    {
        public void ShowErrorMessege(string str)
        {
            //ничего
        }

        public void ShowMessege(string str)
        {
            //ничего
        }
    }






}