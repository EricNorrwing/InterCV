import type {UserData, UserProfile} from "./UserModel.ts";
import type {InterCVUrlModel} from "./UrlModel.ts";

export interface CvModel {
    experiences: Experience[],
    educations: Education[],
    aboutMe: string,
    user: UserProfile,
    userData?: UserData[],
}

export interface Experience {
    workplace: string,
    title: string,
    startDate: Date,
    endDate: Date,
    descriptionShort: string,
    details: ExperienceDetails;
}

export interface ExperienceDetails {
    descriptionLong: string,
    achievements: string[],
    references?: ExperienceReference[]
}

export interface ExperienceReference {
    firstName: string,
    lastName: string,
    title: string,
    linkedInUrl: string,
    email: string,
    phone: string,
    interCVProfile: InterCVUrlModel
}
export interface Education {
    formal:boolean,
    educationName: string,
    title?: string,
    provider: string,
    startDate: Date,
    endDate: Date,
    description: string,
    verificationUrl?: string
}



