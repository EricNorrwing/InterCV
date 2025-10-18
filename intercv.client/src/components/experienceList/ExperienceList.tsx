import experiences from '../../assets/temporaryExpList';
import type { Experience } from '../../models/CVModel.ts';

export default function ExperienceList() {
    return (
        <div>
            {experiences.map((exp: Experience, index: number) => (
                <div key={index}>
                    <h3>{exp.Title} at {exp.Workplace}</h3>
                    <p><strong>{exp.StartDate} - {exp.EndDate}</strong></p>
                    <p>{exp.Details}</p>
                </div>
            ))}
        </div>
    );
}