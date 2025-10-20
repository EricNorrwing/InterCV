import type {UserData, UserProfile} from "./UserModel.ts";
import type {InterCVUrlModel} from "./UrlModel.ts";

export interface CvModel {
    experiences: Experience[],
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
    name: string,
    title: string,
    linkedInUrl: string,
    email: string,
    phone: string,
    interCVProfile: InterCVUrlModel
}



