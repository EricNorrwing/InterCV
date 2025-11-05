import ExperienceDetailsAchievementComponent from "./ExperienceDetailsAchievementComponent.tsx";

interface ExperienceDetailsProps {
    description?: string;
    achievements?: string[];
}

export default function ExperienceDetailsComponent({ description, achievements }: ExperienceDetailsProps) {
    return (
        <div>
            {description && <p className="preserve-whitespace">{description}</p>}
            {achievements && <ExperienceDetailsAchievementComponent achievements={achievements} />}
        </div>
    );
}