import AnonPic from "../../../assets/Anon pic.png";

interface ProfilePictureUrlProps {
    pictureUrl: string;
}

export function ProfilePictureCard(pictureUrl: ProfilePictureUrlProps) {
    return (
        <div className="d-flex justify-content-center">
            <div className="card h-100 w-100">
                {/*TODO fix this so that it accepts picture or uses anon if not */}
                <img
                    src={pictureUrl ? AnonPic : AnonPic}
                    alt="Profile"
                    className="card-img-top h-100 w-100 object-fit-cover"
                />
            </div>
        </div>
    );
}