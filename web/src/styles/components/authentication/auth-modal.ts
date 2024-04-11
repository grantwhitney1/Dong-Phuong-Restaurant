import {styled} from "@mui/system";
import {Box, Container, IconButton, Modal, Tab} from "@mui/material";
import {blue} from "@mui/material/colors";
import {TabPanel} from "@mui/lab";

export const StyledModal = styled(Modal)({
  backgroundColor: 'transparent'
});

export const StyledContainer = styled(Container)({
  height: '100vh',
  width: '100vw',
  padding: '0 !important',
  display: 'flex',
  flexDirection: 'column',
  justifyContent: 'center',
});

export const StyledBox = styled(Box)({
  backgroundColor: 'white',
  maxHeight: '80vh',
  minHeight: '50vh',
  margin: '0 25% 0 25%',
  borderRadius: '2rem',
  border: `.125rem solid ${blue[600]}`,
  boxShadow: '.25rem .25rem 4rem rgba(0, 0, 0, .5)'
});

export const StyledTabPanel = styled(TabPanel)({
  padding: '1rem 20% 1rem 20%',
});

export const StyledTab = styled(Tab)({
  flexGrow: 4,
  maxWidth: '100%'
});

export const StyledIconButton = styled(IconButton)(() => ({
  margin: 'auto 1rem auto 1rem',
}));