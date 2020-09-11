using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//static IT.IT_Model;
using System.Windows.Forms;
using static PointScreen.Model;
using static IT.IT_Model;
using IT.Items;
using DatabaseHandle.Model;
using DatabaseHandle.DAL;
using System.IO;
using System.Drawing;

namespace IT
{
    public class IT_Controller
    {
        protected View _view;

        


        public IT_Controller(View view)
        {
            this._view = view;
        }

        public void LoadView()
        {
            //throw new NotImplementedException();
            _view.ShowDialog();
        }
        protected virtual void Close()
        {
            this._view.Hide();
            this._view.Close();
            this._view.Dispose();
            //
            //this._tmrCheckCauhoi.Stop();
            //this._tmrWaitForDoneRound1.Stop();
            //this._tmrCheckCauhoi = null;
            //this._tmrWaitForDoneRound1 = null;
        }


        //private int CheckAllHostConnected()
        //{
        //    return (new BLL()).CheckAllHostConnection();
        //}

        //public void CheckConnection()
        //{
        //    //throw new NotImplementedException();
        //    if ((new BLL()).CheckConnection() == 1)
        //        MessageBox.Show("Connection OK");
        //}




    }
    public class IT_Vong1_ChonDoi_Controller : IT_Controller
    {
        public IT_Vong1_ChonDoi_Controller(V_IT_Vong1_ChonDoi view) : base(view)
        {
            view.Load += View_Load;
        }

        private void View_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private List<Team> teams;
        public void GetTeams()
        {
            if (!(_view is V_IT_Vong1_ChonDoi))
                return;
            //int year = DateTime.UtcNow.Year;
            teams = (new BLL()).GetTeams();
            V_IT_Vong1_ChonDoi view = _view as V_IT_Vong1_ChonDoi;
            view.TenDoi1 = teams[0].Name;
            view.TenDoi2 = teams[1].Name;
            view.TenDoi3 = teams[2].Name;
        }
        public void MakeTeamsPending()
        {
            //throw new NotImplementedException();
            string teamIdGetPending = null;
            if ((teamIdGetPending = (new BLL()).MakeTeamsPending()) != null)
            {
                MessageBox.Show(teamIdGetPending);
            }
            else
            {
                MessageBox.Show("All Done");
            }
        }

        internal void GetDoiThiVong1()
        {
            string teamIdGetPending = (new BLL()).MakeTeamsPending();
            if((new BLL()).MakeExaming(teamIdGetPending))
            {
                App app = new App(new V_IT_Vong1_Thi());
                app.Load();
            }
        }
    }
    public class IT_Start_Controller: IT_Controller
    {
        
        public IT_Start_Controller(V_IT_Start view) : base(view)
        {

        }
        public void VoVong1()
        {
            //throw new NotImplementedException();
            //if (CheckAllHostConnected()==0)
            //{
            //    MessageBox.Show("Có máy chưa connected");
            //    return;
            //}
            //throw new NotImplementedException();

            //MessageBox.Show("OK");
            //
            //View preView = this._view;
            //preView.Controller = null;
            //preView.Hide();
            //preView.Close();


            ////
            //this._view = new V_IT_Vong1_ChonDoi();
            //this._view.Controller = this;
            //this._view.ShowDialog();
            //
            //this.
            //App newApp = new App(new V_IT_Vong1_ChonDoi());
            //newApp.Load();
            App app = new App(new V_IT_Vong1_ChonDoi());
            app.Load();

        }

        internal void VoVong2()
        {
            //throw new NotImplementedException();
            App app = new App(new V_IT_Vong2_NhapDiem());
            app.Load();
        }

        internal void VoVong3()
        {
            //throw new NotImplementedException();
            App app = new App(new V_IT_Vong3_Ready());
            app.Load();
        }
    }
    public class IT_Detail_Controller : IT_Controller
    {
        private List<ResultDetail> details;
        public IT_Detail_Controller(V_PointDetailTest view) :base(view)
        {
            this._view = view;
        }

        internal void LoadAllResultDetail()
        {
            //throw new NotImplementedException();
            details = GetAllResultDetail();
            LoadAllResultDetailToView(details);

        }

