using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using QuestionModel = DatabaseHandle.Model;
using TeamModel = PointScreen.Model;
//using Model = MC.MC_Model;
using static MC.MC_Model;
using System.Windows.Forms;
using System.Drawing;
using DatabaseHandle.Model;

namespace MC
{
    public class MC_Controller
    {
        private RightNowInfo _info;
        protected View _view;
        public MC_Controller(View view)
        {
            _view = view;
        }
        public void LoadView()
        {            
            int x = Screen.PrimaryScreen.Bounds.Width / 2;
            int y = Screen.PrimaryScreen.Bounds.Height / 2;
            _view.Location = new Point(x, y);
            _view.ShowDialog();
        }
        internal void CheckOnStartUp()
        {
            _info = (new BLL()).GetRightNowInfo();
            int atRound = _info.AtRound;
            List<TeamModel.Team> teams = _info.TeamsRightNow;
            if(atRound == 1)
            {
                if (teams[0].Round1State == "examing")
                {
                    //throw new ApplicationException();
                    _view.Close();
                    MessageBox.Show("Vòng " +atRound +". \nKết nối trong khi có đội đang thi.\nTriển khai phương án dự phòng.", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (teams[0].Round1State == "yet")
                    return ;
                if(teams[0].Round1State =="pending")
                {
                    V_MC_Vong1 vV1Pending = new V_MC_Vong1();
                    View preView = this._view;
                    //
                    vV1Pending.Controller = this;
                    this._view = vV1Pending;
                    //
                    preView.Close();

                    //vV1Pending.Show();
                    //vStart.Hide();
                    this._view.ShowDialog();
                    //
                    // vStart.tmr3dot.Stop();
                    //vStart.tmr3dot.Enabled = false;
                    //vStart.Hide();
                    return ;
                }
                throw new ApplicationException();
            }
            else if (atRound == 2)
            {
                return ;
            }
            else if(atRound ==3)
            {
                throw new NotImplementedException();
            }
            throw new InvalidOperationException();
            //throw new NotImplementedException();
        }

        internal void Check()
        {
            //throw new NotImplementedException();
        }
        protected virtual void Close()
        {
            this._view.Hide();
            this._view.Close();
            this._view.Dispose();
        }
    }

    public class MC_Vong1_Controller: MC_Controller
    {
        public MC_Vong1_Controller(V_MC_Vong1 v) : base(v)
        {
            v.Load += V_Load;
        }

       
        private Timer _tmrCheckCauhoi;
        private Timer _tmrWaitForDoneRound1;
        private bool _getQuestionIsDone = false;
        

        private void V_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            _tmrCheckCauhoi = new Timer();
            _tmrCheckCauhoi.Interval = 300;
            _tmrCheckCauhoi.Start();
            _tmrCheckCauhoi.Tick += _tmrCheckCauhoi_Tick;

            //
            _tmrWaitForDoneRound1 = new Timer();
            _tmrWaitForDoneRound1.Interval = 1000;
            _tmrWaitForDoneRound1.Start();
            _tmrWaitForDoneRound1.Tick += _tmrWaitForDoneRound1_Tick;

        }
        private string _teamId = null;
        private void _tmrCheckCauhoi_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CheckTeamExaming();
        }
        private void CheckTeamExaming()
        {
            string teamIdExaming = (new BLL()).GetTeamIdExaming();
            if (teamIdExaming != null)
                _teamId = teamIdExaming;
            //
            GetNextQuestion(_teamId);

        }
        private Question _preQuestion = null;
        public void GetNextQuestion(string teamId)
        {
            Question nextQues = null;
            if (_preQuestion == null)
            {
                nextQues = (new BLL()).GetNextQuestion(teamId, null);

            }
            else
            {
                nextQues = (new BLL()).GetNextQuestion(teamId, _preQuestion.Id);
            }
            if (_preQuestion == null)
            {
                UpdateView(nextQues, false);
                _preQuestion = nextQues;
            }
            else if (nextQues != null && _preQuestion.Id != nextQues.Id)
            {
                UpdateView(nextQues, true);
                _preQuestion = nextQues;
            }
            else if (nextQues == null)
            {
                //done
                //if (_getQuestionIsDone)
                //{
                //    return;
                //}
                //_getQuestionIsDone = true;
                //done --- nhung o get dc gi thoi (xong nhung chua het gio)
                //_tmrWaitForDoneRound1 = new Timer();
                //_tmrWaitForDoneRound1.Interval = 500;
                //_tmrWaitForDoneRound1.Start();
                //_tmrWaitForDoneRound1.Tick += _tmrWaitForDoneRound1_Tick;
            }


        }

        //còn _teamId-Là còn get được


        private void _tmrWaitForDoneRound1_Tick(object sender, EventArgs e)
        {
            CheckTeamDone();
        }

        private void CheckTeamDone()
        {
            //
            //if(_teamId ==null)
            //{
            //    // khác examing (có thể là done)
            //}
            if ((new BLL()).TeamIsDone(_teamId))
            {
                if (_tmrCheckCauhoi != null)
                    _tmrCheckCauhoi.Stop();
                Close();
            }
        }

