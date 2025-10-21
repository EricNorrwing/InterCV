import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';

import { Link } from '@tanstack/react-router'

const lang = navigator.language;


export function Header() {
    return (
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <div className="container-fluid">
                <Link to="/en/home" className="navbar-brand">
                    InterCV
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
                    
                    <ul className="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <Link to="/en/home" className="navbar-brand">
                                Home
                            </Link>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" href="#">Login</a>
                        </li>
                    </ul>
                        <Link
                            to="/en/cv/sampleCv"
                            className="btn btn-outline-success"
                        >
                            View sample CV
                        </Link>
                    <div className="ms-3 btn btn-outline-success">{lang}</div>
                </div>
            </div>
        </nav>
    );
}
