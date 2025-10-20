import type {CvModel} from "../models/CvModel.ts";

const baseUrl = "http://localhost:5172";

export async function getCv(path: string): Promise<CvModel> {
    const response = await fetch(baseUrl + path);
    return await response.json();
}
