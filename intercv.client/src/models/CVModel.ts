import type {UserData, UserProfile} from "./UserModel.ts";
import type {InterCVUrlModel} from "./URLModel.ts";

export interface CVModel {
    experiences: Experience[],
    user: UserProfile,
    userData: UserData[],
}

export interface Experience {
    workplace: string,
    title: string,
    startDate: Date,
    endDate: Date,
    details: ExperienceDetails,
    descriptionShort: string;
}

export interface ExperienceDetails {
    descriptionLong: string,
    achievements: string[],
    references: ExperienceReference[]
}

export interface ExperienceReference {
    name: string,
    title: string,
    linkedInUrl: string,
    email: string,
    phone: string,
    interCVProfile: InterCVUrlModel
}



