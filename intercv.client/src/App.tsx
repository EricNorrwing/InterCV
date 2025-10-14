import './App.css';
import experiences from "./assets/temporaryExpList.ts";
import type {ExperienceModel} from "./models/ExperienceModel.ts";
import LandingPage from "./pages/landing/LandingPage.tsx";


function App() {
    
    return (
        <div>
            <LandingPage></LandingPage>
            <h1>Experiences!</h1>
            {experiences.map((exp: ExperienceModel, index: number) => (
                <div key={index} >
                    <h3>{exp.Summary} at {exp.Workplace}</h3>
                    <p><strong>{exp.StartDate} - {exp.EndDate}</strong></p>
                    <p>{exp.Description}</p>
                </div>
            ))}
        </div>
    );
    
}

export default App;