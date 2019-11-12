using Quizz.Entities;
using Quizz.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Services.Services
{
    public class CandidateService : ICandidateService
    {
        public void AddCandidate()
        {
            string name = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            string mail = Console.ReadLine();
            int skilllevel = Int32.Parse(Console.ReadLine());
            string techno = Console.ReadLine();
            DateTime createdon = DateTime.Now;
            string createdby = "Test1";
            DateTime modifiedon = DateTime.Now;
            string modifiedby = "Test1";


            using (var ctx = new QuizzContext())
            {
                var candidate = new Candidate() { Name = name, Age = age, Mail = mail, SkillLevel=skilllevel, Techno=techno, CreatedOn=createdon,CreatedBy=createdby,ModifiedBy=modifiedby,ModifiedOn=modifiedon };
                ctx.Candidates.Add(candidate);
                ctx.SaveChanges();

                var query = ctx.Candidates.ToList();

                //foreach(var candidates in query)
                //{
                //    foreach (var item in candidates) ;
                //}
                //Console.ReadLine();
            }
        }

        public void DeleteCandidate(int id)
        {
            using (var ctx = new QuizzContext())
            {
                ctx.Candidates.Remove(ctx.Candidates.Single(c => c.QuizzCandidateId == id));
                ctx.SaveChanges();
            }
        }

        public void EditCandidate(int id)
        {
                using (var ctx = new QuizzContext())
            {
                var query = ctx.Candidates
                                .Where(c => c.QuizzCandidateId == id);
                                
                    
            }

        }

        public void GetCandidates()
        {
            using (var ctx = new QuizzContext())
            {
                var candidates = ctx.Candidates;
                candidates.ToList();
                foreach(Candidate candidate in candidates)
                {
                    Console.WriteLine(candidate);
                }
            }
        }
    }
}
