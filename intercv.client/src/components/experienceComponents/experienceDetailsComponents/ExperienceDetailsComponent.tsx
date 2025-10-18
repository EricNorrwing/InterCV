import ExperienceDetailsReferenceComponent from "./ExperienceDetailsReferenceComponent.tsx";
import ExperienceDetailsAchievementComponent from "./ExperienceDetailsAchievementComponent.tsx";

export default function ExperienceDetailsComponent () {
    return (
        <div>
            //summary
            <ExperienceDetailsAchievementComponent/>
            <ExperienceDetailsReferenceComponent/>
        </div>
    )
}

