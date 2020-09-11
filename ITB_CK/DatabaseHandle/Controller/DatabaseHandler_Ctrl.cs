using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DatabaseHandle.Model;
using System.IO;
//using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace DatabaseHandle.Controller
{
    public class DatabaseHandler_Ctrl
    {
        public class Result
        {
            public List<Question> GottenQuestions { get; set; }
            public List<string> NotGottenQuestion { get; set; }
        }
        public Result ImportExcelFile(string path)
        {
            if (!KiemTraCuPhapFile(path))
                throw new Exception("Loi Cu Phap File");
            List<Question> myGottenQuestions = new List<Question>();
            List<string> myCannotAddQuestionList = new List<string>();
            // nhận đối tượng rỗng
            Application myApp = null;
            Workbooks myBooks = null;
            Workbook myBook = null;

            Sheets mySheets = null;
            Worksheet mySheet = null;
            try
            {
                //bool kqCheck = false;

                // nạp dữ liệu lên
                myApp = new Application();
                myBooks = myApp.Workbooks;
                myBook = myBooks.Open(path);
                mySheets = myBook.Worksheets;
                mySheet = (Worksheet)mySheets[1];
                var cells = mySheet.Cells;
                var range = cells.SpecialCells(XlCellType.xlCellTypeLastCell);
                // kiểm tra dữ liệu
                int lastRow = range.Row;

                int lastColumn = range.Column;
                var mangHeaderChuan = new string[9]
                                                {
                                                    "STT",
                                                    "Question Type",
                                                    "Score",
                                                    "QuestionContent",
                                                    "Choice A",
                                                    "Choice B",
                                                    "Choice C",
                                                    "Choice D",
                                                    "Anser Key"
                                                };
                int i = 4;
                int colToCheck = mangHeaderChuan.Length;
                
                for (i = 2; i <= lastRow; i++)
                {
                    string type = mySheet.Cells[i, 2].Value2;
                    Question myQuestion = Question.CreateNewQuestion(type);
                    if(myQuestion != null)
                    {
                        myQuestion.Score = (int)mySheet.Cells[i, 3].Value2;
                        myQuestion.QuestionContent= (string)mySheet.Cells[i, 4].Value2;
                        myQuestion.AnswerKey = mySheet.Cells[i, 9].Value2+"";
                        if(myQuestion is Multiple_Choice)
                        {
                            Multiple_Choice myMultipleChoiceQuestion = (Multiple_Choice)myQuestion;
                            myMultipleChoiceQuestion.ChoiceA = mySheet.Cells[i, 5].Value2;
                            myMultipleChoiceQuestion.ChoiceB = mySheet.Cells[i, 6].Value2;
                            myMultipleChoiceQuestion.ChoiceC = mySheet.Cells[i, 7].Value2;
                            myMultipleChoiceQuestion.ChoiceD = mySheet.Cells[i, 8].Value2;
                        }
                        if (myQuestion is Compound)
                        {
                            Compound myCompoundQuesion = (Compound)myQuestion;
                            myCompoundQuesion.ChoiceA = mySheet.Cells[i, 5].Value2;
                            myCompoundQuesion.ChoiceB = mySheet.Cells[i, 6].Value2;
                            myCompoundQuesion.ChoiceC = mySheet.Cells[i, 7].Value2;
                            myCompoundQuesion.ChoiceD = mySheet.Cells[i, 8].Value2;
                        }
                        myGottenQuestions.Add(myQuestion);
                    }
                    else
                        myCannotAddQuestionList.Add(i.ToString());
                    
                


                }
                if (i == lastColumn + 1)
                {
                    //kqCheck = true;
                }
                

                //object MissingTypeLocal = System.Reflection.Missing.Value;
                //myBook.Close(true, MissingTypeLocal, MissingTypeLocal);
                //myBooks.Close();
                //myApp.Quit();
                //

                /*
                string type = mySheet.Cells[i, 2].Value2;
                Question myQuestion = Question.CreateNewQuestion(type);
                if (myQuestion != null)
                {
                    myQuestion.Score = (int)mySheet.Cells[i, 3].Value2;
                    myQuestion.QuestionContent = (string)mySheet.Cells[i, 4].Value2;
                    myQuestion.AnswerKey = mySheet.Cells[i, 9].Value2 + "";
                    if (myQuestion is Multiple_Choice)
                    {
                        Multiple_Choice myMultipleChoiceQuestion = (Multiple_Choice)myQuestion;
                        myMultipleChoiceQuestion.ChoiceA = mySheet.Cells[i, 5].Value2;
                        myMultipleChoiceQuestion.ChoiceB = mySheet.Cells[i, 6].Value2;
                        myMultipleChoiceQuestion.ChoiceC = mySheet.Cells[i, 7].Value2;
                        myMultipleChoiceQuestion.ChoiceD = mySheet.Cells[i, 8].Value2;
                    }
                    if (myQuestion is Compound)
                    {
                        Compound myCompoundQuesion = (Compound)myQuestion;
                        myCompoundQuesion.ChoiceA = mySheet.Cells[i, 5].Value2;
                        myCompoundQuesion.ChoiceB = mySheet.Cells[i, 6].Value2;
                        myCompoundQuesion.ChoiceC = mySheet.Cells[i, 7].Value2;
                        myCompoundQuesion.ChoiceD = mySheet.Cells[i, 8].Value2;
                    }
                    myGottenQuestions.Add(myQuestion);
                }
                else
                    myCannotAddQuestionList.Add(i.ToString());
                    */

                object MissingTypeLocal = System.Reflection.Missing.Value;
                myBook.Close(true, MissingTypeLocal, MissingTypeLocal);
                myBooks.Close();
                myApp.Quit();
                releaseObject(range);
                releaseObject(cells);
                releaseObject(mySheet);
                releaseObject(mySheets);
                releaseObject(myBook);
                releaseObject(myBooks);
                releaseObject(myApp);
            }
            catch
            {

            }
            // trả bộ nhớ lại

            //
            //foreach(var Cell in mySheet.Cells)
            //{
            //    Marshal.ReleaseComObject(Cell);
            //}
            //


            return new Result
            {
                GottenQuestions = myGottenQuestions,
                NotGottenQuestion = myCannotAddQuestionList
            };
            //
        }
        private bool KiemTraCuPhapFile(string path)
        {
            /*
             * Kiểm tra cú pháp file:
             * Đọc dữ liệu từng dòng -- tạo đối tượng question và đưa vào mảng
             * Đóng các tiến trình và ngừng thao tác
             * Trả về mảng Question
             * 
             */
            if (!File.Exists(path))
                return false;
            //
            //
            //
            bool kqCheck = false;
            // nhận đối tượng rỗng
            Application myApp = null;
            Workbooks myBooks = null;
            Workbook myBook = null;
            
            Sheets mySheets = null;
            Worksheet mySheet = null;
            //Cells cells = null;
            //object range = null;
            try
            {
                //bool kqCheck = false;

                // nạp dữ liệu lên
                myApp = new Application();
                myBooks = myApp.Workbooks;
                myBook = myBooks.Open(path);
                mySheets = myBook.Worksheets;
                mySheet = (Worksheet)mySheets[1];
                var cells = mySheet.Cells;
                var range = cells.SpecialCells(XlCellType.xlCellTypeLastCell);
                // kiểm tra dữ liệu
                int lastRow = range.Row;

                int lastColumn = range.Column;
                var mangHeaderChuan = new string[9]
                                                {
                                                    "STT",
                                                    "Question Type",
                                                    "Score",
                                                    "QuestionContent",
                                                    "Choice A",
                                                    "Choice B",
                                                    "Choice C",
                                                    "Choice D",
                                                    "Anser Key"
                                                };
                int i = 1;
                int colToCheck = mangHeaderChuan.Length;
                for(i=1; i<=colToCheck;i++)
                {
                    if (mySheet.Cells[1, i].Value2 != mangHeaderChuan[i - 1])
                        break;
                    
                }
                if(i == lastColumn+1)
                {
                    kqCheck = true;
                }

                //object MissingTypeLocal = System.Reflection.Missing.Value;
                //myBook.Close(true, MissingTypeLocal, MissingTypeLocal);
                //myBooks.Close();
                //myApp.Quit();
                //

                object MissingTypeLocal = System.Reflection.Missing.Value;
                myBook.Close(true, MissingTypeLocal, MissingTypeLocal);
                myBooks.Close();
                myApp.Quit();
                releaseObject(range);
                releaseObject(cells);
                releaseObject(mySheet);
                releaseObject(mySheets);
                releaseObject(myBook);
                releaseObject(myBooks);
                releaseObject(myApp);
            }
            catch
            {
                
            }
            // trả bộ nhớ lại
            
            //
            //foreach(var Cell in mySheet.Cells)
            //{
            //    Marshal.ReleaseComObject(Cell);
            //}
            //
            

            
            //
            return kqCheck;
        }
        private void releaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            finally
            {
                GC.Collect();
                //GC.WaitForPendingFinalizers();
            }
        }
    }
}
