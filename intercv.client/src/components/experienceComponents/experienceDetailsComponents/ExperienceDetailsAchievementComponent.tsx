interface AchievementProps {
    achievements: string[]
}
export default function ExperienceDetailsAchievementComponent({ achievements }: AchievementProps) {
    return (
        <div>
            <ul>
                {achievements.map((achievement, index) => (
                    <li key={index}>{achievement}</li>
                ))}
            </ul>
        </div>
    );
}

