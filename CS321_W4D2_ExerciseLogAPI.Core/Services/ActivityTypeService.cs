using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeService
    {
        private readonly IActivityTypeRepository _activityTypeRepository;

        public ActivityTypeService(IActivityTypeRepository activityType)
        {
            _activityTypeRepository = activityType;
        }

        public ActivityType Add(ActivityType activityType)
        {
            return _activityTypeRepository.Add(activityType);
        }

        public ActivityType Get(int id)
        {
            return _activityTypeRepository.Get(id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepository.GetAll();
        }

        public ActivityType Update(ActivityType activityType)
        {
            return _activityTypeRepository.Update(activityType);
        }

        public void Remove(ActivityType activityType)
        {
            _activityTypeRepository.Remove(activityType);
        }
    }
}