        protected override void Close()
        {
            this._view.Hide();
            this._view.Close();
            this._view.Dispose();
            //
            if (_tmrCheckCauhoi != null)
                this._tmrCheckCauhoi.Stop();
            if (_tmrWaitForDoneRound1 != null)
                this._tmrWaitForDoneRound1.Stop();

            this._tmrCheckCauhoi = null;
            this._tmrWaitForDoneRound1 = null;
        }


        private void UpdateView(Question nextQues, bool isShownAnswerkey)
        {
            //throw new NotImplementedException();

            if (_view is V_MC_Vong1)
            {
                V_MC_Vong1 myView = _view as V_MC_Vong1;
                if (nextQues == null)// het cau hoi vong nay
                {
                    return;

                    ////
                    ///


                }
                if (nextQues is Compound)
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

                myView.QuestionNumText = nextQues.STT;
                try
                {
                    myView.AnswerKey = nextQues.AnswerKey;
                }
                catch
                {

                }
            }
        }
    }

    public class MC_Start_Controller: MC_Controller
    {
        private Timer _tmrVong;

        public MC_Start_Controller(V_Start v) : base(v)
        {
            v.Load += V_Load;
        }

        private void V_Load(object sender, EventArgs e)
        {
            //if (_view is V_Start)
            //{
            //    (_view as V_Start).LblFullScreen_Click(null, EventArgs.Empty);
            //}
            _tmrVong = new Timer();
            _tmrVong.Interval = 500;
            _tmrVong.Start();
            _tmrVong.Tick += _tmrVong_Tick;

            //

        }

        private void _tmrVong_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string kq = (new BLL()).GetVongDangThi();
            if (kq == "0" || kq == null)
                return;
            if (kq == "1")
            {
                _tmrVong.Stop();
                App app1 = new App(new V_MC_Vong1());
                ///
                app1.Load();
                _tmrVong.Start();
            }
            else if (kq == "3")
            {
                _tmrVong.Stop();
                App app1 = new App(new V_MC_Vong3());
                app1.Load();
                _tmrVong.Start();
            }
        }
    }

    public class MC_Vong3_Controller : MC_Controller
    {
        private Timer _tmrCheckCauhoi;
        private bool _tmrCheckIsStopped = true;
        private Timer _tmrWaitForDoneRound1;
        private Timer _tmrShowKey;
        private bool _getQuestionIsDone = false;
        public MC_Vong3_Controller(V_MC_Vong3 v) : base(v)
        {
            v.Load += V_Load;
        }

        private void V_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            GetTeams();
            //

            _tmrCheckCauhoi = new Timer();
            _tmrCheckCauhoi.Interval = 300;
            _tmrCheckCauhoi.Start();
            _tmrCheckIsStopped = false;
            _tmrCheckCauhoi.Tick += _tmrCheckCauhoi_Tick;

            //_tmrShowKey = new Timer();
            //_tmrShowKey.Interval = 1000;
            //_tmrShowKey.Start();
            //_tmrShowKey.Tick += _tmrShowKey_Tick;
        }

        //private void _tmrShowKey_Tick(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    CommandGotten cmdGotten = (new BLL()).GetCommandFromIT();
        //    if (cmdGotten != null)
        //    {
        //        if (cmdGotten.Type == "inForm" && cmdGotten.Conntent == "showKey")
        //        {
        //            if (_view is V_LED_Vong3)
        //            {
        //                (_view as V_LED_Vong3).KeyIsShown = true;
        //                _tmrCheckCauhoi.Stop();
        //                _tmrCheckIsStopped = true;
        //            }
        //        }
        //        else if (cmdGotten.Type == "auto" && (cmdGotten.Conntent == "" || cmdGotten == null))
        //        {
        //            if (_tmrCheckIsStopped)
        //            {
        //                _tmrCheckCauhoi.Start();
        //                _tmrCheckIsStopped = false;
        //            }

        //        }
        //    }

        //}

        private List<PointScreen.Model.Team> teams;
        public void GetTeams()
        {
            if (!(_view is V_MC_Vong3))
                return;
            //int year = DateTime.UtcNow.Year;

            teams = (new BLL()).GetTeams();
            V_MC_Vong3 view = _view as V_MC_Vong3;

            if (teams != null && teams.Count != 0)
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



        private void _tmrCheckCauhoi_Tick(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            GetTeams();
            GetNextQuestion();
        }
        Question _nextQuestion = new Question();
        private void GetNextQuestion()
        {
            //throw new NotImplementedException();
            Question ques = (new BLL()).GetNextQuestion(_nextQuestion.Id);
            if (ques == null)// cau 10 done
            {
                this.Close();
                return;
            }
            _nextQuestion = ques;
            if (_nextQuestion != null)
            {
                //sắp xong
                if (_view is V_MC_Vong3)
                {
                    V_MC_Vong3 view = _view as V_MC_Vong3;
                    view.QuestionNumText = _nextQuestion.STT;
                    view.QuestionContent = _nextQuestion.QuestionContentToString();
                    view.AnswerKey = _nextQuestion.AnswerKey;
                    //view.KeyIsShown = false;
                    //if (_nextQuestion.Image64String != null && _nextQuestion.Image64String != "")
                    //view.QuestionImg = Image.FromStream(new MemoryStream(Convert.FromBase64String(_nextQuestion.Image64String)));



                }
            }
            _nextQuestion = new Question();
        }

    }
}
