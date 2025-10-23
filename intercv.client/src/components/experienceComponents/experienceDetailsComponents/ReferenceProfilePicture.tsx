import AnonPic from "../../../assets/Anon pic.png";
import "./ReferenceCardComponent.css"

interface ProfilePictureUrlProps {
    pictureUrl?: string;
}

export function ReferenceProfilePicture({ pictureUrl }: ProfilePictureUrlProps) {
    return (
        <div id="reference-picture-wrapper">
            <img
                src={pictureUrl ? pictureUrl : AnonPic}
                alt="Profile"
                id="reference-profile-picture"
            />
        </div>
    );
}
