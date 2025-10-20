using InterCV.Server.Models.CvModels;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.UrlModels;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models;

public class SampleCv
{

    public CvModel GetSampleCv()
    {


        return new CvModel
        {
            User = new UserProfile
            {
                ProfilePictureUrl = "",
                PreferredProfessionalTitle = ".Net Fullstack Developer",
                FirstName = "Alice",
                LastName = "Johnson",
                Email = "alice.johnson@example.com",
                Phone = "+1-555-432-9876",
                LinkedInUrl = new LinkedInUrl
                {
                    Url = "https://www.linkedin.com/in/alicejohnson/"
                }
            },
            Experiences = new List<Experience>
            {
                new Experience
                {
                    Workplace = "TechNova Solutions",
                    Title = "Senior Frontend Developer",
                    StartDate = new DateTime(2021, 5, 10),
                    EndDate = new DateTime(2024, 8, 15),
                    DescriptionShort =
                        "Led frontend development of enterprise-scale applications using React and TypeScript.",
                    Details = new ExperienceDetails
                    {
                        DescriptionLong =
                            "Worked on a suite of SaaS tools used by 50,000+ customers worldwide. Focused on frontend architecture, performance, and mentoring.",
                        Achievements = new List<string>
                        {
                            "Improved page load performance by 35% through dynamic import optimization.",
                            "Migrated legacy React codebase to TypeScript and improved type safety.",
                            "Collaborated with backend teams to design REST and GraphQL APIs."
                        },
                        References = new List<ExperienceReference>
                        {
                            new ExperienceReference
                            {
                                Name = "Bob Example",
                                Title = "Engineering Manager",
                                LinkedInUrl = "https://linkedin.com/in/bobexample",
                                Email = "bob@example.com",
                                Phone = "+1-555-123-4567",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = "https://intercv.io/profile/abc123"
                                }
                            },
                            new ExperienceReference
                            {
                                Name = "Jane Lorem",
                                Title = "Tech Lead",
                                LinkedInUrl = "https://linkedin.com/in/janelorem",
                                Email = "jane@example.org",
                                Phone = "+1-555-888-2222",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = "https://intercv.io/profile/xyz987"
                                }
                            }
                        }
                    }
                },
                new Experience
                {
                    Workplace = "BrightPixel Labs",
                    Title = "Frontend Engineer",
                    StartDate = new DateTime(2018, 3, 1),
                    EndDate = new DateTime(2021, 4, 30),
                    DescriptionShort = "Developed responsive web applications for clients across multiple industries.",
                    Details = new ExperienceDetails
                    {
                        DescriptionLong =
                            "Built custom React and Vue.js applications. Responsible for implementing UI/UX designs, optimizing accessibility, and integrating third-party APIs.",
                        Achievements = new List<string>
                        {
                            "Built a reusable design system in React to accelerate project delivery.",
                            "Integrated analytics tracking and A/B testing into multiple client apps.",
                            "Trained interns on modern frontend tooling and version control workflows."
                        },
                        References = new List<ExperienceReference>
                        {
                            new ExperienceReference
                            {
                                Name = "Ref A",
                                Title = "Project Manager",
                                LinkedInUrl = "https://linkedin.com/in/refa",
                                Email = "refa@example.com",
                                Phone = "+1-555-111-2222",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = "https://intercv.io/profile/refa"
                                }
                            }
                        }
                    }
                }
            },
            UserData = new List<UserData>()
        };
    }
}