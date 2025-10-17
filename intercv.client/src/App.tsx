import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

import {CVDisplayPage} from "./pages/CVDisplayPage/CVDisplayPage.tsx";
import {Header} from "./components/header/Header.tsx";


function App() {
    
    return (
        <div>
            <Header/>
            <CVDisplayPage/>
        </div>
    );
    
}

export default App;
