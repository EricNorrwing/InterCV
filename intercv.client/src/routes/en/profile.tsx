import { createFileRoute } from '@tanstack/react-router'
import ProfilePage from "../../pages/profilePage/profilePage.tsx";
import {useQuery} from "@tanstack/react-query";
import type {Cv} from "../../models/Cv.ts";
import {getCv} from "../../clients/cvClient.ts";
import {CvDisplayPage} from "../../pages/CVDisplayPage/CvDisplayPage.tsx";
import {errorPage} from "../../pages/errorPages/errorPage.tsx";


function profileClient() {
  
  const { data, isLoading, error } = useQuery<Cv>({
    queryKey: ['user', 'userProfile'],
    queryFn: () => getCv('/auth/profile'),
  })

  if (isLoading) return <p>Loading CV...</p>
  if (error) return <p>Error loading CV: {(error as Error).message}</p>

  return <CvDisplayPage cv={data!} />
}

export const Route = createFileRoute('/en/profile')({
  component: <ProfilePage profile={profileClient}/>,
  loader: () => {someloader},
  errorComponent: errorPage
})

