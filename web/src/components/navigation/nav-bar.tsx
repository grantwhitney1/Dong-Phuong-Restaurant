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
import React, {useCallback, useState} from "react";
import {useUserStore} from "../../../store";
import {useLogout} from "../../hooks/authentication/auth-service";
import {useNavigate} from "react-router-dom";

const NavBar = () => {
  const navigate = useNavigate();
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
  };

  const handleOnClick = useCallback(() => {
    navigate("/order");
  }, [navigate]);

  return (
    <NavBarBox>
      <AuthModal tabsValue={tabsValue} setTabsValue={setTabsValue} onClose={handleCloseAuthModal} open={authModalOpen}/>
      <NavBarAppBar position="static">
        <StyledToolbar>
          <StyledBoxLeft>
            <Button
              sx={{
                color: '#A93923',
                backgroundColor: '#FFF9FA',
                transition: 'all 250ms ease-in-out',
                boxShadow: 'none',
                fontWeight: 'bold',
                margin: '0 0.5rem',
                '&:hover': {

                  color: '#A93923',
                  backgroundColor: '#FFF9FA',
                  filter: 'brightness(0.8)',
                  boxShadow: 'none',
                }
              }}
              onClick={handleOnClick}
              variant="contained"
            >
              ORDER
            </Button>
            <a
              href="https://www.dpbakery.com/wp-content/uploads/2022/03/Dong-Phuong-2021-Menu.pdf"
              target="_blank"
              rel="noopener noreferrer"
            >
              <Button
                sx={{
                  color: '#FFF9FA',
                  backgroundColor: '#A93923',
                  transition: 'all 250ms ease-in-out',
                  boxShadow: 'none',
                  fontWeight: 'bold',
                  margin: '0 0.5rem',
                  '&:hover': {
                    color: '#FFF9FA',
                    backgroundColor: '#A93923',
                    filter: 'brightness(0.8)',
                    boxShadow: 'none',
                  }
                }}
                variant="contained"
              >
                See Full Menu
              </Button>
            </a>
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