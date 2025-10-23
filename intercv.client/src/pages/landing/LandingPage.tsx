import { Link } from "@tanstack/react-router";
import ICVLogo from "../../assets/ICVLogo.png"

export default function LandingPage() {
    return (
        <div className="d-flex flex-column justify-content-center align-items-center text-center vh-100 p-4" style={{ background: "darkgray" }}>
            <img src={ICVLogo} alt={ICVLogo} style={{ height: "300px"}} />
            <h1 className="display-4 fw-bold mb-4">
                Welcome to InterCV!
            </h1>
            <p className="lead mb-4">
                Explore the next generation of interactive CVs that showcase skills, experience, and achievements dynamically.
            </p>

            
            <Link className="btn btn-primary btn-lg mb-3" to="/en/cv/sampleCv">
                View Sample CV
            </Link>

           
            <div className="mt-4">
                <p className="mb-2 fw-semibold">
                    Do you want to make your own? Join the team and create your own ICV!
                </p>
                <button className="btn btn-outline-success btn-lg">
                    Join the Team
                </button>
            </div>
        </div>
    );
}
