import type { LinkedInUrlModel } from "./URLModel.ts";

export interface UserProfile {
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
    // TODO more here if we want
}