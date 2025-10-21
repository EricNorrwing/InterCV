import type {Education} from "../../models/CvModel.ts";

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
                        {edu.description && <p className="preserve-whitespace">{edu.description}</p>}
                    </div>
                ) : null
            )}
        </div>
    );
}

