import type {UserData, UserProfile} from "./UserModel.ts";

export interface Cv {
    experiences: Experience[],
    tags: string[],
    educations: Education[],
    aboutMe: string,
    profile: UserProfile,
    userData?: UserData[]
}

export interface Experience {
    workplace: string,
    title: string,
    startDate: Date,
    endDate: Date | null,
    descriptionShort: string,
    description?: string,
    achievements?: string[],
    references?: ExperienceReference[]
}

export interface ExperienceReference {
    firstName: string,
    lastName: string,
    title?: string,
    linkedInUrl?: string,
    pictureUrl?: string,
    email?: string,
    phone?: string
}

export interface Education {
    type: EducationType,
    institution: string,
    title: string,
    startDate: Date,
    endDate: Date | null,
    description?: string,
    verification?: string
}
export interface CvTag {
    id: string;
    userId: string;
    user: object;
    name: string;
}

export type EducationType =
    | "HighSchool"
    | "Associate"
    | "Bachelor"
    | "Master"
    | "Doctorate"
    | "Certificate"
    | "Diploma"
    | "Other";
