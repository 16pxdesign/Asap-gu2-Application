using System.Collections.Generic;
using Application.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Application.Repo.Contracts
{
    public interface ITrainingRepository
    {
        List<Training> GetListOfTrainings();
        List<SelectListItem> GetListOfCoaches();
        void AddUpdateTraining(Training training, List<Activities> list);
        Training GetTraining(int id);
        void InsertUpdateAttendance(Training save, string[] Ids);
    }
}