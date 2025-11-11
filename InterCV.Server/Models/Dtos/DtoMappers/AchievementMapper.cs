using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.DTOs;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class AchievementMapper
{
    public static AchievementDto ToDto(this Achievement achievement)
    {
        return new AchievementDto
        {
            Id = achievement.Id,
            Title = achievement.Title
        };
    }
}