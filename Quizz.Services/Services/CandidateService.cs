using Quizz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class CandidateService : ICandidateService
    {


        public void DeleteCandidate()
        {
            throw new NotImplementedException();
        }

        public void EditCandidate()
        {
            throw new NotImplementedException();
        }

        public void GetCandidates(List<Candidate> ListCandidates)
        {
            foreach (Candidate candidate in ListCandidates)
            {
                Console.WriteLine("ID: " + candidate.CandidateId);
                Console.WriteLine("Name: " + candidate.Name);
                Console.WriteLine("Age: " + candidate.Age);
                Console.WriteLine("Techno: " + candidate.Techno);
                Console.WriteLine("Level: " + candidate.SkillLevel);
                Console.WriteLine("**********");
            }
        }
    }
}
