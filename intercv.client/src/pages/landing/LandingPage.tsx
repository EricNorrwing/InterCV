import {Link} from "@tanstack/react-router";

export default function LandingPage() {
    return (
        <div>
            <h1> Welcome to InterCV! Click here to browse a sample CV and view the next generation CV</h1>
            <Link className="btn" to="/en/cv/sampleCv">
                View Sample CV
            </Link>
        </div>
    );
}