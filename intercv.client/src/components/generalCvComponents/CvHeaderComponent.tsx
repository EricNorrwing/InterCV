import type {UserProfile} from "../../models/UserModel.ts";

interface UserProps {
    user: UserProfile;
}

export default function CvHeaderComponent({ user }: UserProps) {
    return (
        <div>
            <h1>{user.firstName} {user.lastName}</h1><br/>
            <h3>{user.preferredProfessionalTitle}</h3><br/>
            <br/>
            <h3>Contact info</h3>
            <h6>{user.email}</h6><br/>
            <h6>{user.phone}</h6><br/>
            <h6>{user.linkedInUrl.linkedInUrl}</h6><br/>
        </div>
    );
}