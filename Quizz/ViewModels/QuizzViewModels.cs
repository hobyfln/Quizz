using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Domain.ViewModels
{
    public class QuizzAddViewModel
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn = DateTime.Now;

        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn = DateTime.Now;

        //TO-DO Select question Method
        public QuizzLinkQuestions QuizzQuestions = new QuizzLinkQuestions()
        {
            Question = new Question()
        };

        public string CandidateName { get; set; }
        public int CandidateAge { get; set; }
        public string CandidateMail { get; set; }

        //TO-DO Select Candidate Method + If no candidate create method
        //TO-DO Select SkillLevel Method
        public SkillLevel QuizzSkillLevel = new SkillLevel();
        //TO-DO Select Techno Method
        public Technology QuizzTechno = new Technology();
        //TO-DO Select User Method
        public User QuizzUser = new User();
    }
}
