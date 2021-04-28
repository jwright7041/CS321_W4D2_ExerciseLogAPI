using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public static class UserMappingExtenstions
    {

        public static UserModel ToApiModel(this User user)
        {
            return new UserModel
            {
                Id = user.Id,
                Name = user.Name,
                Activities = user.Activities.ToApiModels().ToList()
            };
        }

        public static User ToDomainModel(this UserModel userModel)
        {
            return new User
            {
                Id = userModel.Id,
                Name = userModel.Name
            };
        }

        public static IEnumerable<UserModel> ToApiModels(this IEnumerable<User> users)
        {
            return users.Select(a => a.ToApiModel());
        }

        public static IEnumerable<User> ToDomainModels(this IEnumerable<UserModel> userModels)
        {
            return userModels.Select(a => a.ToDomainModel());
        }

        //I don't know what this is, so i'm commenting it out to be safe
        /*
        internal User ToDomainModel()
        {
            throw new NotImplementedException();
        } */
    }
}
