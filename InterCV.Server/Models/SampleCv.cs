using InterCV.Server.Models.CvModels.CvJunctionTables;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.CvModels.Experiences.References;
using InterCV.Server.Models.CvModels.Tags;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models;

public class SampleCv
{
    public static Cv GetSampleCv()
    {
        var user = new User
        {
            Profile = new UserProfile
            {
                FirstName = "Eric",
                LastName = "Norrwing",
                Phone = "+46 73 632 46 90",
                LinkedInUrl = "https://www.linkedin.com/in/eric-norrwing-60342a127/",
                DefaultTitle = "Systems Engineer"
            }
        };

        var experiences = new List<Experience>
        {
            new Experience
            {
                Workplace = "LF Finans",
                Title = ".Net Systems Engineer",
                StartDate = new DateTime(2025, 1, 10),
                EndDate = new DateTime(2025, 6, 15),
                DescriptionShort = "Junior developer internship, focusing on the internal test platform Molgan and KYC/ODD stabilization project.",
                Description = """
                    Worked on the internal test platform Molgan, developing new modules and structural improvements, and transitioned the codebase to TypeScript.
                    Contributed to KYC platform microservices, resolving performance issues and bugs in the legacy monolith.
                """,
                Achievements =
                [
                    new Achievement { Title = "Stabilized KYC/ODD project" },
                    new Achievement { Title = "Improved internal test platform Molgan" },
                    new Achievement { Title = "Collaborated with Anti-Money-Laundering integration team" }
                ],
                References =
                [
                    new Reference
                    {
                        FirstName = "Mattias",
                        LastName = "Carlsson",
                        Title = "Software Engineer specialized in Springboot",
                        LinkedInUrl = "https://www.linkedin.com/in/mcsn/",
                        Email = "Mattias.Carlsson@Lffinans.com",
                        Phone = "+1-555-123-4567",
                        PictureUrl =
                            "https://media.licdn.com/dms/image/v2/C4E03AQHJLJN497QYIQ/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1517411205988?e=1762992000&v=beta&t=8rjZbwChqNf9KL5n3D1tx5jnsnH1qdAqXug_ryD3FH0"
                    },

                    new Reference
                    {
                        FirstName = "Per",
                        LastName = "Liljekvist",
                        Title = "Data analyst specialized in AML/FCP",
                        LinkedInUrl = "https://www.linkedin.com/in/perliljekvist/",
                        Email = "Per.test@example.com",
                        Phone = "+1-555-888-2222"
                    },

                    new Reference
                    {
                        FirstName = "Peter",
                        LastName = "Erdmann",
                        Title = "Software Architect",
                        Email = "Peter.test@example.com",
                        Phone = "+1-555-888-2222"
                    }
                ]
            },
            new Experience
            {
                Workplace = "Tritech Solutions",
                Title = "System Assembly Engineer",
                StartDate = new DateTime(2022, 1, 1),
                EndDate = new DateTime(2023, 1, 10),
                DescriptionShort = "Assembly and installation of industrial computers for European customers.",
                Description = """
                    Assembled specialized computers for industrial applications, ensured product quality, and managed new product additions to the company website.
                    Improved SEO and content metadata for better online visibility.
                """,
                Achievements =
                [
                    new Achievement { Title = "Improved SEO and added hundreds of products" },
                    new Achievement { Title = "Ensured stability in specialized computer installations" }
                ],
                References =
                [
                    new Reference
                    {
                        FirstName = "James",
                        LastName = "Bond",
                        Title = "Project Manager",
                        LinkedInUrl = "https://linkedin.com/in/refa",
                        Email = "refa@example.com",
                        Phone = "+1-555-111-2222"
                    }
                ]
            }
        };

        var educations = new List<Education>
        {
            new Education
            {
                Type = EducationType.Bachelor,
                Institution = "Stockholms Tekniska Institut",
                Title = "Java / Fullstack Developer Program",
                DescriptionShort = "A higher vocational education focused on backend and fullstack development using Java, Spring Boot, and modern frontend frameworks.",
                StartDate = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2025, 1, 1),
                Verification = "http://url2993.trueoriginal.com/ls/click?upn=u001..."
            },
            new Education
            {
                Type = EducationType.Bachelor,
                Institution = "Nackademin",
                Title = "Business Intelligence Analyst Program",
                DescriptionShort = "Practical education in data analysis, ETL, data warehousing, and visualization tools like Power BI and SQL Server.",
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2021, 1, 1)
            },
            new Education
            {
                Type = EducationType.Certificate,
                Institution = "Arbetsförmedlingen",
                Title = "Forklift Certification A1-A4, B1-B6",
                DescriptionShort = "Completed certified forklift driver training (A1–A4, B1–B4) — non-formal professional certification.",
                StartDate = new DateTime(2014, 1, 1),
                EndDate = new DateTime(2014, 1, 1)
            }
        };

        var tags = new List<Tag>
        {
            new Tag { Name = "C#/.NET", User = user },
            new Tag { Name = "Java/Springboot", User = user },
            new Tag { Name = "Automated Testing", User = user },
            new Tag { Name = "React JS/TS", User = user },
            new Tag { Name = "DevOps", User = user },
            new Tag { Name = "Docker", User = user },
            new Tag { Name = "Agile (Scrum)", User = user },
            new Tag { Name = "SQL", User = user },
            new Tag { Name = "No-SQL DB's", User = user }
        };

        return new Cv
        {
            User = user,
            AboutMe = """
                I’m a junior fullstack developer with hands-on experience in Java and .NET, passionate about clean, maintainable applications.
                Worked across backend services and React frontends. Creator of InterCV, focused on showcasing developer skills effectively.
            """,
            Experiences = experiences.Select(e => new CvExperience { Experience = e }).ToList(),
            Educations = educations.Select(ed => new CvEducation { Education = ed }).ToList(),
            Tags = tags.Select(t => new CvTag { Tag = t }).ToList()
        };
    }
}
