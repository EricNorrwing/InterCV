import type {UserProfile} from "../../models/UserModel.ts";
import { MdOutlineEmail } from "react-icons/md";
import { FaPhone } from "react-icons/fa";
import { FaLinkedin } from "react-icons/fa";
import CvTagComponent from "../cvTagComponents/CvTagComponent.tsx";

interface UserProps {
    tags: string[];
    user: UserProfile;
}

export default function CvHeaderComponent({ user, tags }: UserProps) {
    return (
        <div>
            <h1> {user.firstName} {user.lastName}</h1>
            <h5> {user.preferredProfessionalTitle}</h5>
            <CvTagComponent tags={tags}/>
            <br/>
            <h5>Contact info</h5>
            <h6><MdOutlineEmail /> {user.email}</h6>
            <h6><FaPhone /> <a href="#" onClick={(e) => { e.preventDefault(); }}>
                Request direct contact (feature not yet implemented)
            </a></h6>
            <h6><FaLinkedin /> {user.linkedInUrl.url}</h6>
            
        </div>
    );
}