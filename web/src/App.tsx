import {Route, Routes} from "react-router-dom";
import Home from "./pages/home";
import NotFound from "./pages/not-found";
import PrimaryAppBar from "./components/navigation/primary-app-bar";

const App = () => {
  return (
    <>
      <PrimaryAppBar/>
      <Routes>
        <Route path="/" element={<Home/>}/>
        <Route path="*" element={<NotFound/>}/>
      </Routes>
    </>
  );
}

export default App