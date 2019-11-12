using Quizz.Domain.ViewModels;
using Quizz.Entities;
using Quizz.Repository.QuizzRepo;
using Quizz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Services.Services
{
    public class QuizzServices : IQuizzService
    {
        public void SaveQuizz()
        {
            throw new NotImplementedException();
        }
        //Suppression d'un Quizz
        public void DeleteQuizz()
        {
            throw new NotImplementedException();
        }
        //Edition du Quizz généré - Facultatif
        public void EditQuizz()
        {
            throw new NotImplementedException();
        }

        //Cloture du Quizz
        public void CloseQuizz()
        {
            throw new NotImplementedException();
        }

        //Retourne la liste des Quizz
        public void GetQuizzList(List<Quizz> ListQuizz)
        {
            foreach (Quizz quizz in ListQuizz)
            {
                Console.WriteLine("Candidate ID: " + quizz.QuizzCandidateId);
                Console.WriteLine("Quizz ID: " + quizz.QuizzId);
                Console.WriteLine("**********");
            }
        }

        public void GenerateQuizz(QuizzAddViewModel model)
        {
            var quizzManager = new QuizzManager();
            quizzManager.Create(model);
        }

        public void GetQuestions(int nbQuestions, int skillId, int technoId)
        {
            Random rnd = new Random();

            using (var ctx = new QuizzContext())
            {
                List<Question> questions = ctx.Questions
                    .Where(q => q.QuestionSkillId.SkillLevelId == skillId && q.QuestionTechnoId.TechnologieId == technoId)
                    .ToList();

                for (int i = 0; i < nbQuestions; i++)
                {
                    int questionSelected = rnd.Next(0, questions.Count());
                    questions.ElementAt(questionSelected);
                }
            }
        }
    }
}
