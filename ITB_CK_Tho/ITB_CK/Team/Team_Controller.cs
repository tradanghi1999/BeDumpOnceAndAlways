using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;
using PointScreen;
using System.Configuration;
//
using DatabaseHandle.Model;
namespace Team
{
    public class Team_Controller
    {
        protected View _view;
        private Timer _tmrLogin;
        private bool connectionProblemState = false;
        private Model.Team _team;
        //private event EventHandler _round1StateChanged;
        //private event EventHandler _round2StateChanged;
        //private event EventHandler _round3StateChanged;
        public Team_Controller(View view)
        {
            this._view = view;
            _tmrLogin = new Timer();
            _tmrLogin.Interval = 300;
            _tmrLogin.Start();
            _tmrLogin.Tick += _tmrLogin_Tick;

            //_round1StateChanged += Team_Controller__round1StateChanged;
            //_round2StateChanged += Team_Controller__round2StateChanged;
            //_round3StateChanged += Team_Controller__round3StateChanged;
        }

        //private void Team_Controller__round3StateChanged()
        //{
        //    RoundChanged(3);
        //}

        //private void Team_Controller__round2StateChanged()
        //{
        //    RoundChanged(2);
        //}

        //private void Team_Controller__round1StateChanged()
        //{
        //    //throw new NotImplementedException();
        //    RoundChanged(1);
        //}

        private void _tmrLogin_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CheckConnection();
        }

        internal void LoadView()
        {
            //throw new NotImplementedException();
            _view.ShowDialog();
        }
        internal void CheckConnection()
        {
            //throw new NotImplementedException();
            if (!((new BLL()).CheckConnection() == 1))
            {
                if(connectionProblemState == false)
                {
                    MessageBox.Show("Connection Problem");
                    connectionProblemState = true;
                }
            }
            else
            {
                connectionProblemState = false;
            }
                
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

        void CheckTeam()
        {
            Model.Team team = (new PointScreen.DAL()).GetTeam(ConfigurationManager.ConnectionStrings["teamID"].ConnectionString);
            if (team == null)
            {
                throw new Exception();
            }
            if (_team !=null)
            {
                if (_team.Round1State != team.Round1State)
                    RoundChanged(1, _team.Round1State, team.Round1State);
                if (_team.Round2State != team.Round2State)
                    RoundChanged(2, _team.Round2State, team.Round2State);
                if (_team.Round3State != team.Round3State)
                    RoundChanged(3, _team.Round3State, team.Round3State);
            }

            _team = team;
        }

        private void RoundChanged(int round, string stateBefore, string stateAfter)
        {

            if(round ==1)
            {
                if(stateBefore =="yet" && stateAfter == "pending")
                {
                    UpdateRound1PendingView();
                }
            }
            else if (round ==2)
            {
                throw new NotImplementedException();
            }
            else if(round ==3)
            {
                throw new NotImplementedException();
            }
            UpdateView();
        }

        private void UpdateView()
        {
            
        }
        private void UpdateRound1PendingView()
        {

        }
    }
    public class Team_Start_Controller : Team_Controller
    {
        private Timer _tmrVong1;
        private Timer _tmrVong2;
        private Timer _tmrVong3;
        public Team_Start_Controller(V_Start view):base(view)
        {
            view.Load += View_Load;
        }

        private void View_Load(object sender, EventArgs e)
        {
            _tmrVong1 = new Timer();
            _tmrVong1.Interval = 500;
            _tmrVong1.Start();
            _tmrVong1.Tick += _tmrVong1_Tick;
        }

        private void _tmrVong1_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string kq = (new BLL()).GetTeamIdExaming();
            if (kq != null)
            {
                _tmrVong1.Stop();
                App app = new App(new V_Vong1_Thi());
                app.Load();
                ////Sau đây là nó bắt đầu chạy tiếp --- _tmr Start ổn
                //throw new NotImplementedException();
                _tmrVong1.Start();
            }
        }
    }
    public class Team_Vong1_Controller : Team_Controller
    {

        private Timer _tmrCheckCauhoi;
        private Timer _tmrWaitForDoneRound1;
        private bool _getQuestionIsDone = false;
        public Team_Vong1_Controller(View v):base(v)
        {
            v.Load += V_Load;
        }

        private void V_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            _tmrCheckCauhoi = new Timer();
            _tmrCheckCauhoi.Interval = 300;
            _tmrCheckCauhoi.Start();
            _tmrCheckCauhoi.Tick += _tmrCheckCauhoi_Tick;

            _tmrWaitForDoneRound1 = new Timer();
            _tmrWaitForDoneRound1.Interval = 500;
            _tmrWaitForDoneRound1.Start();
            _tmrWaitForDoneRound1.Tick += _tmrWaitForDoneRound1_Tick;

        }
        private string _teamId = null;
        private void _tmrCheckCauhoi_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //GetNextQuestion();
            CheckTeamExaming();
        }
        private void CheckTeamExaming()
        {
            _teamId = (new BLL()).GetTeamIdExaming();
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
                //if(_getQuestionIsDone)
                //{
                //    return;
                //}
                //_getQuestionIsDone = true;
                ////done --- nhung o get dc gi thoi (xong nhung chua het gio)
                //_tmrWaitForDoneRound1 = new Timer();
                //_tmrWaitForDoneRound1.Interval = 500;
                //_tmrWaitForDoneRound1.Start();
                //_tmrWaitForDoneRound1.Tick += _tmrWaitForDoneRound1_Tick;
            }


        }

        private void _tmrWaitForDoneRound1_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CheckTeamDone();
        }

        private void CheckTeamDone()
        {
            //
            if((new BLL()).TeamIsDone(_teamId))
            {
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
            this._tmrCheckCauhoi.Stop();
            this._tmrWaitForDoneRound1.Stop();
            this._tmrCheckCauhoi = null;
            this._tmrWaitForDoneRound1 = null;
        }

        private void UpdateView(Question nextQues, bool isShownAnswerkey)
        {
            //throw new NotImplementedException();

            if (_view is V_Vong1_Thi)
            {
                V_Vong1_Thi myView = _view as V_Vong1_Thi;
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

                if (isShownAnswerkey)
                {
                    try
                    {
                        myView.AnswerKey = _preQuestion.AnswerKey;
                    }
                    catch
                    {

                    }
                    _tmrCheckCauhoi.Stop();

                    Timer tmrDung = new Timer();
                    tmrDung.Enabled = true;
                    //
                    if (myView.AnswerKey.Length < 10)
                        tmrDung.Interval = 1000;
                    else
                        tmrDung.Interval = 2000;
                    tmrDung.Start();
                    tmrDung.Tick += delegate (object send, EventArgs ev)
                    {
                        _tmrCheckCauhoi.Start();
                        myView.AnswerKey = "";
                        tmrDung.Stop();
                        tmrDung.Dispose();
                    };
                }
                else
                {
                    myView.AnswerKey = "";
                }
            }
        }
    }
}
