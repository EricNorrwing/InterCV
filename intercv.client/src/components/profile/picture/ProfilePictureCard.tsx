import AnonPic from "../../../assets/Anon pic.png";
import "./ProfilePicture.css"

interface ProfilePictureUrlProps {
    pictureUrl?: string;
}

export function ProfilePictureCard({ pictureUrl }: ProfilePictureUrlProps) {
    return (
        <div className="d-flex justify-content-center">
            <div className="card profile-card">
                <img
                    src={pictureUrl ? pictureUrl : AnonPic}
                    alt="Profile"
                    className="profile-card-img"
                />
            </div>
        </div>
    );
}