        private void LoadAllResultDetailToView(List<ResultDetail> details)
        {
            //throw new NotImplementedException();
            if(_view is V_PointDetailTest)
            {
                V_PointDetailTest myView = (V_PointDetailTest)_view;
                myView.ClearAllResultDetail();
                foreach(ResultDetail rd in details)
                {
                    ucQAdetail myQAdetail = new ucQAdetail();
                    myQAdetail.ID = rd.ID;
                    myQAdetail.TenDoi = rd.Team.Name;
                    myQAdetail.Vong = rd.RoundNum +"";
                    myQAdetail.STT = rd.QuestionNum + "";
                    myQAdetail.Diem = rd.Score;
                    myQAdetail.IsCorrect = rd.IsCorrect;
                    myQAdetail.NoiDungCauHoi = rd.Question.QuestionContentToString();
                    //
                    myView.AddResultDetail(myQAdetail);
                }
            }
            return;
        }

        private List<ResultDetail> GetAllResultDetail()
        {
            return (new BLL()).GetAllResultDetails();
        }
    }

    public class IT_Vong1Thi_Controller : IT_Controller
    {

        public IT_Vong1Thi_Controller(View v):base(v)
        {
            v.Load += V_Load;
        }
        private string _teamId = null;
        private void V_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CheckTeamExaming();
            CheckTeamPoint();
            
        }
        private void Reload()
        {
            V_Load(null,EventArgs.Empty);
        }

    private void CheckTeamPoint()
        {
            int curentPoint = CheckTeamCurrentPoint(_teamId);
            string rightAnswerState = CheckTeamNumberOfRightAnswer(_teamId);
            UpdateView(rightAnswerState, curentPoint);
        }

        private string CheckTeamNumberOfRightAnswer(string teamId)
        {
            //throw new NotImplementedException();
            return (new BLL()).CheckTeamNumberOfRightAnswerRound1(teamId);
        }

        private int CheckTeamCurrentPoint(string teamId)
        {
            //throw new NotImplementedException();
            Team myTeam = (new PointScreen.BLL()).GetTeam(_teamId);
            return myTeam.Score;
        }

        private Question _preQuestion = null;
        private void CheckTeamExaming()
        {
            _teamId = (new BLL()).GetTeamIdExaming();
            GetNextQuestion(_teamId);

        }

        public void GetNextQuestion(string teamId)
        {
            Question nextQues = null;
            if (_preQuestion == null)
            {
                nextQues = (new BLL()).GetNextQuestion(teamId,null);

            }
            else
            {
                nextQues = (new BLL()).GetNextQuestion(teamId,_preQuestion.Id);
            }

            UpdateView(nextQues);
            _preQuestion = nextQues;

        }

        private void UpdateView(Question nextQues)
        {
            //throw new NotImplementedException();
            if(_view is V_IT_Vong1_Thi)
            {
                V_IT_Vong1_Thi myView = _view as V_IT_Vong1_Thi;
                if(nextQues == null)// het cau hoi vong nay -- dk khác có vấn đề đây
                {

                    try
                    {
                        (new BLL()).MakeTeamDone(_teamId);
                        Close();
                    }
                    catch
                    {

                    }
                    return;

                    ////
                    ///


                }
                if(nextQues is Compound)
                {
                    Compound ques = nextQues as Compound;
                    myView.QuestionText = ques.QuestionContent + "\nA." + ques.ChoiceA + "\nB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\nD." + ques.ChoiceD;
                }
                else if (nextQues is Multiple_Choice)
                {
                    Multiple_Choice ques = nextQues as Multiple_Choice;
                    myView.QuestionText = ques.QuestionContent + "\nA." + ques.ChoiceA + "\nB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\nD." + ques.ChoiceD;
                }
                else if (nextQues is Fill_In)
                {
                    Fill_In ques = nextQues as Fill_In;
                    myView.QuestionText = ques.QuestionContent.Replace("NNN", "...");
                }
                else
                {
                    myView.QuestionText = nextQues.QuestionContent;
                }
                myView.AnswerKey = nextQues.AnswerKey;
                myView.QuestionNumText = nextQues.STT;
            }
        }
        private void UpdateView(string rightAnswer, int currentPoint)
        {
            if (_view is V_IT_Vong1_Thi)
            {
                V_IT_Vong1_Thi myView = _view as V_IT_Vong1_Thi;
                myView.CurrentPoint = currentPoint + "";
                myView.RightAnswerRate = rightAnswer;
            }
        }

