import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import {Button, IconButton, Menu, MenuItem} from "@mui/material";
import {
  NavBarAppBar,
  NavBarBox,
  StyledBoxLeft,
  StyledBoxRight,
  StyledH1,
  StyledToolbar
} from "../../styles/components/navigation/nav-bar";
import AuthModal from "../authentication/auth-modal";
import React, {useState} from "react";
import {useUserStore} from "../../../store";
import {useLogout} from "../../hooks/authentication/auth-service";

const NavBar = () => {
  const user = useUserStore(state => state.user);
  const [authModalOpen, setAuthModalOpen] = useState(false);
  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
  const [tabsValue, setTabsValue] = useState('auth-modal-sign-in');
  const {mutate} = useLogout();

  const handleOpenSignInAuthModal = () => {
    setTabsValue('auth-modal-sign-in');
    setAuthModalOpen(true);
  };

  const handleOpenSignUpAuthModal = () => {
    setTabsValue('auth-modal-sign-up');
    setAuthModalOpen(true);
  };

  const handleCloseAuthModal = () => {
    setAuthModalOpen(false);
  };

  const handleOpenAuthMenu = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget);
  };

  const handleCloseAuthMenu = () => {
    setAnchorEl(null);
  };

  const handleLogout = () => {
    mutate();
    setAnchorEl(null);
  }


  return (
    <NavBarBox>
      <AuthModal tabsValue={tabsValue} setTabsValue={setTabsValue} onClose={handleCloseAuthModal} open={authModalOpen}/>
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
                    onClick={handleOpenSignInAuthModal}
                  >
                    Sign In
                  </Button>
                  <Button
                    style={{marginLeft: '0.25rem', marginRight: '0.25rem'}}
                    color="inherit"
                    onClick={handleOpenSignUpAuthModal}
                  >
                    Sign Up
                  </Button>
                </> :
                <>
                  <Menu
                    anchorEl={anchorEl}
                    open={Boolean(anchorEl)}
                    onClose={handleCloseAuthMenu}
                  >
                    <MenuItem onClick={handleLogout}>
                      Sign Out
                    </MenuItem>
                  </Menu>
                  <IconButton onClick={handleOpenAuthMenu} size="large" color="inherit">
                    <AccountCircleIcon/>
                  </IconButton>
                </>
            }
          </StyledBoxRight>
        </StyledToolbar>
      </NavBarAppBar>
    </NavBarBox>
  );
}

export default NavBar;