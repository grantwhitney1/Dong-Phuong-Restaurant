import {SyntheticEvent, useState} from "react";
import {Box, Tabs} from "@mui/material";
import CloseRoundedIcon from '@mui/icons-material/CloseRounded';
import {TabContext} from '@mui/lab';
import SignIn from "./sign-in";
import SignUp from "./sign-up";
import {
  StyledBox,
  StyledContainer,
  StyledIconButton,
  StyledModal,
  StyledTab,
  StyledTabPanel,
} from "../../styles/components/authentication/auth-modal";

const AuthModal = (
  {open: open, onClose: onClose}:
    { open: boolean, onClose: () => unknown }) => {
  const [value, setValue] = useState('auth-modal-sign-in');

  const handleChange = (_event: SyntheticEvent, newValue: string) => {
    setValue(newValue);
  }

  return (
    <StyledModal disableScrollLock open={open} onClose={onClose}>
      <StyledContainer maxWidth={false}>
        <StyledBox>
          <TabContext value={value}>
            <Box>
              <Tabs value={value} onChange={handleChange}>
                <StyledTab label='Sign In' value='auth-modal-sign-in'/>
                <StyledTab label='Sign Up' value='auth-modal-sign-up'/>
                <StyledIconButton onClick={onClose}>
                  <CloseRoundedIcon color='primary'/>
                </StyledIconButton>
              </Tabs>
            </Box>
            <StyledTabPanel
              id='auth-modal-sign-in'
              value={value}
              hidden={'auth-modal-sign-in' !== value}
            >
              <SignIn onClose={onClose}/>
            </StyledTabPanel>
            <StyledTabPanel
              id='auth-modal-sign-in'
              value={value}
              hidden={'auth-modal-sign-up' !== value}
            >
              <SignUp onClose={onClose}/>
            </StyledTabPanel>
          </TabContext>
        </StyledBox>
      </StyledContainer>
    </StyledModal>
  )
}

export default AuthModal;