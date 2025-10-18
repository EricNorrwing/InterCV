import { createFileRoute } from '@tanstack/react-router'
import LandingPage from "../../pages/landing/LandingPage.tsx";

export const Route = createFileRoute('/en/home')({
  component: LandingPage,
})


