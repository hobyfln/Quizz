using Quizz.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizz.Entities;

namespace Quizz.Repository.QuizzRepo
{
    public class QuizzManager
    {
        public void Create(QuizzAddViewModel model)
        {
            using (var ctx = new QuizzContext())
            {

                Quizz quizz = new Quizz()
                {
                    CreatedBy = model.CreatedBy,
                    CreatedOn = model.CreatedOn,

                    ModifiedBy = model.ModifiedBy,
                    ModifiedOn = model.ModifiedOn,

                    QuizzQuestions = model.QuizzQuestions,

                    QuizzCandidate = new Candidate()
                    {
                        Name = model.CandidateName,
                        Age = model.CandidateAge,
                        Mail = model.CandidateMail,
                    },

                    QuizzSkillLevel = model.QuizzSkillLevel,
                    QuizzTechno = model.QuizzTechno,
                    QuizzUser = model.QuizzUser

                };

                ctx.Quizzs.Add(quizz);
                ctx.SaveChanges();
            }
        }
    }
}
