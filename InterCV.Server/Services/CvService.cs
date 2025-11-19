using InterCV.Server.Models.Dtos;
using InterCV.Server.Models.Dtos.DtoMappers;
using InterCV.Server.Models.Dtos.UserDtos;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface ICvService
{
    Task<CvDto?> GetSampleCvAsync();
}

public class CvService (ICvRepository cvRepo) : ICvService
{
    //TODO Fix
    public async Task<CvDto?> GetSampleCvAsync()
    {
        var cv = await cvRepo.GetSampleCvAsync();

        return cv.ToDto();
    }
}