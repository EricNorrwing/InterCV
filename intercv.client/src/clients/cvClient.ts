import type {Cv} from "../models/Cv.ts";

const baseUrl = "https://localhost:7001";

export async function getCv(path: string): Promise<Cv> {
    const response = await fetch(baseUrl + path);
    return await response.json();
}
