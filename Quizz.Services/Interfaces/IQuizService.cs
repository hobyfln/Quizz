using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizz.Domain.ViewModels;
using Quizz.ViewModels;

namespace Quizz.Services.Interfaces
{
    public interface IQuizzService
    {
        void GenerateQuizz(QuizzAddViewModels model);
        void SaveQuizz();
        void DeleteQuizz();
        void EditQuizz();
        void CloseQuizz();
        void GetQuizzList(List<Quizz> ListQuizz);
    }
}
