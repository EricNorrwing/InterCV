import { createFileRoute } from '@tanstack/react-router'
import { CVDisplayPage } from '../../../pages/CVDisplayPage/CVDisplayPage'
import {useQuery} from "@tanstack/react-query";
import {getTest} from "../../../clients/cvClient.ts";




export const Route = createFileRoute('/en/cv/sampleCv')({
  component: RouteComponent,
})

function RouteComponent() {
    
    const { data, isLoading, error } = useQuery<String>({
        queryKey: ['cv', 'sampleCv'],
        queryFn: () => getTest('/cv/test'), 
    })

    //TODO fix, try test for now
    if (isLoading) return <p>Loading CV...</p>
    if (error) return <p>Error loading CV: {(error as Error).message}</p>
    
    return <CVDisplayPage lang="English" cvId="sampleCv" cv={data!} />
}