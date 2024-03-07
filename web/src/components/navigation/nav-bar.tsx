import {Badge, Button, IconButton} from "@mui/material";
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
      <Button onClick={handleOpen}>Open modal</Button>
      <AuthModal onClose={handleClose} open={open}/>
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
  );
}

export default NavBar;