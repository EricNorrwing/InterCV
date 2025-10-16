import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {Header} from "./pages/landing/header/Header.tsx";
import CVLayout from "./layouts/CVLayout/CVLayout.tsx";


function App() {
    
    return (
        <div>
            <Header/>
            <CVLayout/>
        </div>
    );
    
}

export default App;

//<LandingPage/>
//             <h1>Experiences!</h1>
//             <ExperienceList/>