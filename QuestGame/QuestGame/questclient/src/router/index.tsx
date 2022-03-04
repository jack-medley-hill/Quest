import React from "react";
import { BrowserRouter, Route, Routes} from "react-router-dom";
import Home from "../Home";
const AppRouter = () => (
    <BrowserRouter>
        <div>
            <Routes>
                <Route path="/" element={<Home />} />
            </Routes>
        </div>
    </BrowserRouter>
);

export default AppRouter;