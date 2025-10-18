import { createFileRoute } from '@tanstack/react-router'
import { CVDisplayPage } from '../../../pages/CVDisplayPage/CVDisplayPage'

const queryOptions = (cvId) => 
    queryOptions({
      queryKey: [cvId],
      queryFn: () => fetchSampleCv(sampleId),
      
    });

export const Route = createFileRoute('/en/cv/sampleCv')({
  component: RouteComponent,
})

function RouteComponent() {
  return <CVDisplayPage lang="English" cvId="sampleCv" />
}