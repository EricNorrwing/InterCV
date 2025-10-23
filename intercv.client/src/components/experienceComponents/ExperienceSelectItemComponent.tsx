import type {Experience} from "../../models/CvModel.ts";

interface ExperienceItemProps {
    exp: Experience;
    isSelected: boolean;
    onClick: () => void;
}

export default function ExperienceSelectItemComponent({ exp, isSelected, onClick }: ExperienceItemProps) {
    return (
        <div
            onClick={onClick}
            style={{
                cursor: "pointer",
                border: "1px solid transparent",
                borderColor: isSelected ? "#000000" : "transparent",
                backgroundColor: isSelected ? "#f8f9fa" : "transparent",
                padding: "0.5rem",
                borderRadius: "4px",
                marginBottom: "0.5rem",
                transition: "border-color 0.2s ease, background-color 0.2s ease"
            }}
        >
            <h4>{exp.title} at {exp.workplace}</h4>
            <p>
                {new Date(exp.startDate).toLocaleDateString()} - {new Date(exp.endDate).toLocaleDateString()}
            </p>
            <p>{exp.descriptionShort}</p>
        </div>
    );
}