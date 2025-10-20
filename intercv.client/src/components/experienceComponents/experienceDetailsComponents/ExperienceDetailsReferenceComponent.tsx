import ReferenceCardComponent from "./ReferenceCardComponent.tsx";
import type {ExperienceReference} from "../../../models/CvModel.ts";
import "./ReferenceCardComponent.css";

interface ReferencesProps {
    references?: ExperienceReference[];
}

export default function ExperienceDetailsReferenceComponent({ references }: ReferencesProps) {
    return (
        
        <div className="container">
            <h1>References</h1>
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

