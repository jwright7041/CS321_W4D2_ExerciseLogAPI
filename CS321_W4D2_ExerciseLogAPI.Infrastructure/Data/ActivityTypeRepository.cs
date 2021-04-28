using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDbContext _appDbContext;

        public ActivityTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ActivityType Add(ActivityType activityType)
        {
            _appDbContext.ActivityTypes.Add(activityType);
            _appDbContext.SaveChanges();

            return activityType;
        }

        public ActivityType Get(int id)
        {
            return _appDbContext.ActivityTypes.Find(id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _appDbContext.ActivityTypes.ToList();
        }

        public void Remove(ActivityType activityType)
        {
            _appDbContext.ActivityTypes.Remove(activityType);
            _appDbContext.SaveChanges();
        }

        public ActivityType Update(ActivityType activityType)
        {
            var current = Get(activityType.Id);

            if (current == null)
                return null;

            _appDbContext.Entry(current)
                .CurrentValues
                .SetValues(activityType);

            _appDbContext.SaveChanges();

            return current;
        }
    }
}
