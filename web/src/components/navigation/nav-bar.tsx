import {Badge, IconButton} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";
import {
  NavBarAppBar,
  NavBarBox,
  StyledBoxLeft,
  StyledBoxRight,
  StyledIconButton,
  StyledToolbar,
  StyledTypography
} from "../../styles/components/navigation/nav-bar.ts";
import AuthModal from "../authentication/auth-modal.tsx";
import {useState} from "react";

const NavBar = () => {
  const [open, setOpen] = useState(false);
  const handleOpen = () => {
    setOpen(true);
  }

  const handleClose = () => {
    setOpen(false);
  }

  return (
    <NavBarBox>
      <AuthModal onClose={handleClose} open={open}/>
      <NavBarAppBar position="static">
        <StyledToolbar>
          <StyledBoxLeft>
            <StyledIconButton
              size="large"
              edge="start"
              color="inherit"
              aria-label="open drawer"
            >
              <MenuIcon/>
            </StyledIconButton>
          </StyledBoxLeft>
          <StyledTypography variant="h4" noWrap>
            Dong Phuong Restaurant
          </StyledTypography>
          <StyledBoxRight>
            <IconButton size="large" color="inherit">
              <Badge badgeContent={1} color="primary">
                <NotificationsIcon/>
              </Badge>
            </IconButton>
            <IconButton size="large" color="inherit" onClick={handleOpen}>
              <AccountCircleIcon/>
            </IconButton>
          </StyledBoxRight>
        </StyledToolbar>
      </NavBarAppBar>
    </NavBarBox>
  );
}

export default NavBar;