import AnonPic from "../../../assets/Anon pic.png";

//TODO This component needs to better adapted to various picture sizes and what not. 
export function ProfilePictureCard() {
    return (
        <div className="d-flex justify-content-center">
            <div className="card" style={{ width: "150px" }}>
                <img
                    src={AnonPic}
                    alt="Profile"
                    className="card-img-top mx-auto d-block"
                    style={{
                        width: "200px",
                        height: "230px",
                        objectFit: "cover",
                        backgroundColor: "green",
                    }}
                />
            </div>
        </div>
    );
}