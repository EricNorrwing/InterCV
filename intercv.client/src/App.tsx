import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {createRouter, RouterProvider} from "@tanstack/react-router"
import {routeTree} from "./routeTree.gen.ts";
import {QueryClient, QueryClientProvider} from "@tanstack/react-query";

const router = createRouter({ routeTree });
const queryClient = new QueryClient();

function App() {
    
    return (
        <QueryClientProvider client={queryClient}>
            <RouterProvider router={router}/>
        </QueryClientProvider>
    )
}

export default App;
