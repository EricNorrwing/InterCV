using System.ComponentModel.DataAnnotations;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Tags;


public class Tag
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}