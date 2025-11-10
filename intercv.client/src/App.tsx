import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {createRouter, RouterProvider} from "@tanstack/react-router"
import {routeTree} from "./routeTree.gen.ts";
import {QueryClient, QueryClientProvider} from "@tanstack/react-query";
import { Auth0Provider} from "@auth0/auth0-react";

const router = createRouter({ routeTree });
const queryClient = new QueryClient();

function App() {
    
    return (
        <Auth0Provider 
            domain="intercv.eu.auth0.com" 
            clientId="2UshsGMGoXCs90e5w0WkksP3Hji6tWG6"
            authorizationParams={{
                redirect_uri: window.location.origin
            }}
            >
            <QueryClientProvider client={queryClient}>
                <RouterProvider router={router}/>
            </QueryClientProvider>
        </Auth0Provider>
    )
}

export default App;
