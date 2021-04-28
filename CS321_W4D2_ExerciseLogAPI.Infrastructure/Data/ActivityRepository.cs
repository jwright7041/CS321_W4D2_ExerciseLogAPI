using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _appDbContext;

        public ActivityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Activity Add(Activity activity)
        {
            _appDbContext.Activities.Add(activity);
            _appDbContext.SaveChanges();

            return activity;
        }

        public Activity Get(int id)
        {
            return _appDbContext.Activities.Find(id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _appDbContext.Activities.ToList();
        }

        public void Remove(Activity activity)
        {
            _appDbContext.Activities.Remove(activity);
            _appDbContext.SaveChanges();
        }

        public Activity Update(Activity activity)
        {
            var current = Get(activity.Id);

            if (current == null)
                return null;

            _appDbContext.Entry(current)
                .CurrentValues
                .SetValues(activity);

            _appDbContext.SaveChanges();

            return current;
        }
    }
}
