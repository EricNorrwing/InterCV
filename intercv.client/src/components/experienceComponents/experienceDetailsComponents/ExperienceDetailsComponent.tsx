import ExperienceDetailsAchievementComponent from "./ExperienceDetailsAchievementComponent.tsx";
import type {ExperienceDetails} from "../../../models/CvModel.ts";

interface ExperienceDetailsProps {
    details: ExperienceDetails;
}
export default function ExperienceDetailsComponent ({details}: ExperienceDetailsProps) {
    return (
        <div>
            <p className={"preserve-whitespace"}>{details.descriptionLong}</p>
            <ExperienceDetailsAchievementComponent achievements={details.achievements} />
        </div>
    )
}

