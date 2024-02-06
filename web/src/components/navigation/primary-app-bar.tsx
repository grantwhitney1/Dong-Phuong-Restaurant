import {Badge, IconButton, Toolbar} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";
import {
  StyledAppBar,
  StyledBox,
  StyledBoxRightIcons,
  StyledIconButton,
  StyledTypography
} from "../../styles/components/navigation/primary-app-bar";

const PrimaryAppBar = () => {
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