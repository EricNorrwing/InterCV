import type { ExperienceReference } from "../../../models/CvModel.ts";
import "./ReferenceCardComponent.css";

import { MdOutlineEmail } from "react-icons/md";
import { FaPhone } from "react-icons/fa";
import { FaLinkedin } from "react-icons/fa";
import {ReferenceProfilePicture} from "./ReferenceProfilePicture.tsx";

interface ReferenceProps {
    reference: ExperienceReference;
}
//TODO This component  needs a function for automated mail, this is not a priority task.

export default function ReferenceCardComponent({ reference }: ReferenceProps) {
    return (
        <div className="card mb-3 reference-card">
            <div className="row g-0">
                <div className="col-md-4 d-flex align-items-start card p-2 border-0">
                    <ReferenceProfilePicture pictureUrl={reference.linkedInProfilePictureUrl} />
                </div>
                <div className="col-md-8">
                    <div className="card-body p-2">
                        <h5 className="card-title mb-1">{reference.firstName} {reference.lastName}</h5>
                        <h6 className="mb-1">{reference.title}</h6>
                        <p className="card-text mb-1">
                            <MdOutlineEmail /> <a href={`mailto:${reference.email}`}>{reference.email}</a>
                        </p>
                        <p className="card-text mb-1">
                            <FaPhone /> <a href="#" onClick={(e) => { e.preventDefault(); /* TODO Make an automated mail to request a phonecall */ }}>
                            Request direct contact
                            </a>
                        </p>
                        <p className="card-text mb-0"><FaLinkedin /> {reference.linkedInUrl}</p>
                    </div>
                </div>
            </div>
        </div>
    )
}