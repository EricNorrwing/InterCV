import { createFileRoute } from '@tanstack/react-router'
import { CvDisplayPage } from '../../../pages/CVDisplayPage/CvDisplayPage.tsx'
import {useQuery} from "@tanstack/react-query";
import {getCv} from "../../../clients/cvClient.ts";
import type {Cv} from "../../../models/Cv.ts";

export const Route = createFileRoute('/en/cv/sampleCv')({
  component: RouteComponent,
})
//TODO fix error handling
function RouteComponent() {
    
    const { data, isLoading, error } = useQuery<Cv>({
        queryKey: ['cv', 'sampleCv'],
        queryFn: () => getCv('/cv/sample-cv'),
    })
    
    if (isLoading) return <p>Loading CV...</p>
    if (error) return <p>Error loading CV: {(error as Error).message}</p>
    
    return <CvDisplayPage cv={data!} />
}