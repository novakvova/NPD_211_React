import './App.css'
import axios from "axios";
import {useEffect, useState} from "react";
import {createLogger} from "vite";

interface ICategoryItem {
    id: number;
    name: string;
    image: string;
    description: string;
}


function App() {

    const [list, setList] = useState<ICategoryItem[]>();

    useEffect(() => {
        console.log("Use Effect Render");
        axios.get<ICategoryItem[]>("http://localhost:5189/api/categories")
            .then(resp => {
                console.log("resp", resp.data);
            });
    }, []);

    console.log("Render compoent");

    return (
        <>
            <h1>Ковбаса :)</h1>
        </>
    )
}

export default App
