import type {CVModel} from "../models/CVModel.ts";

const baseUrl = "http://localhost:5172";

export async function getCv(path: string): Promise<CVModel> {
    const response = await fetch(baseUrl + path);
    return await response.json();
}