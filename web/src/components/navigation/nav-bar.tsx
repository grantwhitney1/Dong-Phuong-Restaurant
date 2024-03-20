import {Badge, IconButton} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";
import {
  NavBarAppBar,
  NavBarBox,
  StyledBoxLeft,
  StyledBoxRight,
  StyledH1,
  StyledIconButton,
  StyledToolbar
} from "../../styles/components/navigation/nav-bar";
import AuthModal from "../authentication/auth-modal";
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
          <StyledH1>
            Dong Phuong Restaurant
          </StyledH1>
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