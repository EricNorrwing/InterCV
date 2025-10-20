import type {Experience} from '../../models/CvModel.ts';

interface ExperienceComponentProps {
    experiences: Experience[];
    selectedIndex: number;
    onSelect: (idx: number) => void;
}
//TODO FIX OH MY GOD 
export default function ExperienceComponent({ experiences, selectedIndex, onSelect }: ExperienceComponentProps) {
    return (
        <div>
            {experiences.map((exp, index) => {
                const isSelected = selectedIndex === index;
                return (
                    <div
                        key={index}
                        onClick={() => onSelect(index)}
                        style={{
                            cursor: "pointer",
                            backgroundColor: isSelected ? "#f0f0f0" : "transparent",
                            padding: "0.5rem",
                            borderRadius: "4px",
                            marginBottom: "0.5rem"
                        }}
                    >
                        <h4>{exp.title} at {exp.workplace}</h4>
                        <p>
                            {new Date(exp.startDate).toLocaleDateString()} - {new Date(exp.endDate).toLocaleDateString()}
                        </p>
                        <p>{exp.descriptionShort}</p>
                    </div>
                );
            })}
        </div>
    );
}
