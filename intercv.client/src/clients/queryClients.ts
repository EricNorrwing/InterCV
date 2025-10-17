import { QueryClient } from "@tanstack/react-query";

export function baseClient(path: string) {
    const queryClient = new QueryClient();
    return queryClient;
}