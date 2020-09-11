using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using DatabaseHandle.Model;
//using static LED.Program;
using static LED.LED_Model;
using static PointScreen.Model;

namespace LED
{
    public class LED_Controller
    {
        protected View _view;
        private Timer _tmrLogin;
        private bool connectionProblemState = false;

        public LED_Controller(View view)
        {
            this._view = view;
            _tmrLogin = new Timer();
            _tmrLogin.Interval = 1000;
            _tmrLogin.Start();
            _tmrLogin.Tick += _tmrLogin_Tick;
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

        internal void LoadView()
        {
            //throw new NotImplementedException();
            _view.ShowDialog();
            //

        }
        internal void LoadView(Form frmParent)
        {
            try
            {
                //LIB.MakeFullScreen(_view, frmParent);
                //_view.Graphicialize();
                //_view.ResizeControls();
                //_view.RelocatingControls();

                if (_view is V_LED_Vong3)
                {
                    (_view as V_LED_Vong3).LblFullScreen_Click(null, EventArgs.Empty);
                }
                if (_view is V_Led_Vong1)
                {
                    (_view as V_Led_Vong1).LblFullScreen_Click(null, EventArgs.Empty);
                }
                if (_view is V_LED_HienDiem)
                {
                    (_view as V_LED_HienDiem).LblFullScreen_Click(null, EventArgs.Empty);
                }
                _view.ShowDialog();
            }
            catch
            {
                throw;
            }

        }

        private void _tmrLogin_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CheckConnection();
        }

        internal void CheckConnection()
        {
            //throw new NotImplementedException();
            if (!((new BLL()).CheckConnection() == 1))
            {
                if (connectionProblemState == false)
                {
                    MessageBox.Show("Connection Problem"); // sua lai bang Icon
                    connectionProblemState = true;
                }
            }
            else
            {
                connectionProblemState = false;
            }
        }
    }
    public class LED_Start_Controller : LED_Controller
    {
        private Timer _tmrVong;

        public LED_Start_Controller(V_Start v) : base(v)
        {
            v.Load += V_Load;
        }

        private void V_Load(object sender, EventArgs e)
        {
            if (_view is V_Start)
            {
                (_view as V_Start).LblFullScreen_Click(null, EventArgs.Empty);
            }
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
                App app1 = new App(new V_Led_Vong1());
                app1.Load(this._view);
                _tmrVong.Start();
            }
            else if (kq == "3")
            {
                _tmrVong.Stop();
                App app1 = new App(new V_LED_Vong3());
                app1.Load(this._view);
                _tmrVong.Start();
            }
        }

        //int _demVong1 = 0;
        //private void _tmrVong1_Tick(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    //cho den examing roi chuyen qua man hinh tiep theo
        //    string kq = (new BLL()).GetTeamIdExaming();
        //    if (kq != null) 
        //    {
        //        //_tmrVong1.Stop();
        //        App app1 = new App(new V_Led_Vong1());
        //        app1.Load();
        //        //
        //        //throw new NotImplementedException();
        //        _demVong1++;
        //        //if(_demVong1 < 4)
        //         //   _tmrVong1.Start();

        //    }
        //    else if (kq == null && _demVong1 == 3)
        //    {
        //       // _tmrVong1.Stop();

        //       // _tmrVong3 = new Timer();
        //      //  _tmrVong3.Interval = 500;
        //      //  _tmrVong3.Start();
        //       // _tmrVong3.Tick += _tmrVong3_Tick;
        //     //   
        //    }

        //}

        //private void _tmrVong3_Tick(object sender, EventArgs e)
        //{
        //    if((new BLL()).CheckVong3Ready())
        //    {
        //     //   _tmrVong3.Stop();
        //        App app3 = new App(new V_LED_Vong3());
        //        app3.Load(this._view);
        //    }

