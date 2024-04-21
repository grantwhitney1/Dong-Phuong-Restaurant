import {styled} from "@mui/system";
import {AppBar, Box, IconButton, Toolbar} from "@mui/material";
import primaryAppBarImage from "../../../assets/components/navigation/primary-app-bar/primary-app-bar.png";
import {grey} from "@mui/material/colors";

export const NavBarBox = styled(Box)(() => ({
  fontFamily: 'Cormorant SC, serif',
  height: '20vh',
  maxWidth: '100%',
  position: 'sticky',
  top: 0,
  zIndex: 1100,
}));

export const NavBarAppBar = styled(AppBar)({
  backgroundColor: 'transparent',
  backgroundImage: `url(${primaryAppBarImage})`,
  backgroundSize: 'cover',
  backgroundRepeat: 'repeat-x',
  backgroundPositionX: 'center',
  boxShadow: 'none',
  height: '100%',
  width: '100%',
  display: 'flex',
  flexDirection: 'column',
  justifyContent: 'center',
  paddingBottom: '7vh',
});

export const StyledToolbar = styled(Toolbar)({
  justifyContent: 'center',
});

export const StyledIconButton = styled(IconButton)(({theme}) => ({
  marginRight: theme.spacing(2),
}));

export const StyledH1 = styled('h1')(() => ({
  sx: {display: {xs: 'none', sm: 'block'}},
  color: grey[50],
  userSelect: 'none',
  fontFamily: 'inherit',
  textAlign: 'center',
  fontWeight: '600',
  textWrap: 'nowrap',
  flex: 1,
}));

export const StyledBoxLeft = styled(Box)(() => ({
  display: 'flex',
  justifyContent: 'start',
  flex: 1,
}));

export const StyledBoxRight = styled(Box)(() => ({
  display: 'flex',
  justifyContent: 'end',
  flex: 1,
}));