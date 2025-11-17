import type {UserProfile} from "../../models/UserModel.ts";

interface userProps {
    userProfile: UserProfile,
    
}
function ProfilePage({userProfile}: userProps) {
    return <div>Welcome  {userProfile.firstName}!</div>
}

export default ProfilePage;