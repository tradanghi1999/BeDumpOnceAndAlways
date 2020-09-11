using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandle.Model
{
    
    public partial class Question
    {
        public string Id { get; set; }
        // bo sung do tinh can thiet cua Them STT vao Giao Dien
        public string STT { get; set; }
        //

        public string QuestionContent { get; set; }
        public int Score { get; set; }
        public string AnswerKey { get; set; }
        public string Image64String { get; set; }
        public string ImageRelativePath { get; set; }
        public Question()
        {

        }
        public static Question CreateNewQuestion(string type)
        {
            if(type.Contains("Multiple Choice") || type.Contains("mc"))
            {
                return new Multiple_Choice(); 
            }
            else
            {
                if (type.Contains("True False") || type.Contains("tf"))
                    return new True_False();
                else
                {
                    if (type.Contains("Fill in") || type.Contains("fi"))
                        return new Fill_In();
                    else
                    {
                        if (type.Contains("Compound") || type.Contains("cp"))
                            return new Compound();
                        else
                        {
                            if (type.Contains("Fast") || type.Contains("fs"))
                                return new Fast();
                            else
                                return null;
                        }
                    }
                }
                    
            }
        }

        public string QuestionContentToString()
        {
            if (this is Compound)
            {
                Compound ques = this as Compound;
                return ques.QuestionContent + "\nA." + ques.ChoiceA + "\tB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\tD." + ques.ChoiceD;
            }
            else if (this is Multiple_Choice)
            {
                Multiple_Choice ques = this as Multiple_Choice;
                return ques.QuestionContent + "\nA." + ques.ChoiceA + "\tB." + ques.ChoiceB + "\nC." + ques.ChoiceC + "\tD." + ques.ChoiceD;
            }
            else if (this is Fill_In)
            {
                Fill_In ques = this as Fill_In;
                return ques.QuestionContent.Replace("NNN", "...");
            }
            else
            {
                return this.QuestionContent;
            }
        }
    }
    public class Multiple_Choice : Question
    {
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
       
    }

}
