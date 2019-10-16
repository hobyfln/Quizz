using Quizz;
using Quizz.Services.Interfaces;
using Quizz.Services.Services;
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
            var ServiceProvider = new CandidateService();
            ServiceProvider.AddCandidate();
        }



    }
}
