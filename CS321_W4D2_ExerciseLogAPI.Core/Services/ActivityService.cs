using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activity)
        {
            _activityRepository = activity;
        }

        public Activity Add(Activity activity)
        {
            return _activityRepository.Add(activity);
        }

        public Activity Get(int id)
        {
            return _activityRepository.Get(id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activityRepository.GetAll();
        }

        public Activity Update(Activity activity)
        {
            return _activityRepository.Update(activity);
        }

        public void Remove(Activity activity)
        {
            _activityRepository.Remove(activity);
        }
    }
}
