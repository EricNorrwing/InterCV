import type {UserProfile} from "../../models/UserModel.ts";

interface userProps {
    profile: UserProfile,
    
}
function ProfilePage({profile}: userProps) {
    return <div> Welcome {profile.firstName}!</div>
}

export default ProfilePage;