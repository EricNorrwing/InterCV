import ExperienceList from "../../components/ExperienceList/ExperienceList.tsx";
import './temp.css'
import AnonPic from '../../assets/Anon pic.png'

export function CVDisplayPage() {
    return (
        <div className="container">
            <div className="row">
                <div className="col-sm-8">
                    <h1>Eric Norrwing <br/>  Systems Engineer </h1>
                </div>
                <div className="col-sm-4" id={"pictureFrame"}>
                    <img src={AnonPic} alt="Anonymous" className="img-fluid" />
                </div>
            </div>
            <div className="row">
                <div className="col">
                    <ExperienceList/>
                </div>
                <div className="col">
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore
                    et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut
                    aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
                    cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                    culpa qui officia deserunt mollit anim id est laborum."
                </div>
            </div>
        </div>
    )
}
