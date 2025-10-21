using InterCV.Server.Models.CvModels;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.UrlModels;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models;

public class SampleCv
{

    public static CvModel GetSampleCv()
    {
        return new CvModel
        {
            User = new UserProfile
            {
                ProfilePictureUrl = "",
                PreferredProfessionalTitle = ".Net/Java Fullstack Developer",
                FirstName = "Eric",
                LastName = "Norrwing",
                Email = "Eric.norrwing@gmail.com",
                Phone = "+46 73 632 46 90",
                LinkedInUrl = new LinkedInUrl
                {
                    Url = "https://www.linkedin.com/in/eric-norrwing-60342a127/"
                }
            },
            Experiences =
            [
                new Experience
                {
                    Workplace = "LF Finans",
                    Title = ".Net Systems Engineer",
                    StartDate = new DateTime(2025, 1, 10),
                    EndDate = new DateTime(2025, 6, 15),
                    DescriptionShort =
                        "Junior developer internship, focusing on the internal test platform Molgan as well as cooperative work on the internal KYC/ODD stabilization project",
                    Details = new ExperienceDetails
                    {
                        DescriptionLong =
                            """
                            Worked on the internal test platform Molgan, which was designed to generate test data for the company. 
                            Developed multiple new modules and structural improvements, and transitioned the codebase to TypeScript.

                            The technology stack for this project included .NET, React (SPA), and MongoDB.

                            Additionally, contributed to the Know Your Customer (KYC) platform and related microservices, collaborating closely with developers and QA engineers. 
                            The primary focus during this period was resolving numerous performance issues and bugs that were impacting the legacy monolithic system.

                            I also participated in preparatory work to modernize the dependency injection strategy, which was outdated, as part of a broader architectural initiative to enhance system stability and responsiveness.
                            """,
                        Achievements =
                        [
                            "Contributed to the continuous work to stabilize the KYC/ODD stabilization project",
                            "Worked closely with the team and the systems Anti-Money-Laundering integration to improve the understanding of the platform",
                            "Worked to improve the internal testdata platform Molgan who had numerous bugs and hastily produced UI"
                        ],
                        References =
                        [
                            new ExperienceReference
                            {
                                FirstName = "Mattias",
                                LastName = "Carlsson",
                                Title = "Software Engineer specialized in Springboot",
                                LinkedInUrl = "https://www.linkedin.com/in/mcsn/",
                                Email = "Mattias.Carlsson@Lffinans.com",
                                Phone = "+1-555-123-4567",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = "https://www.linkedin.com/in/mcsn/"
                                }
                            },

                            new ExperienceReference
                            {
                                FirstName = "Per",
                                LastName = "Liljekvist",
                                Title = "Data analyst specialized in AML/FCP",
                                LinkedInUrl = "https://www.linkedin.com/in/perliljekvist/",
                                Email = "Per.test@example.com",
                                Phone = "+1-555-888-2222",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = "https://www.linkedin.com/in/perliljekvist/"
                                }
                            },

                            new ExperienceReference
                            {
                                FirstName = "Peter",
                                LastName = "Erdmann",
                                Title = "Software Architect",
                                LinkedInUrl = "",
                                Email = "Peter.test@example.com",
                                Phone = "+1-555-888-2222",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = ""
                                }
                            }
                        ]
                    }
                },