        //}
    }
    public class LED_Vong1_Controller : LED_Controller
    {
        private Timer _tmrCheckCauhoi;
        private Timer _tmrWaitForDoneRound1;
        private bool _getQuestionIsDone = false;
        public LED_Vong1_Controller(View v) : base(v)
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
                //
                if (nextQues.STT == "1")
                {
                    (_view as V_Led_Vong1).StartCountEnabled = true;
                }
                //
                _preQuestion = nextQues;
            }
            else if (nextQues != null && _preQuestion.Id != nextQues.Id)
            {
                UpdateView(nextQues, true);
                if (nextQues.STT == "1")
                {
                    (_view as V_Led_Vong1).StartCountEnabled = true;
                }
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
                ///
                //hien diem cho nay
                if (_view is V_Led_Vong1)
                {
                    V_Led_Vong1 view = _view as V_Led_Vong1;


                }
                ///
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

            if (_view is V_Led_Vong1)
            {
                V_Led_Vong1 myView = _view as V_Led_Vong1;
                if (nextQues == null)// het cau hoi vong nay
                {
                    return;

                    ////
                    ///


                }
                if (nextQues.ImageRelativePath == null || nextQues.ImageRelativePath == "")
                {
                    //throw new NotImplementedException();'
                    if (nextQues is Compound)
                    {
                        Compound ques = nextQues as Compound;
                        myView.QuestionText = ques.QuestionContent;
                        myView.QuestionMaybeAnswer = "A." + ques.ChoiceA + "\nB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\nD." + ques.ChoiceD;
                    }
                    else if (nextQues is Multiple_Choice)
                    {
                        Multiple_Choice ques = nextQues as Multiple_Choice;
                        myView.QuestionText = ques.QuestionContent;
                        myView.QuestionMaybeAnswer = "A." + ques.ChoiceA + "\nB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\nD." + ques.ChoiceD;
                        myView.ShowABCD = true;

                    }
                    else if (nextQues is Fill_In)
                    {
                        Fill_In ques = nextQues as Fill_In;
                        myView.QuestionText = ques.QuestionContent.Replace("NNN", "...");
                        myView.ShowABCD = false;
                    }
                    else
                    {
                        myView.QuestionText = nextQues.QuestionContent;
                        myView.ShowABCD = false;
                    }

                    myView.ShowPic = false;
                    myView.QuestionNumText = nextQues.STT;

                    //if (isShownAnswerkey)
                    //{
                    //    try
                    //    {
                    //        myView.AnswerKey = _preQuestion.AnswerKey;
                    //    }
                    //    catch
                    //    {

                    //    }
                    //    _tmrCheckCauhoi.Stop();

                    //    Timer tmrDung = new Timer();
                    //    tmrDung.Enabled = true;
                    //    //
                    //    if (myView.AnswerKey.Length < 10)
                    //        tmrDung.Interval = 1000;
                    //    else
                    //        tmrDung.Interval = 2000;
                    //    tmrDung.Start();
                    //    tmrDung.Tick += delegate (object send, EventArgs ev)
                    //    {
                    //        //

                    //        V_Load(null, EventArgs.Empty);

                    //        //_tmrCheckCauhoi.Start();

                    //        myView.AnswerKey = "";
                    //        tmrDung.Stop();
                    //        tmrDung.Dispose();
                    //    };


                    //}
                    //else
                    //{
                    //    myView.AnswerKey = "";
                    //}

                    myView.RelocatingAndResizingControls("nohinh");
                }

                else

                {
                    try
                    {
                        myView.Pic = Image.FromFile(Application.StartupPath + nextQues.ImageRelativePath);
                    }

                    finally
                    {

                        if (nextQues is Compound)
                        {
                            Compound ques = nextQues as Compound;
                            myView.QuestionText = ques.QuestionContent;
                            myView.QuestionMaybeAnswer = "A." + ques.ChoiceA + "\nB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\nD." + ques.ChoiceD;
                        }
                        else if (nextQues is Multiple_Choice)
                        {
                            Multiple_Choice ques = nextQues as Multiple_Choice;
                            myView.QuestionText = ques.QuestionContent;
                            myView.QuestionMaybeAnswer = "A." + ques.ChoiceA + "\nB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\nD." + ques.ChoiceD;
                            myView.ShowABCD = true;

                        }
                        else if (nextQues is Fill_In)
                        {
                            Fill_In ques = nextQues as Fill_In;
                            myView.QuestionText = ques.QuestionContent.Replace("NNN", "...");
                            myView.ShowABCD = false;
                        }
                        else
                        {
                            myView.QuestionText = nextQues.QuestionContent;
                            myView.ShowABCD = false;
                        }

                        myView.ShowPic = true;
                        myView.QuestionNumText = nextQues.STT;

                        myView.RelocatingAndResizingControls("hinh");
                    }



                }

            }
        }
    }
    public class LED_HienDiem_Controller : LED_Controller
    {
        public LED_HienDiem_Controller(View v) : base(v)
        {
            v.Load += V_Load;
            _tmrVong = new Timer();
            _tmrVong.Interval = 500;
            _tmrVong.Start();
            _tmrVong.Tick += _tmrVong_Tick;
        }
        private void V_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
            //


        }
        List<Team> teams = null;
        public void GetTeams()
        {
            if (!(_view is V_LED_HienDiem))
                return;
            //int year = DateTime.UtcNow.Year;

            teams = (new BLL()).GetTeams();
            V_LED_HienDiem view = _view as V_LED_HienDiem;


            Team maxTeam = teams.FirstOrDefault(t => t.Score == teams.Max(x => x.Score));
            if(maxTeam!=null)
            {
                view.TenDoiNhat = maxTeam.Name;
                view.DiemDoiNhat = maxTeam.Score + "";
            }

            Team minTeam = teams.LastOrDefault(t => t.Score == teams.Min(x => x.Score));
            if (minTeam != null)
            {
                view.TenDoiBa = minTeam.Name;
                view.DiemDoiBa = minTeam.Score + "";
            }

            Team Nhi = teams.FirstOrDefault(x => x.ID != maxTeam.ID && x.ID != minTeam.ID);
            if(Nhi!=null)
            {
                view.TenDoiNhi = Nhi.Name;
                view.DiemDoiNhi = Nhi.Score + "";
            }



        }
        Timer _tmrVong;

        private void _tmrVong_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            GetTeams();
        }


    }
    public class LED_Vong3_Controller : LED_Controller
    {
        private Timer _tmrCheckCauhoi;
        private bool _tmrCheckIsStopped = true;
        private Timer _tmrWaitForDoneRound1;
        private Timer _tmrShowKey;
        private bool _getQuestionIsDone = false;
        public LED_Vong3_Controller(View v) : base(v)
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

            _tmrShowKey = new Timer();
            _tmrShowKey.Interval = 1000;
            _tmrShowKey.Start();
            _tmrShowKey.Tick += _tmrShowKey_Tick;
        }

        private void _tmrShowKey_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CommandGotten cmdGotten = (new BLL()).GetCommandFromIT();
            if (cmdGotten != null)
            {
                if (cmdGotten.Type == "inForm" && cmdGotten.Conntent == "showKey")
                {
                    if (_view is V_LED_Vong3)
                    {
                        (_view as V_LED_Vong3).KeyIsShown = true;
                        _tmrCheckCauhoi.Stop();
                        _tmrCheckIsStopped = true;
                    }
                }
                else if (cmdGotten.Type == "auto" && (cmdGotten.Conntent == "" || cmdGotten == null))
                {
                    if (_tmrCheckIsStopped)
                    {
                        _tmrCheckCauhoi.Start();
                        _tmrCheckIsStopped = false;
                    }

                }
            }

        }

        private List<PointScreen.Model.Team> teams;
        public void GetTeams()
        {
            if (!(_view is V_LED_Vong3))
                return;
            //int year = DateTime.UtcNow.Year;

            teams = (new BLL()).GetTeams();
            V_LED_Vong3 view = _view as V_LED_Vong3;

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
                if (_view is V_LED_Vong3)
                {
                    V_LED_Vong3 view = _view as V_LED_Vong3;
                    view.STT = _nextQuestion.STT;
                    view.QuestionContent = _nextQuestion.QuestionContentToString();
                    view.AnswerKey = _nextQuestion.AnswerKey;
                    view.KeyIsShown = false;
                    //if (_nextQuestion.Image64String != null && _nextQuestion.Image64String != "")
                    //view.QuestionImg = Image.FromStream(new MemoryStream(Convert.FromBase64String(_nextQuestion.Image64String)));



                }
            }
            _nextQuestion = new Question();
        }


    }
}
