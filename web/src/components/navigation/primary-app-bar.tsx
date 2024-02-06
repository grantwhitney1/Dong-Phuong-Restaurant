import {styled} from '@mui/system';
import {AppBar, Badge, Box, IconButton, Toolbar, Typography} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";

const PrimaryAppBar = () => {
  const StyledBox = styled(Box)(() => ({
    flexGrow: 1,
  }));

  const StyledAppBar = styled(AppBar)({
    backgroundColor: "#8F1621",
  });

  const StyledIconButton = styled(IconButton)(({theme}) => ({
    marginRight: theme.spacing(2),
  }));

  const StyledTypography = styled(Typography)(() => ({
    sx: {display: {xs: 'none', sm: 'block'}},
    userSelect: 'none',
    fontFamily: 'inherit',
    component: 'div'
  }));

  const StyledBoxRightIcons = styled(Box)(() => ({
    sx: {display: {xs: 'flex'}},
    marginLeft: 'auto',
  }));

  return (
    <StyledBox>
      <StyledAppBar position="static">
        <Toolbar>
          <StyledIconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="open drawer"
          >
            <MenuIcon/>
          </StyledIconButton>
          <StyledTypography variant="h6" noWrap>
            Dong Phuong Restaurant
          </StyledTypography>
          <StyledBoxRightIcons>
            <IconButton size="large" color="inherit">
              <Badge badgeContent={1} color="primary">
                <NotificationsIcon/>
              </Badge>
            </IconButton>
            <IconButton size="large" color="inherit">
              <AccountCircleIcon/>
            </IconButton>
          </StyledBoxRightIcons>
        </Toolbar>
      </StyledAppBar>
    </StyledBox>
  );
}

export default PrimaryAppBar;