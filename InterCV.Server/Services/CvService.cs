using InterCV.Server.Models.Dtos;
using InterCV.Server.Models.Dtos.DtoMappers;
using InterCV.Server.Models.Dtos.UserDtos;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface ICvService
{
    Task<CvDto?> GetCvAsync();
}

public class CvService (ICvRepository cvRepo) : ICvService
{
    //TODO Fix
    public async Task<CvDto?> GetCvAsync()
    {
        var cv = await cvRepo.GetCvAsync();

        return cv.ToDto();
    }
}