using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Account;
using api.Models;

namespace api.Mappers
{
    public static class AppUserMappers
    {
        public static UserInfoDto? ToAppUserDto(AppUser user)
        {
            if (user == null)
                return null;

            return new UserInfoDto
            {
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };
        }
    }
}
