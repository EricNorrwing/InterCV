import ExperienceDetailsReferenceComponent from "./ExperienceDetailsReferenceComponent.tsx";
import ExperienceDetailsAchievementComponent from "./ExperienceDetailsAchievementComponent.tsx";
import type {ExperienceDetails} from "../../../models/CvModel.ts";

interface ExperienceDetailsProps {
    details: ExperienceDetails;
}
export default function ExperienceDetailsComponent ({details}: ExperienceDetailsProps) {
    return (
        <div>
            <p>{details.descriptionLong}</p>
            <ExperienceDetailsAchievementComponent achievements={details.achievements} />
            <ExperienceDetailsReferenceComponent  references={details.references}/>
        </div>
    )
}

