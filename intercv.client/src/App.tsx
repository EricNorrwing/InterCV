import './App.css';
import LandingPage from "./pages/landing/LandingPage.tsx";
import ExperienceList from "./components/ExperienceList/ExperienceList.tsx";
import 'bootstrap/dist/css/bootstrap.min.css';
import {Header} from "./pages/landing/header/Header.tsx";


function App() {
    
    return (
        <div>
            <Header/>
            <LandingPage/>
            <h1>Experiences!</h1>
            <ExperienceList/>
        </div>
    );
    
}

export default App;