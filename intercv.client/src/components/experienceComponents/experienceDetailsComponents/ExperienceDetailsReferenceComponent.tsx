import ReferenceCardComponent from "./ReferenceCardComponent.tsx";
import type {ExperienceReference} from "../../../models/CvModel.ts";

interface ReferencesProps {
    references?: ExperienceReference[];
}

export default function ExperienceDetailsReferenceComponent({ references }: ReferencesProps) {
    return (
        <div className="container">
            {references ? (
                references.map((reference, index) => (
                    <ReferenceCardComponent reference={reference} key={index}/>
                ))
            ) : null}
        </div>
    )
}

