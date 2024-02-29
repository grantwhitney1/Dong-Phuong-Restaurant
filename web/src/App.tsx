import {Route, Routes} from "react-router-dom";
import Home from "./pages/home";
import NotFound from "./pages/not-found";
import NavBar from "./components/navigation/nav-bar.tsx";
import {QueryClient, QueryClientProvider} from "@tanstack/react-query";

const queryClient = new QueryClient();

const App = () => {
  return (
    <QueryClientProvider client={queryClient}>
      <NavBar/>
      <Routes>
        <Route path="/" element={<Home/>}/>
        <Route path="*" element={<NotFound/>}/>
      </Routes>
    </QueryClientProvider>
  );
}

export default App