                new Experience
                {
                    Workplace = "Tritech Solutions",
                    Title = "System Assembly Engineer",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2023, 1, 10),
                    DescriptionShort =
                        "Assembly and installation production of industrial computers for various customers across Europe",
                    Details = new ExperienceDetails
                    {
                        DescriptionLong =
                            """
                            Assembled specialized computers for various industrial applications, including systems designed for harbor cranes. 
                            Responsible for installation, setup, and preparation of a wide range of orders, as well as ensuring product quality and diagnosing production faults and issues. 

                            In the latter part of this role, I also managed the addition of new products to the company website. 
                            This involved improving the existing product backlog and enhancing SEO performance through various content and metadata optimizations.
                            """,
                        Achievements =
                        [
                            "Improved the SEO and added several hundred products to the company webpage",
                            "Built several hundred specialized computers ensured stability in the installation process"
                        ],
                        References =
                        [
                            new ExperienceReference
                            {
                                FirstName = "James",
                                LastName = "Bond",
                                Title = "Project Manager",
                                LinkedInUrl = "https://linkedin.com/in/refa",
                                Email = "refa@example.com",
                                Phone = "+1-555-111-2222",
                                InterCvProfile = new InterCvUrl
                                {
                                    Url = "https://intercv.io/profile/refa"
                                }
                            }
                        ]
                    }
                }
            ],
            UserData = [],
            Educations =
            [
                new Education
                {
                    Formal = true,
                    EducationName = "Java and Fullstack Developer",
                    Title = "Java / Fullstack Developer Program",
                    Provider = "Stockholms Tekniska Institut",
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                    Description = "A higher vocational education focused on backend and fullstack development using Java, Spring Boot, and modern frontend frameworks.",
                    VerificationUrl = "http://url2993.trueoriginal.com/ls/click?upn=u001.0qQppwx5qkT5g7o7pxBkum-2Fg9ika8mu-2BSqyapNma1Ke5EQGOgc6H72P2s8Gj-2FIZAY9s6zllu0fnOp1rnryCm0m6xESFjcrqzokhg1a72dNjHRkED-2BW6OHbKU3EM-2B4w47tvj84H24rheYWx3nfCM6lrW2o-2BQaDfwCKmnHzvFzB9oqqSbakP4X8SZbfmjSF-2FPURjv017G4aZlSFwuZeyjE0rc4jEEmGISWZrxNb-2Few-2F4PXRwu1tpiewsgEM98il93WfsnagVY83nS0qmHsTiN975igbBjpNyrWcFGCU6HfP05L3IfOsLeu1KoeKKfeEitc3OMFbgMolUBWwbXRCF9tFUDaCdxWHzu7hwdYP3PMpbl3svKyVTXTJuXPXo8XgdO0a6MmOuh9o0Th8l3mpVQtOLoUEEXdq-2B5h0t5JOmvzLr7fA2P-2BIbZQ2jCH-2B5alOSBTrNt8yc6TEQT9JD8pSjllgDPLdJXJ3MAvicyfV0z4AaxWP2BZgDtZj9DrzNkqxM2j0E8n449LyPWlIMBhts6XJWaP9F-2BAdsXRmbRUdCZDWOX6IdBXns3KbkT3rZw524ICeXV__DPzkdeVRcs8S7KbJJA-2B5XRBr96qswPbjV7SbZJxYX5lFKUB2Y01Q5TofkDvsEaB93AEPIwxu8K-2FSPMCZQsfu4aG3gPcP9eAgvcejWsNsWf4l23cO4EEWOgx3JfhctliZlzqkb1vKe5FO-2BxdpJNCgnBf2D58Tcgx73lPBLz04GQ4h-2BeRkoVTI-2F1YX0-2BN8R2a37YTPbiNP-2FXtT7BvArnqNZA5P75mZS4O7rL5cy7XjcmVlhebC8jmOC-2FUuIYYea6XU5RIxikVEmkn6bh-2BtQU6Llg-3D-3D"
                },
                new Education
                {
                    Formal = true,
                    EducationName = "Business Intelligence",
                    Title = "Business Intelligence Analyst Program",
                    Provider = "Nackademin",
                    StartDate = new DateTime(2020, 1, 1),
                    EndDate = new DateTime(2021, 1, 1),
                    Description = "Practical education in data analysis, ETL processes, data warehousing, and visualization tools like Power BI and SQL Server.",
                    VerificationUrl = ""
                },
                new Education
                {
                    Formal = false,
                    EducationName = "Forklift License",
                    Title = "Forklift Certification A1-A4, B1-B6",
                    Provider = "Arbetsförmedlingen",
                    StartDate = new DateTime(2014, 1, 1),
                    EndDate = new DateTime(2014, 1, 1),
                    Description = "Completed certified forklift driver training (A1–A4, B1–B4) — non-formal professional certification.",
                    VerificationUrl = null
                }
            ],
            AboutMe = 
            """
            I’m a junior fullstack developer with hands-on experience in both Java and .NET ecosystems, passionate about building clean, maintainable, and user-focused applications. I’ve worked across the stack — from backend services and REST APIs to modern React frontends — and enjoy bridging technical structure with thoughtful design.
            
            As the developer behind InterCV, I’m focused on creating tools that streamline professional presentation and help developers showcase their skills effectively. I’m continuously learning and exploring best practices in software architecture, cloud deployment, and UI performance.
            """
        };
    }
}