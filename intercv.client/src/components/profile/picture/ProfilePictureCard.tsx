import AnonPic from "../../../assets/Anon pic.png";

export function ProfilePictureCard() {
    return (
        <div style={{ display: "flex", justifyContent: "center" }}>
            <div className="card" >
                <img className="card-img-top" src={AnonPic} alt="Card image cap" style={{height: "250px",width: "150px", justifyContent:"center", backgroundColor: "green"}} />
            </div>
        </div>
    )
}