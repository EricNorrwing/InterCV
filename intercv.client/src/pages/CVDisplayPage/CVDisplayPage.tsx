import ExperienceComponent from "../../components/experienceComponents/ExperienceComponent.tsx";
import './temp.css'
import {ProfilePictureCard} from "../../components/profile/picture/ProfilePictureCard.tsx";
import ExperienceDetailsComponent
    from "../../components/experienceComponents/experienceDetailsComponents/ExperienceDetailsComponent.tsx";



//Remove temp.css ofc
export function CVDisplayPage() {
    return (
        <div className="container">
            <div className="row" >
                <div className="col-sm-8">
                    <h1>Eric Norrwing <br/> </h1>
                    <h3>Systems Engineer </h3>
                </div>
                <div className="col-sm-4 d-flex justify-content-center align-items-center">
                        <ProfilePictureCard/>
                </div>
            </div>
            <div className="row">
                <div className="col">
                    <ExperienceComponent/>
                </div>
                <div className="col">
                    <ExperienceDetailsComponent/>
                </div>
            </div>
        </div>
    )
}
