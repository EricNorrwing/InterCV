import { createFileRoute } from '@tanstack/react-router'
import { CVDisplayPage } from '../../../pages/CVDisplayPage/CVDisplayPage'
import {useQuery} from "@tanstack/react-query";
import {getCv} from "../../../clients/cvClient.ts";
import type {CvModel} from "../../../models/CvModel.ts";




export const Route = createFileRoute('/en/cv/sampleCv')({
  component: RouteComponent,
})

function RouteComponent() {

    const { data, isLoading, error } = useQuery<CvModel>({
        queryKey: ['cv', 'sampleCv'],
        queryFn: () => getCv('/cv/sampleCv'),
    })
    
    if (isLoading) return <p>Loading CV...</p>
    if (error) return <p>Error loading CV: {(error as Error).message}</p>
    
    return <CVDisplayPage cv={data!} />
}