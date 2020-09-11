using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandle.Model
{
    
    public partial class Question
    {
        public string QuestionContent { get; set; }
        public int Score { get; set; }
        public string AnswerKey { get; set; }
        public Question()
        {

        }
        public static Question CreateNewQuestion(string type)
        {
            if(type.Contains("Multiple Choice"))
            {
                return new Multiple_Choice(); 
            }
            else
            {
                if (type.Contains("True False"))
                    return new True_False();
                else
                {
                    if (type.Contains("Fill in"))
                        return new Fill_In();
                    else
                    {
                        if (type.Contains("Compound"))
                            return new Compound();
                        else
                        {
                            if (type.Contains("Fast"))
                                return new Fast();
                            else
                                return null;
                        }
                    }
                }
                    
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
