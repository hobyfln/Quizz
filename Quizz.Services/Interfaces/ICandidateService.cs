using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quizz.Services.Interfaces
{
    public interface ICandidateService
    {
        void DeleteCandidate();
        void EditCandidate();
        void GetCandidates(List<Candidate> ListCandidates);
         
    }
}
