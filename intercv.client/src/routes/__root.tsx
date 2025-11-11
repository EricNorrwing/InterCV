import { Outlet, createRootRoute } from '@tanstack/react-router'
import {Header} from "../components/header/Header.tsx";
import {errorPage} from "../pages/errorPages/errorPage.tsx";

//TODO update to accept different errors
export const Route = createRootRoute({
    component: RootComponent, 
    errorComponent: errorPage
})

function RootComponent() {
  return (
    <>
        <Header/>
        <Outlet />
    </>
  )
}
