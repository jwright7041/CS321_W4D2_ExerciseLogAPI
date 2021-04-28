using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeRepository
    {
        ActivityType Add(ActivityType activityType);
        ActivityType Get(int id);
        ActivityType Update(ActivityType activityType);
        void Remove(ActivityType activityType);
        IEnumerable<ActivityType> GetAll();
    }
}
