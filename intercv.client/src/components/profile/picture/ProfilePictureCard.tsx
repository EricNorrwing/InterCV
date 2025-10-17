import AnonPic from "../../../assets/Anon pic.png";

//TODO This component needs to better adapted to various picture sizes and what not. 
export function ProfilePictureCard() {
    return (
        <div className="d-flex justify-content-center">
            <div className="card h-100 w-100">
                <img
                    src={AnonPic}
                    alt="Profile"
                    className="card-img-top h-100 w-100 object-fit-cover"
                />
            </div>
        </div>
    );
}