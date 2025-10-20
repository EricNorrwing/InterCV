import type { LinkedInUrlModel } from "./UrlModel.ts";

export interface UserProfile {
    profilePictureUrl: string,
    preferredProfessionalTitle: string,
    firstName: string;
    lastName: string;
    email: string;
    phone: string;
    linkedInUrl: LinkedInUrlModel;
}

export interface UserData {
    visitors: UserProfile[],
    lastLogin: Date,
    lastVisited: Date,
}