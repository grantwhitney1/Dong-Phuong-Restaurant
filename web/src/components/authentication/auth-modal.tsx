import {SetStateAction, SyntheticEvent} from "react";
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

const AuthModal = ({open, onClose, tabsValue, setTabsValue}: {
  open: boolean,
  onClose: () => void,
  tabsValue: string,
  setTabsValue: (value: SetStateAction<string>) => void
}) => {
  const handleChange = (_event: SyntheticEvent, newValue: string) => {
    setTabsValue(newValue);
  }

  return (
    <StyledModal disableScrollLock open={open} onClose={onClose}>
      <StyledContainer maxWidth={false}>
        <StyledBox>
          <TabContext value={tabsValue}>
            <Box>
              <Tabs value={tabsValue} onChange={handleChange}>
                <StyledTab label='Sign In' value='auth-modal-sign-in'/>
                <StyledTab label='Sign Up' value='auth-modal-sign-up'/>
                <StyledIconButton onClick={onClose}>
                  <CloseRoundedIcon color='primary'/>
                </StyledIconButton>
              </Tabs>
            </Box>
            <StyledTabPanel
              id='auth-modal-sign-in'
              value={tabsValue}
              hidden={'auth-modal-sign-in' !== tabsValue}
            >
              <SignIn onClose={onClose}/>
            </StyledTabPanel>
            <StyledTabPanel
              id='auth-modal-sign-in'
              value={tabsValue}
              hidden={'auth-modal-sign-up' !== tabsValue}
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