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
                User = user,
                Title = ".Net Systems Engineer",
                Workplace = "LF Finans",
                StartDate = new DateTime(2025, 1, 10),
                EndDate = new DateTime(2025, 6, 15),
                DescriptionShort = "Junior developer internship, focusing on the internal test platform Molgan and KYC/ODD stabilization project.",
                Description = """
                    Worked on the internal test platform Molgan, developing new modules and structural improvements, and transitioned the codebase to TypeScript.
                    Contributed to KYC platform microservices, resolving performance issues and bugs in the legacy monolith.
                """,
                Achievements = new List<Achievement>
                {
                    new Achievement { Title = "Stabilized KYC/ODD project" },
                    new Achievement { Title = "Improved internal test platform Molgan" },
                    new Achievement { Title = "Collaborated with Anti-Money-Laundering integration team" }
                },
                References = new List<Reference>
                {
                    new Reference
                    {
                        FirstName = "Mattias",
                        LastName = "Carlsson",
                        Title = "Software Engineer specialized in Springboot",
                        LinkedInUrl = "https://www.linkedin.com/in/mcsn/",
                        Email = "Mattias.Carlsson@Lffinans.com",
                        Phone = "+1-555-123-4567",
                        PictureUrl = "https://media.licdn.com/dms/image/v2/C4E03AQHJLJN497QYIQ/profile-displayphoto-shrink_200_200/0/1517411205988?e=1762992000&v=beta&t=8rjZbwChqNf9KL5n3D1tx5jnsnH1qdAqXug_ryD3FH0"
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
                }
            },
            new Experience
            {
                User = user,
                Title = "System Assembly Engineer",
                Workplace = "Tritech Solutions",
                StartDate = new DateTime(2022, 1, 1),
                EndDate = new DateTime(2023, 1, 10),
                DescriptionShort = "Assembly and installation of industrial computers for European customers.",
                Description = """
                    Assembled specialized computers for industrial applications, ensured product quality, and managed new product additions to the company website.
                    Improved SEO and content metadata for better online visibility.
                """,
                Achievements = new List<Achievement>
                {
                    new Achievement { Title = "Improved SEO and added hundreds of products" },
                    new Achievement { Title = "Ensured stability in specialized computer installations" }
                },
                References = new List<Reference>
                {
                    new Reference
                    {
                        FirstName = "James",
                        LastName = "Bond",
                        Title = "Project Manager",
                        LinkedInUrl = "https://linkedin.com/in/refa",
                        Email = "refa@example.com",
                        Phone = "+1-555-111-2222"
                    }
                }
            }
        };
        
        foreach (var exp in experiences)
        {
            foreach (var ach in exp.Achievements)
                ach.Experience = exp;
            foreach (var reference in exp.References)
                reference.Experience = exp;
        }
        
        var educations = new List<Education>
        {
            new Education
            {
                User = user,
                Type = EducationType.Bachelor,
                Institution = "Stockholms Tekniska Institut",
                Title = "Java / Fullstack Developer Program",
                DescriptionShort = "A higher vocational education focused on backend and fullstack development using Java, Spring Boot, and modern frontend frameworks.",
                StartDate = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2025, 1, 1),
                Verification = "https://true.sti.se/examensbevis-275811-6425/?zone=truecrt&modal=1&lang=se"
            },
            new Education
            {
                User = user,
                Type = EducationType.Bachelor,
                Institution = "Nackademin",
                Title = "Business Intelligence Analyst Program",
                DescriptionShort = "Practical education in data analysis, ETL, data warehousing, and visualization tools like Power BI and SQL Server.",
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2021, 1, 1)
            },
            new Education
            {
                User = user,
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
            new Tag { Name = "C#/.NET" },
            new Tag { Name = "Java/Springboot" },
            new Tag { Name = "Automated Testing" },
            new Tag { Name = "React JS/TS" },
            new Tag { Name = "DevOps" },
            new Tag { Name = "Docker" },
            new Tag { Name = "Agile (Scrum)" },
            new Tag { Name = "SQL" },
            new Tag { Name = "No-SQL DB's" }
        };

        // Now create CV with proper navigation links
        return new Cv
        {
            User = user,
            AboutMe = """
                I’m a junior fullstack developer with hands-on experience in Java and .NET, passionate about clean, maintainable applications.
                Worked across backend services and React frontends. Creator of InterCV, focused on showcasing developer skills effectively.
            """,
            Experiences = experiences.Select(e => new CvExperience { Cv = null!, Experience = e }).ToList(),
            Educations = educations.Select(ed => new CvEducation { Cv = null!, Education = ed }).ToList(),
            Tags = tags.Select(t => new CvTag { Cv = null!, Tag = t }).ToList()
        };
    }
}
