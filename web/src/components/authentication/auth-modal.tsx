import {SyntheticEvent, useState} from "react";
import {Box} from "@mui/material";
import CloseRoundedIcon from '@mui/icons-material/CloseRounded';
import {TabContext, TabPanel} from '@mui/lab';
import SignIn from "./sign-in.tsx";
import SignUp from "./sign-up.tsx";
import {
  StyledBox,
  StyledContainer,
  StyledIconButton,
  StyledModal,
  StyledTab,
  StyledTabs
} from "../../styles/components/authentication/auth-modal.ts";

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
              <StyledTabs value={value} onChange={handleChange}>
                <StyledTab label='Sign In' value='auth-modal-sign-in'/>
                <StyledTab label='Sign Up' value='auth-modal-sign-up'/>
                <StyledIconButton onClick={onClose}>
                  <CloseRoundedIcon color='primary'/>
                </StyledIconButton>
              </StyledTabs>
            </Box>
            <TabPanel
              id='auth-modal-sign-in'
              value={value}
              hidden={'auth-modal-sign-in' !== value}
            >
              <SignIn onClose={onClose}/>
            </TabPanel>
            <TabPanel
              id='auth-modal-sign-in'
              value={value}
              hidden={'auth-modal-sign-up' !== value}
            >
              <SignUp onClose={onClose}/>
            </TabPanel>
          </TabContext>
        </StyledBox>
      </StyledContainer>
    </StyledModal>
  )
}

export default AuthModal;