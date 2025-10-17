import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {Header} from "./pages/landing/header/Header.tsx";
import {CVDisplayPage} from "./pages/CVDisplayPage/CVDisplayPage.tsx";


function App() {
    
    return (
        <div>
            <Header/>
            <CVDisplayPage/>
        </div>
    );
    
}

export default App;

//<LandingPage/>
//             <h1>Experiences!</h1>
//             <ExperienceList/>