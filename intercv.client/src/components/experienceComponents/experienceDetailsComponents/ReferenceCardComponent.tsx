import type { ExperienceReference } from "../../../models/CvModel.ts";
import {ProfilePictureCard} from "../../profile/picture/ProfilePictureCard.tsx";

interface ReferenceProps {
    reference: ExperienceReference;
}

export default function ReferenceCardComponent ({reference}: ReferenceProps) {
    return (
        <div className="d-flex justify-content-center">
            <div className="card h-100 w-100">
                {/*TODO Fix url */}
                <ProfilePictureCard pictureUrl={"testurl"} />
                <h5>{reference.firstName}</h5><br/>
                <h5>{reference.lastName}</h5><br/>
                <h5>{reference.email}</h5><br/>
                <h5>{reference.phone}</h5><br/>
                <h5>{reference.linkedInUrl}</h5><br/>
            </div>
        </div>
    )
}