        internal void SetWrong()
        {
            try
            {
                (new BLL()).SetWrong(_teamId, _preQuestion.Id);
            }
            //throw new NotImplementedException();
            catch(Exception e) // het cau
            {              
            }
            Reload();
            //GetNextQuestion(_teamId);
            //CheckTeamPoint();

        }
        internal void SetRight()
        {
            //throw new NotImplementedException();
            try
            {
                (new BLL()).SetRight(_teamId, _preQuestion.Id);
            }
            //throw new NotImplementedException();
            catch (Exception e) // het cau
            {
            }
            Reload();
        }
    }

    public class IT_Vong2NhapDiem_Controller: IT_Controller
    {
        public IT_Vong2NhapDiem_Controller(V_IT_Vong2_NhapDiem view) : base(view)
        {
            view.Load += View_Load;
        }

        private void View_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        private List<Team> teams;
        public void GetTeams()
        {
            if (!(_view is V_IT_Vong2_NhapDiem))
                return;
            //int year = DateTime.UtcNow.Year;
            teams = (new BLL()).GetTeams();
            V_IT_Vong2_NhapDiem view = _view as V_IT_Vong2_NhapDiem;

            view.IDDoi1 = teams[0].ID;
            view.IDDoi2 = teams[1].ID;
            view.IDDoi3 = teams[2].ID;

            //
            view.TenDoi1 = teams[0].Name;
            view.TenDoi2 = teams[1].Name;
            view.TenDoi3 = teams[2].Name;
        }

        public void InsertPointRound2(string teamId, int point)
        {
            if (!(_view is V_IT_Vong2_NhapDiem))
                return;
            //int year = DateTime.UtcNow.Year;
            //teams = (new BLL()).GetTeams();
            V_IT_Vong2_NhapDiem view = _view as V_IT_Vong2_NhapDiem;

            if((new BLL()).InsertPointRound2(teamId,point))
            {
                MessageBox.Show("Nhap Diem Thanh Cong, " + teamId + ", " + point);
            }
            else
            {
                MessageBox.Show("Something Wrong");
            }
        }
    }
    public class IT_Vong3_Controller:IT_Controller
    {
        public IT_Vong3_Controller(V_IT_Vong3 view) : base(view)
        {
            view.Load += View_Load;
        }

        private void View_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        internal void ShowKey()
        {
            //throw new NotImplementedException();
            (new BLL()).ShowKey();
        }

        private List<Team> teams;
        public void GetTeams()
        {
            if (!(_view is V_IT_Vong3))
                return;
            //int year = DateTime.UtcNow.Year;
            
            teams = (new BLL()).GetTeams();
            V_IT_Vong3 view = _view as V_IT_Vong3;

            if(teams!= null && teams.Count!=0)
            {
                view.IDDoi1 = teams[0].ID;
                view.IDDoi2 = teams[1].ID;
                view.IDDoi3 = teams[2].ID;

                //
                view.TenDoi1 = teams[0].Name;
                view.TenDoi2 = teams[1].Name;
                view.TenDoi3 = teams[2].Name;
                //
                view.DiemDoi1 = teams[0].Score;
                view.DiemDoi2 = teams[1].Score;
                view.DiemDoi3 = teams[2].Score;
            }
            
        }

        public void GetFirstQuestion()
        {
            //throw new NotImplementedException();
            GetNextQuestion();
        }
        Question _nextQuestion = new Question();
        public void GetNextQuestion()
        {
            Question ques = (new BLL()).GetNextQuestion(_nextQuestion.Id);
            if (ques == null)
                return;
            _nextQuestion = ques;
            if(_nextQuestion!=null)
            {
                //sắp xong
                if(_view is V_IT_Vong3)
                {
                    V_IT_Vong3 view = _view as V_IT_Vong3;
                    view.STT = _nextQuestion.STT;
                    view.QuestionContent = _nextQuestion.QuestionContentToString();
                    view.AnswerKey = _nextQuestion.AnswerKey;
                    if(_nextQuestion.Image64String!=null && _nextQuestion.Image64String!="")
                        view.QuestionImg = Image.FromStream(new MemoryStream(Convert.FromBase64String(_nextQuestion.Image64String)));

                }
            }
        }

        internal void GetPreQuestion()
        {
            Question ques = (new BLL()).GetPreQuestion(_nextQuestion.Id);
            if (ques == null)
                return;
            _nextQuestion = ques;
            if (_nextQuestion != null)
            {
                //sắp xong
                if (_view is V_IT_Vong3)
                {
                    V_IT_Vong3 view = _view as V_IT_Vong3;
                    view.STT = _nextQuestion.STT;
                    view.QuestionContent = _nextQuestion.QuestionContentToString();
                    view.AnswerKey = _nextQuestion.AnswerKey;
                    if (_nextQuestion.Image64String != null && _nextQuestion.Image64String != "")
                        view.QuestionImg = Image.FromStream(new MemoryStream(Convert.FromBase64String(_nextQuestion.Image64String)));

                }
            }
        }

        internal void GetNextQuestionState()
        {
            GetQuestionState();
        }

        private void GetQuestionState()
        {
            return;
            if(_nextQuestion==null || _nextQuestion.Id ==null)
            {
                return;
            }
            List<ResultDetail> rds = (new BLL()).GetResultDetailsWithQuesId(_nextQuestion.Id);
            if(rds.Count < 3)
            {
                return;
            }
            //trường hợp double sai
            var wrongRs = from rd in rds
                          where rd.IsCorrect == false
                          select rd;
            if(wrongRs.ToList().Count == 2)
            {

            }


        }

        internal void UpdateResultDetail()
        {
            //throw new NotImplementedException();
            if (_view is V_IT_Vong3)
            {
                V_IT_Vong3 view = _view as V_IT_Vong3;

                string idDoiDauTraLoi = view.IdDoiDauTienTraLoi;
                string idDoiThuHaiTraLoi = view.IdDoiDauThuHaiTraLoi;
                bool? rDoiDauTienTraLoi = view.DoiDauTienState;
                bool? rDoiThuHaiTraLoi = view.DoiThuHaiState;

                // hai doi ko tra loi

                if((idDoiDauTraLoi == "" || idDoiThuHaiTraLoi==null) && (idDoiThuHaiTraLoi == "" || idDoiThuHaiTraLoi == null))
                {
                    (new BLL()).UpdateResultDetail(_nextQuestion.Id,
                                                    view.IdDoiDauTienTraLoi,
                                                    view.DoiDauTienState,
                                                    view.IdDoiDauThuHaiTraLoi,
                                                    view.DoiThuHaiState
                        );
                }
                else if ((idDoiDauTraLoi != "" || idDoiThuHaiTraLoi != null) && (idDoiThuHaiTraLoi == "" || idDoiThuHaiTraLoi == null)) //doi thu 1 trả lời, đội 2 không trả lời
                {
                    (new BLL()).UpdateResultDetail(_nextQuestion.Id,
                                                     view.IdDoiDauTienTraLoi,
                                                     view.DoiDauTienState,
                                                     view.IdDoiDauThuHaiTraLoi,
                                                     view.DoiThuHaiState
                         );
                }
                else if ((idDoiDauTraLoi != "" || idDoiThuHaiTraLoi != null) && (idDoiThuHaiTraLoi != "" || idDoiThuHaiTraLoi != null)) //doi thu 1 trả lời, đội 2 không trả lời
                {
                    (new BLL()).UpdateResultDetail(_nextQuestion.Id,
                                                     view.IdDoiDauTienTraLoi,
                                                     view.DoiDauTienState,
                                                     view.IdDoiDauThuHaiTraLoi,
                                                     view.DoiThuHaiState
                         );
                }
                else //doi thu 1 trả lời, đội 2 không trả lời
                {
                    return;
                }

            }
        }
    }
    public class IT_Vong3_GetReady_Controller:IT_Controller
    {
        public IT_Vong3_GetReady_Controller(V_IT_Vong3_Ready view) : base(view)
        {
            view.Load += View_Load;
        }
        
        internal void MakeReady()
        {
            //throw new NotImplementedException();
            (new BLL()).MakeTeamRound3Ready();
        }

        private void View_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
    
}
