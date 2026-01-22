using System.ComponentModel.DataAnnotations;

namespace InterCV.Server.Configuration;

public class ApplicationSettings
{
    [Required]
    [Url]
    public string BaseUrl { get; set; } = null!;
}