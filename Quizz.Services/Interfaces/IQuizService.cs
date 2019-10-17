using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Services.Interfaces
{
    public interface IQuizzService
    {
        void GenerateQuizz();
        void SaveQuizz();
        void DeleteQuizz();
        void EditQuizz();
        void CloseQuizz();
        void GetQuizzList(List<QuizzClass> ListQuizz);
    }
}
