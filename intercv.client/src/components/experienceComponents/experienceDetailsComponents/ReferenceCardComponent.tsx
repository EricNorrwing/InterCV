import type { ExperienceReference } from "../../../models/CvModel.ts";
import {ProfilePictureCard} from "../../profile/picture/ProfilePictureCard.tsx";
import "./ReferenceCardComponent.css";

import { MdOutlineEmail } from "react-icons/md";
import { FaPhone } from "react-icons/fa";
import { FaLinkedin } from "react-icons/fa";

interface ReferenceProps {
    reference: ExperienceReference;
}

export default function ReferenceCardComponent({ reference }: ReferenceProps) {
    return (
        <div className="card mb-3 reference-card">
            <div className="row g-0">
                <div className="col-md-4 d-flex align-items-start card p-2 border-0">
                    <ProfilePictureCard pictureUrl={"testurl"} />
                </div>
                <div className="col-md-8">
                    <div className="card-body p-2">
                        <h5 className="card-title mb-1">{reference.firstName} {reference.lastName}</h5>
                        <h6 className="mb-1">{reference.title}</h6>
                        <p className="card-text mb-1"><MdOutlineEmail /> {reference.email}</p>
                        <p className="card-text mb-1"><FaPhone /> {reference.phone}</p>
                        <p className="card-text mb-0"><FaLinkedin /> {reference.linkedInUrl}</p>
                    </div>
                </div>
            </div>
        </div>
    )
}