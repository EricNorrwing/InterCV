using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Models;

public class SampleCv
{
    public JsonResult GetSampleCv()
    {
        var sampleCv = new
        {
            user = new
            {
                firstName = "Alice",
                lastName = "Johnson",
                email = "alice.johnson@example.com",
                phone = "+1-555-432-9876",
                linkedInUrl = new
                {
                    linkedInUrl = "https://www.linkedin.com/in/alicejohnson/"
                }
            },
            experiences = new[]
            {
                new
                {
                    workplace = "TechNova Solutions",
                    title = "Senior Frontend Developer",
                    startDate = "2021-05-10",
                    endDate = "2024-08-15",
                    descriptionShort = "Led frontend development of enterprise-scale applications using React and TypeScript.",
                    details = new
                    {
                        descriptionLong = "At TechNova Solutions, I worked on a suite of SaaS tools used by over 50,000 customers worldwide. My main focus was improving the frontend architecture, optimizing rendering performance, and mentoring junior developers.",
                        achievements = new[]
                        {
                            "Improved page load performance by 35% through dynamic import optimization.",
                            "Migrated legacy React codebase to TypeScript and improved type safety.",
                            "Collaborated with backend teams to design REST and GraphQL APIs."
                        },
                        references = new[]
                        {
                            new
                            {
                                name = "Bob Example",
                                title = "Engineering Manager",
                                linkedInUrl = "https://linkedin.com/in/bobexample",
                                email = "bob@example.com",
                                phone = "+1-555-123-4567",
                                interCVProfile = new
                                {
                                    interCvUrl = "https://intercv.io/profile/abc123"
                                }
                            },
                            new
                            {
                                name = "Jane Lorem",
                                title = "Tech Lead",
                                linkedInUrl = "https://linkedin.com/in/janelorem",
                                email = "jane@example.org",
                                phone = "+1-555-888-2222",
                                interCVProfile = new
                                {
                                    interCvUrl = "https://intercv.io/profile/xyz987"
                                }
                            }
                        }
                    }
                },
                new
                {
                    workplace = "BrightPixel Labs",
                    title = "Frontend Engineer",
                    startDate = "2018-03-01",
                    endDate = "2021-04-30",
                    descriptionShort = "Developed responsive web applications for clients across multiple industries.",
                    details = new
                    {
                        descriptionLong = "Worked on custom React and Vue.js applications for startups and mid-sized clients. Responsible for implementing UI/UX designs, optimizing accessibility, and integrating third-party APIs.",
                        achievements = new[]
                        {
                            "Built a reusable design system in React to accelerate project delivery.",
                            "Integrated analytics tracking and A/B testing into multiple client apps.",
                            "Trained interns on modern frontend tooling and version control workflows."
                        },
                        references = new[]
                        {
                            new
                            {
                                name = "Ref A",
                                title = "Project Manager",
                                linkedInUrl = "https://linkedin.com/in/refa",
                                email = "refa@example.com",
                                phone = "+1-555-111-2222",
                                interCVProfile = new
                                {
                                    interCvUrl = "https://intercv.io/profile/refa"
                                }
                            }
                        }
                    }
                }
            },
            userData = new object[] { }
        };

        return new JsonResult(sampleCv);
    }
}