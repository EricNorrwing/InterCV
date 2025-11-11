import { useAuth0 } from "@auth0/auth0-react";
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import ICVLogo from "../../assets/ICVLogo.png";
import "./Header.css";

import { Link } from '@tanstack/react-router';

const lang = navigator.language;

export function Header() {
    const { loginWithRedirect, logout, isAuthenticated, user } = useAuth0();

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

                <div className="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul className="navbar-nav ms-auto mb-2 mb-lg-0 d-flex align-items-center">
                        {!isAuthenticated ? (
                            <button
                                className="btn btn-outline-success me-2"
                                onClick={() => loginWithRedirect()}
                            >
                                Log In
                            </button>
                        ) : (
                            <button
                                className="btn btn-outline-danger me-2"
                                onClick={() => logout({ logoutParams: { returnTo: window.location.origin } })}
                            >
                                Log Out
                            </button>
                        )}
                        <Link
                            to="/en/cv/sampleCv"
                            className="btn btn-outline-success me-2"
                        >
                            View sample CV
                        </Link>
                        <div className="ms-3 btn btn-outline-success">{lang}</div>
                    </ul>
                </div>
            </div>
        </nav>
    );
}
