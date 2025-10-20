
import type {Experience} from '../../models/CvModel.ts';

interface ExperienceComponentProps {
    experiences: Experience[];
}

export default function ExperienceComponent({ experiences }: ExperienceComponentProps) {
    return (
        <div>
            {experiences.map((exp, index) => (
                <div key={index}>
                    <h3>{exp.title} at {exp.workplace}</h3>
                    <p>
                        <strong>
                            {new Date(exp.startDate).toLocaleDateString()} - {new Date(exp.endDate).toLocaleDateString()}
                        </strong>
                    </p>
                    <p>{exp.descriptionShort}</p>
                </div>
            ))}
        </div>
    );
}