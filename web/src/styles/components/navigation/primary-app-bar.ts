import {styled} from "@mui/system";
import {AppBar, Box, IconButton, Typography} from "@mui/material";

export const StyledBox = styled(Box)(() => ({
  flexGrow: 1,
  fontFamily: 'Cormorant SC, serif'
}));

export const StyledAppBar = styled(AppBar)({
  backgroundColor: "#8F1621",
});

export const StyledIconButton = styled(IconButton)(({theme}) => ({
  marginRight: theme.spacing(2),
}));

export const StyledTypography = styled(Typography)(() => ({
  sx: {display: {xs: 'none', sm: 'block'}},
  userSelect: 'none',
  fontFamily: 'inherit',
  component: 'div'
}));

export const StyledBoxRightIcons = styled(Box)(() => ({
  sx: {display: {xs: 'flex'}},
  marginLeft: 'auto',
}));