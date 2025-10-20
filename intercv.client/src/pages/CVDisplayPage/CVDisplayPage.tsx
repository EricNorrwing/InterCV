
import './temp.css'


interface CvDisplayPageProps {
    lang: string
    cvId: string
    cv: string
}

//Remove temp.css ofc
export function CVDisplayPage({ lang, cvId, cv }: CvDisplayPageProps) {
    return (
        /*
        <div className="container">
            <div className="row" >
                <div className="col-sm-8">
                    <h1>Eric Norrwing <br/> </h1>
                    <h3>Systems Engineer </h3>
                </div>
                <div className="col-sm-4 d-flex justify-content-center align-items-center">
                        <ProfilePictureCard/>
                </div>
            </div>
            <div className="row">
                <div className="col">
                    <ExperienceComponent/>
                </div>
                <div className="col">
                    <ExperienceDetailsComponent/>
                </div>
            </div>
        </div>
        
         */
        <div>
            <h1>{lang}</h1>
            <p>ID: {cvId}</p>
            <p>Data: {cv}</p> {/* will show "testtest" */}
        </div>
    )
}
