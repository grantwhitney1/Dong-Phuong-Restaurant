import {Route, Routes} from "react-router-dom";
import Home from "./pages/home";
import NotFound from "./pages/not-found";
import PrimaryAppBar from "./components/navigation/primary-app-bar";
import {QueryClient, QueryClientProvider} from "@tanstack/react-query";

const queryClient = new QueryClient();

const App = () => {
  return (
    <QueryClientProvider client={queryClient}>
      <PrimaryAppBar/>
      <Routes>
        <Route path="/" element={<Home/>}/>
        <Route path="*" element={<NotFound/>}/>
      </Routes>
    </QueryClientProvider>
  );
}

export default App