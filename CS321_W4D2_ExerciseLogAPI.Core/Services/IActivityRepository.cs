using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityRepository
    {
        Activity Add(Activity activity);
        Activity Get(int id);
        Activity Update(Activity activity);
        void Remove(Activity activity);
        IEnumerable<Activity> GetAll();
    }
}
