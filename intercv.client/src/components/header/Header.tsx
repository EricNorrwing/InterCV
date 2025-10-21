import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import ICVLogo from "../../assets/ICVLogo.png"
import "./Header.css"

import { Link } from '@tanstack/react-router'

const lang = navigator.language;


export function Header() {
    return (
        <nav className="navbar navbar-expand-lg bg-dark">
            <div className="container-fluid">
                <Link to="/en/home" className="navbar-brand">
                    <img id="logo" src={ICVLogo} alt="logo" />
                </Link>
                <button
                    className="navbar-toggler"
                    type="button"
                    data-bs-toggle="collapse"
                    data-bs-target="#navbarSupportedContent"
                    aria-controls="navbarSupportedContent"
                    aria-expanded="false"
                    aria-label="Toggle navigation"
                >
                    <span className="navbar-toggler-icon"></span>
                </button>
                <form>
                    <div className="collapse navbar-collapse" id="navbarSupportedContent">
                        
                        <ul className="navbar-nav ms-auto mb-2 mb-lg-0">
                            <Link
                                to="/en/cv/sampleCv"
                                className="btn btn-outline-success"
                            >
                                Login
                            </Link>
                        </ul>
                            <Link
                                to="/en/cv/sampleCv"
                                className="btn btn-outline-success"
                            >
                                View sample CV
                            </Link>
                        <div className="ms-3 btn btn-outline-success">{lang}</div>
                    </div>
                </form>
            </div>
        </nav>
    );
}
