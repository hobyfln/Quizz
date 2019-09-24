using Quizz;
using Quizz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestQuizConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CandidateService ServiceProvider = new CandidateService();
            List<object> ListCandidates = new List<object>();

            Candidate newCandidate = new Candidate(20, "Joe Doe", 24, "C#", 2);
            ListCandidates.Add(newCandidate);
            ServiceProvider.GetCandidates(ListCandidates);
            Console.ReadKey();


        }



    }
}
