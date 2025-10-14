// ExperienceList.tsx
import experiences from './temporaryExpList';
import { ExperienceModel } from './ExperienceModel';

export default function ExperienceList() {
    return (
        <div>
            {experiences.map((exp: ExperienceModel, index: number) => (
                <div key={index} style={{ marginBottom: '1rem' }}>
                    <h3>{exp.Summary} at {exp.Workplace}</h3>
                    <p><strong>{exp.StartDate} - {exp.EndDate}</strong></p>
                    <p>{exp.Description}</p>
                </div>
            ))}
        </div>
    );
}