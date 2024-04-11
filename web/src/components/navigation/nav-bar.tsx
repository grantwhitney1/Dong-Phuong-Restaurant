import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import {Button, IconButton} from "@mui/material";
import {
  NavBarAppBar,
  NavBarBox,
  StyledBoxLeft,
  StyledBoxRight,
  StyledH1,
  StyledToolbar
} from "../../styles/components/navigation/nav-bar";
import AuthModal from "../authentication/auth-modal";
import {useState} from "react";

const NavBar = ({user}: { user: { email: string, isAuthenticated: boolean } }) => {
  const [open, setOpen] = useState(false);
  const [tabsValue, setTabsValue] = useState('auth-modal-sign-in');

  const handleOpenSignIn = () => {
    setTabsValue('auth-modal-sign-in');
    setOpen(true);
  }

  const handleOpenSignUp = () => {
    setTabsValue('auth-modal-sign-up');
    setOpen(true);
  }

  const handleClose = () => {
    setOpen(false);
  }

  return (
    <NavBarBox>
      <AuthModal tabsValue={tabsValue} setTabsValue={setTabsValue} onClose={handleClose} open={open}/>
      <NavBarAppBar position="static">
        <StyledToolbar>
          <StyledBoxLeft>
          </StyledBoxLeft>
          <StyledH1>
            Dong Phuong Restaurant
          </StyledH1>
          <StyledBoxRight>
            {
              !user.isAuthenticated ?
                <>
                  <Button
                    style={{marginLeft: '0.25rem', marginRight: '0.25rem'}}
                    color="inherit"
                    onClick={handleOpenSignIn}
                  >
                    Sign In
                  </Button>
                  <Button
                    style={{marginLeft: '0.25rem', marginRight: '0.25rem'}}
                    color="inherit"
                    onClick={handleOpenSignUp}
                  >
                    Sign Up
                  </Button>
                </> :
                <IconButton size="large" color="inherit">
                  <AccountCircleIcon/>
                </IconButton>
            }
          </StyledBoxRight>
        </StyledToolbar>
      </NavBarAppBar>
    </NavBarBox>
  );
}

export default NavBar;