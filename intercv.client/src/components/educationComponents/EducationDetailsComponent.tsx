import type {Education} from "../../models/CvModel.ts";

interface EducationProps {
    educationsHistory: Education[];
}

export default function EducationDetailsComponent({ educationsHistory }: EducationProps) {
    return (
        <div>
            {educationsHistory.map((edu, index) =>
                edu.formal ? (
                    <div key={index} className="mb-3">
                        <h5>{edu.educationName}</h5>
                        <p className="mb-1">{edu.title}</p>
                        <p className="text-muted">
                            {/*edu.startDate} – {edu.endDate*/}
                        </p>
                        {edu.description && <p className="preserve-whitespace">{edu.description}</p>}
                    </div>
                ) : null
            )}
        </div>
    );
}

