import {ProfilePictureCard} from "../../components/profile/picture/ProfilePictureCard.tsx";
import ExperienceComponent from "../../components/experienceComponents/ExperienceComponent.tsx";
import ExperienceDetailsComponent
    from "../../components/experienceComponents/experienceDetailsComponents/ExperienceDetailsComponent.tsx";
import type {CvModel} from "../../models/CvModel.ts";
import CvHeaderComponent from "../../components/generalCvComponents/CvHeaderComponent.tsx";
import {useState} from "react";
import FormalEducationDetailsComponent from "../../components/educationComponents/FormalEducationDetailsComponent.tsx";
import InformalEducationDetailsComponent
    from "../../components/educationComponents/InformalEducationDetailsComponent.tsx";
import AboutMeComponent from "../../components/AboutMeComponent.tsx";
import ExperienceInstructionComponent from "../../components/experienceComponents/ExperienceInstructionComponent.tsx";
import "../../components/experienceComponents/Experience.css"


interface CvDisplayPageProps {
    cv: CvModel;
}

export function CvDisplayPage({ cv }: CvDisplayPageProps) {
    const [selectedExperienceIndex, setSelectedExperienceIndex] = useState<number | null>(null);

    return (
        <div className="container">
            <div className="row">
                <div className="col-sm-8">
                    <CvHeaderComponent user={cv.user} />
                </div>
                <div className="col-sm-4 d-flex justify-content-center align-items-center">
                    <ProfilePictureCard pictureUrl={cv.user.profilePictureUrl} />
                </div>
            </div>

            <ul className="nav nav-tabs justify-content-center" id="myTab" role="tablist">
                <li className="nav-item" role="presentation">
                    <button
                        className="nav-link active"
                        id="home-tab"
                        data-bs-toggle="tab"
                        data-bs-target="#work-experience"
                        type="button"
                        role="tab"
                        aria-controls="home"
                        aria-selected="true"
                    >
                        Work Experience
                    </button>
                </li>
                <li className="nav-item" role="presentation">
                    <button
                        className="nav-link"
                        id="profile-tab"
                        data-bs-toggle="tab"
                        data-bs-target="#education"
                        type="button"
                        role="tab"
                        aria-controls="profile"
                        aria-selected="false"
                    >
                        Education
                    </button>
                </li>
                <li className="nav-item" role="presentation">
                    <button
                        className="nav-link"
                        id="contact-tab"
                        data-bs-toggle="tab"
                        data-bs-target="#about-me"
                        type="button"
                        role="tab"
                        aria-controls="contact"
                        aria-selected="false"
                    >
                        About me
                    </button>
                </li>
            </ul>

            <div className="tab-content" id="myTabContent">
                <div className="tab-pane fade show active" id="work-experience" role="tabpanel" aria-labelledby="Work-tab">
                    <div className="row">
                        <div className="col">
                            <ExperienceComponent
                                experiences={cv.experiences}
                                selectedIndex={selectedExperienceIndex ?? -1}
                                onSelect={setSelectedExperienceIndex}
                            />
                            
                        </div>
                        <div className="col">
                            {selectedExperienceIndex === null ? (
                                <ExperienceInstructionComponent />
                            ) : (
                                <div key={selectedExperienceIndex} className="fade-in">
                                    <ExperienceDetailsComponent
                                        details={cv.experiences[selectedExperienceIndex].details}
                                    />
                                </div>
                            )}
                        </div>
                    </div>
                </div>

                <div className="tab-pane fade" id="education" role="tabpanel" aria-labelledby="education-tab">
                    <div className="row">
                        <div className="col">
                            <h3>Formal Education</h3>
                            <FormalEducationDetailsComponent educationsHistory={cv.educations} />
                        </div>
                        <div className="col">
                            <h3>Certifications and courses</h3>
                            <InformalEducationDetailsComponent educationsHistory={cv.educations} />
                        </div>
                    </div>
                </div>

                <div className="tab-pane fade" id="about-me" role="tabpanel" aria-labelledby="about-me-tab">
                    <AboutMeComponent aboutMe={cv.aboutMe} />
                </div>
            </div>
        </div>
    );
}
