import './App.css';
import LandingPage from "./pages/landing/LandingPage.tsx";
import ExperienceList from "./components/ExperienceList/ExperienceList.tsx";


function App() {
    
    return (
        <div>
            <LandingPage/>
            <h1>Experiences!</h1>
            <ExperienceList/>
        </div>
    );
    
}

export default App;