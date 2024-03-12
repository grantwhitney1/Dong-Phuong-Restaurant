import {SyntheticEvent, useState} from "react";
import {Box, Modal, Tab, Tabs} from "@mui/material";
import {TabContext, TabPanel} from '@mui/lab';
import SignIn from "./sign-in.tsx";
import SignUp from "./sign-up.tsx";

const AuthModal = (
  {open: open, onClose: onClose}:
    { open: boolean, onClose: () => unknown }) => {
  const [value, setValue] = useState('auth-modal-sign-in');

  const handleChange = (_event: SyntheticEvent, newValue: string) => {
    setValue(newValue);
  }

  return (
    <Modal open={open} onClose={onClose} sx={{backgroundColor: 'rgba(255,255,255,0.85)'}}>
      <Box>
        <TabContext value={value}>
          <Box>
            <Tabs value={value} onChange={handleChange}>
              <Tab label='Sign In' value='auth-modal-sign-in'/>
              <Tab label='Sign Up' value='auth-modal-sign-up'/>
            </Tabs>
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
      </Box>
    </Modal>
  )
}

export default AuthModal;