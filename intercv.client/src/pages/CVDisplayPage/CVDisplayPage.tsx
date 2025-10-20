
import './temp.css'
import {ProfilePictureCard} from "../../components/profile/picture/ProfilePictureCard.tsx";
import ExperienceComponent from "../../components/experienceComponents/ExperienceComponent.tsx";
import ExperienceDetailsComponent
    from "../../components/experienceComponents/experienceDetailsComponents/ExperienceDetailsComponent.tsx";
import type {CvModel} from "../../models/CvModel.ts";
import CvHeaderComponent from "../../components/generalCvComponents/CvHeaderComponent.tsx";


interface CvDisplayPageProps {
    cv: CvModel;
}

//TODO Remove temp.css ofc
export function CVDisplayPage({ cv }: CvDisplayPageProps) {
    return (
        
        <div className="container">
            <div className="row" >
                <div className="col-sm-8">
                    <CvHeaderComponent user={cv.user}/>
                </div>
                <div className="col-sm-4 d-flex justify-content-center align-items-center">
                        <ProfilePictureCard pictureUrl={cv.user.profilePictureUrl}/>
                </div>
            </div>
            <div className="row">
                <div className="col">
                    <ExperienceComponent experience={cv.experiences}/>
                </div>
                <div className="col">
                    <ExperienceDetailsComponent/>
                </div>
            </div>
        </div>
        
         
    )
}
