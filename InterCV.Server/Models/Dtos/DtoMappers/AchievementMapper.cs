using InterCV.Server.Models.CvModels.Experiences;

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