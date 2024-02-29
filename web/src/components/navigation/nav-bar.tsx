import {Badge, Button, IconButton, TextField} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";
import {
  NavBarAppBar,
  NavBarBox, NavBarBoxLeft,
  NavBarBoxRight,
  NavBarIconButton,
  NavBarToolbar,
  NavBarTypography
} from "../../styles/components/navigation/nav-bar.ts";
import {useMutation} from "@tanstack/react-query";
import {Dispatch, SetStateAction, useState} from "react";
import {apiBaseUrl} from "../../utils/vite-env.ts";

type LoginData = {
  name: string,
  password: string
}

const useLogin = () => {
  const login = async (loginData: LoginData): Promise<LoginData> => {
    const response = await fetch(`${apiBaseUrl}login?useCookies=true`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(loginData)
    })
    return response.json();
  }
  return useMutation({
    mutationFn: login,
  });
}

const NavBar = () => {
  const [loginData, setLoginData]: [LoginData, Dispatch<SetStateAction<LoginData>>] = useState({
    email: '',
    password: ''
  });
  const { mutate, isError, error } = useLogin();

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setLoginData({ ...loginData, [name]: value });
  }

  const handleSubmit = (event) => {
    event.preventDefault();
    mutate(loginData);
  }

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <TextField
          label="Name"
          variant="outlined"
          name="name"
          value={loginData.name}
          onChange={handleInputChange}
        />
        <TextField
          label="Password"
          variant="outlined"
          type="password"
          name="password"
          value={loginData.password}
          onChange={handleInputChange}
        />
        <Button type="submit" variant="contained">
          Login
        </Button>
        {isError && <div>Error: {error.message}</div>}
      </form>
      <NavBarBox>
        <NavBarAppBar position="static">
          <NavBarToolbar>
            <NavBarBoxLeft>
              <NavBarIconButton
                size="large"
                edge="start"
                color="inherit"
                aria-label="open drawer"
              >
                <MenuIcon/>
              </NavBarIconButton>
            </NavBarBoxLeft>
            <NavBarTypography variant="h4" noWrap>
              Dong Phuong Restaurant
            </NavBarTypography>
            <NavBarBoxRight>
              <IconButton size="large" color="inherit">
                <Badge badgeContent={1} color="primary">
                  <NotificationsIcon/>
                </Badge>
              </IconButton>
              <IconButton size="large" color="inherit">
                <AccountCircleIcon/>
              </IconButton>
            </NavBarBoxRight>
          </NavBarToolbar>
        </NavBarAppBar>
      </NavBarBox>
    </div>
  );
}

export default NavBar;