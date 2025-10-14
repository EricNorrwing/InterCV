import experiences from '../../assets/temporaryExpList';
import type { ExperienceModel } from '../../models/ExperienceModel.ts';

export default function ExperienceList() {
    return (
        <div>
            {experiences.map((exp: ExperienceModel, index: number) => (
                <div key={index}>
                    <h3>{exp.Summary} at {exp.Workplace}</h3>
                    <p><strong>{exp.StartDate} - {exp.EndDate}</strong></p>
                    <p>{exp.Description}</p>
                </div>
            ))}
        </div>
    );
}