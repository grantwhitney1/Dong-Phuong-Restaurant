import {Route, Routes} from "react-router-dom";
import Home from "./pages/home";
import NotFound from "./pages/not-found";
import NavBar from "./components/navigation/nav-bar";
import {useUserStore} from "../store";
import {useGetManageInfo} from "./hooks/authentication/auth-service";
import {useEffect} from "react";

const App = () => {
  const user = useUserStore(state => state.user);
  const {isLoading, error, data} = useGetManageInfo();

  useEffect(() => {
    if (!isLoading && !error && data && data.email) {
      useUserStore.getState().setUser({email: data.email, isAuthenticated: true});
    } else if (error) {
      alert(error.message);
    }
  }, [isLoading, error, data]);

  return (
    <>
      <NavBar user={user}/>
      <Routes>
        <Route path="/" element={<Home/>}/>
        <Route path="*" element={<NotFound/>}/>
      </Routes>
    </>
  );
}

export default App