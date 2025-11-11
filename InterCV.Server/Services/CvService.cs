using InterCV.Server.Models.Dtos;
using InterCV.Server.Models.DTOs;
using InterCV.Server.Models.Dtos.DtoMappers;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public class CvService (CvRepository cvRepo) 
{
    //TODO Fix
    public async Task<CvDto?> GetSampleCvAsync()
    {
        var cv = await cvRepo.GetSampleCvAsync();

        return cv.ToDto();
    }
}