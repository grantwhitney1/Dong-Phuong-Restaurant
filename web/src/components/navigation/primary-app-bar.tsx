import {Badge, IconButton} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";
import {
  StyledAppBar,
  StyledBox, StyledBoxLeftIcons,
  StyledBoxRightIcons,
  StyledIconButton,
  StyledToolbar,
  StyledTypography
} from "../../styles/components/navigation/primary-app-bar.ts";
import {useMutation} from "@tanstack/react-query";
import {Dispatch, SetStateAction, useState} from "react";
import {apiBaseUrl} from "../../utils/vite-env.ts";

type LoginData = {
  name: string,
  password: string
}

const useLogin = () => {
  const login = async (loginData: LoginData): Promise<LoginData> => {
    const response = await fetch(apiBaseUrl, {
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

const PrimaryAppBar = () => {
  const [loginData, setLoginData]: [LoginData, Dispatch<SetStateAction<LoginData>>] = useState({
    name: '',
    password: ''
  });
  const { mutate, isError, error } = useLogin();

  return (
    <StyledBox>
      <StyledAppBar position="static">
        <StyledToolbar>
          <StyledBoxLeftIcons>
            <StyledIconButton
              size="large"
              edge="start"
              color="inherit"
              aria-label="open drawer"
            >
              <MenuIcon/>
            </StyledIconButton>
          </StyledBoxLeftIcons>
          <StyledTypography variant="h4" noWrap>
            Dong Phuong Restaurant
          </StyledTypography>
          <StyledBoxRightIcons>
            <IconButton size="large" color="inherit">
              <Badge badgeContent={1} color="primary">
                <NotificationsIcon/>
              </Badge>
            </IconButton>
            <IconButton size="large" color="inherit">
              <AccountCircleIcon/>
            </IconButton>
          </StyledBoxRightIcons>
        </StyledToolbar>
      </StyledAppBar>
    </StyledBox>
  );
}

export default PrimaryAppBar;