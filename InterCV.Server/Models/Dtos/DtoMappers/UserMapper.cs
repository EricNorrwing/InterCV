using InterCV.Server.Models.Dtos.User;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class UserMapper
{
    public static UserDetailsDto ToUserDetailsDto(this Users.User user)
    {
        return new UserDetailsDto
        {
            return new UserDetailsDto {
                AuthUserDto = user.Auth.ToUserDetails(),
                UserDto = user.UserDto(),
                UserProfileDto = user.UserProfileDto();
        }
    }
}