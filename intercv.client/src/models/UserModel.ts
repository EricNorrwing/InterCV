export interface UserProfile {
    profilePictureUrl?: string,
    preferredProfessionalTitle?: string,
    firstName: string,
    lastName: string,
    email?: string,
    phone?: string,
    linkedInUrl?: string
}

export interface UserData {
    visitors: UserProfile[],
    lastLogin: Date,
    lastVisited: Date
}