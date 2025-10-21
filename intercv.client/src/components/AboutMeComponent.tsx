interface AboutMeProps {
    aboutMe: string;
}

export default function AboutMeComponent ({aboutMe}: AboutMeProps) {
    return (
        <div>
            <h1>HELLO</h1>
            <p className={"preserve-whitespace"}>{aboutMe}</p>
        </div>
    )
}