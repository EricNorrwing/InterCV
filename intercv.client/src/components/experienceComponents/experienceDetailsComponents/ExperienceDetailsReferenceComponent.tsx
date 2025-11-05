import ReferenceCardComponent from "./ReferenceCardComponent.tsx";
import type {ExperienceReference} from "../../../models/Cv.ts";
import "./ReferenceCardComponent.css";

interface ReferencesProps {
    references?: ExperienceReference[];
}

export default function ExperienceDetailsReferenceComponent({ references }: ReferencesProps) {
    return (
        
        <div className="container">
            <div className="row" id="ExperienceDetailsReferenceComponentWrapper">
                {references ? (
                    references.map((reference, index) => (
                        <ReferenceCardComponent reference={reference} key={index}/>
                    ))
                ) : null}
            </div>
        </div>
    )
}

