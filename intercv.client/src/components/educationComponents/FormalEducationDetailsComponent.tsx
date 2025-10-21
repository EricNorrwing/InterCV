import type {Education} from "../../models/CvModel.ts";
import {Link} from "@tanstack/react-router";
import { IoIosAttach } from "react-icons/io";

interface FormalEducationProps {
    educationsHistory: Education[];
}

export default function FormalEducationDetailsComponent({ educationsHistory }: FormalEducationProps) {
    return (
        <div>
            {educationsHistory.map((edu, index) =>
                edu.formal ? (
                    <div key={index} className="mb-3">
                        <h5>{edu.educationName}</h5>
                        <p className="mb-1">{edu.title}</p>
                        <p className="text-muted">
                            {new Date(edu.startDate).toLocaleDateString()} - {new Date(edu.endDate).toLocaleDateString()}
                        </p>
                            {edu.description && <p className="preserve-whitespace">{edu.description}
                        </p>}
                        {edu.verificationUrl ? 
                        <Link to={edu.verificationUrl}> <IoIosAttach /> Link to Proof</Link>
                        : null}
                    </div>
                ) : null
            )}
        </div>
    );
}

