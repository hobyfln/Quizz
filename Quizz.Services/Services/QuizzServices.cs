using Quizz.Domain.ViewModels;
using Quizz.Entities;
using Quizz.Repository.QuizzRepo;
using Quizz.Services.Interfaces;
using Quizz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Services.Services
{
    public class QuizzServices : IQuizzService
    {
        //Génération d'un Quizz
        //public void GenerateQuizz()
        //{
        //    using (var ctx = new QuizzContext())
        //    {
        //        var quizz = new Quizz() {, CreatedOn = createdon, CreatedBy = createdby, ModifiedBy = modifiedby, ModifiedOn = modifiedon };
        //        ctx.Quizzs.Add(quizz);
        //        ctx.SaveChanges();

        //        var query = ctx.Candidates.ToList();
        //    }
        //}
        //Sauvegarde d'un Quizz dans la Db
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

        public void GenerateQuizz(QuizzAddViewModels model)
        {
            var quizzManager = new QuizzManager();
            quizzManager.Create(model);
        }
        
    }

}