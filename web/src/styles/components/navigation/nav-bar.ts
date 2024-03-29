import {styled} from "@mui/system";
import {AppBar, Box, IconButton, Toolbar, Typography} from "@mui/material";
import primaryAppBarImage from "../../../assets/components/navigation/primary-app-bar/primary-app-bar.png";

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

export const NavBarToolbar = styled(Toolbar)({
  justifyContent: 'center',
});

export const NavBarIconButton = styled(IconButton)(({theme}) => ({
  marginRight: theme.spacing(2),
}));

export const NavBarTypography = styled(Typography)(() => ({
  sx: {display: {xs: 'none', sm: 'block'}},
  userSelect: 'none',
  fontFamily: 'inherit',
  component: 'div',
  textAlign: 'center',
  flex: 1,
}));

export const NavBarBoxLeft = styled(Box)(() => ({
  display: 'flex',
  justifyContent: 'start',
  flex: 1,
}));

export const NavBarBoxRight = styled(Box)(() => ({
  display: 'flex',
  justifyContent: 'end',
  flex: 1,
}));