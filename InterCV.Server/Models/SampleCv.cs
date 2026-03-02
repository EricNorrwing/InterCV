using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.Dtos;
using InterCV.Server.Models.Dtos.UserDtos;


namespace InterCV.Server.Models;

public static class SampleCv
{
    public static CvDto GetSampleCv()
    {
        return new CvDto
        {
            AboutMe = """
                I’m a junior fullstack developer with hands-on experience in Java and .NET,
                passionate about clean, maintainable applications.
                Creator of InterCV, focused on showcasing developer skills effectively.
            """,

            Profile = new UserProfileDto
            {
                FirstName = "Eric",
                LastName = "Norrwing",
                Phone = "+46 73 632 46 90",
                LinkedInUrl = "https://www.linkedin.com/in/eric-norrwing-60342a127/",
                DefaultTitle = "Systems Engineer",
                PictureUrl = "https://media.licdn.com/dms/image/v2/C4E03AQHJLJN497QYIQ/profile-displayphoto-shrink_200_200/0/1517411205988"
            },

            Experiences =
            [
                new ExperienceDto
                {
                    Title = ".NET Systems Engineer",
                    Workplace = "LF Finans",
                    StartDate = new DateTime(2025, 1, 10),
                    EndDate = new DateTime(2025, 6, 15),
                    DescriptionShort =
                        "Junior developer internship focusing on internal test platforms and KYC systems.",
                    Description = """
                        Worked on the internal test platform Molgan, developing new modules
                        and migrating the codebase to TypeScript.
                        Contributed to KYC microservices and stabilized legacy systems.
                    """,

                    Achievements =
                    [
                        "Stabilized KYC/ODD project",
                        "Improved internal test platform Molgan",
                        "Collaborated with AML integration team"
                    ],

                    References =
                    [
                        new ReferenceDto
                        {
                            FirstName = "Mattias",
                            LastName = "Carlsson",
                            Title = "Software Engineer (Spring Boot)",
                            LinkedInUrl = "https://www.linkedin.com/in/mcsn/",
                            Email = "mattias.carlsson@lffinans.com",
                            Phone = "+1-555-123-4567"
                        },
                        new ReferenceDto
                        {
                            FirstName = "Per",
                            LastName = "Liljekvist",
                            Title = "Data Analyst (AML/FCP)",
                            Email = "per.test@example.com",
                            Phone = "+1-555-888-2222"
                        }
                    ]
                },

                new ExperienceDto
                {
                    Title = "System Assembly Engineer",
                    Workplace = "Tritech Solutions",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2023, 1, 10),
                    DescriptionShort =
                        "Assembly and installation of industrial computers.",
                    Description = """
                        Assembled industrial computers, ensured quality,
                        and improved website SEO and product metadata.
                    """,

                    Achievements =
                    [
                        "Improved SEO and added hundreds of products",
                        "Ensured stability in industrial installations"
                    ],

                    References =
                    [
                        new ReferenceDto
                        {
                            FirstName = "James",
                            LastName = "Bond",
                            Title = "Project Manager",
                            Email = "refa@example.com",
                            Phone = "+1-555-111-2222"
                        }
                    ]
                }
            ],

            Educations =
            [
                new EducationDto
                {
                    Type = EducationType.Bachelor.ToString(),
                    Institution = "Stockholms Tekniska Institut",
                    Title = "Java / Fullstack Developer Program",
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                    DescriptionShort =
                        "Backend and fullstack development using Java, Spring Boot, and modern frontend frameworks.",
                    Verification =
                        "https://true.sti.se/examensbevis-275811-6425"
                },
                new EducationDto
                {
                    Type = EducationType.Certificate.ToString(),
                    Institution = "Arbetsförmedlingen",
                    Title = "Forklift Certification A1–A4, B1–B6",
                    StartDate = new DateTime(2014, 1, 1),
                    EndDate = new DateTime(2014, 1, 1),
                    DescriptionShort =
                        "Certified forklift driver training."
                }
            ],

            Tags =
            [
                "C#/.NET",
                "Java/Spring Boot",
                "React / TypeScript",
                "SQL",
                "Docker",
                "DevOps",
                "Agile / Scrum"
            ]
        };
    }
}