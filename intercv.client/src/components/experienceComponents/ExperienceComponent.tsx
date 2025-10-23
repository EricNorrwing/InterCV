
import ExperienceSelectItemComponent from "./ExperienceSelectItemComponent.tsx";
import type {Experience} from "../../models/CvModel.ts";

interface ExperienceComponentProps {
    experiences: Experience[];
    selectedIndex: number;
    onSelect: (idx: number) => void;
}


export default function ExperienceComponent({ experiences, selectedIndex, onSelect }: ExperienceComponentProps) {
    return (
        <div>
            {experiences.map((exp, index) => (
                <ExperienceSelectItemComponent
                    key={index}
                    exp={exp}
                    isSelected={selectedIndex === index}
                    onClick={() => onSelect(index)}
                />
            ))}
        </div>
    );
}