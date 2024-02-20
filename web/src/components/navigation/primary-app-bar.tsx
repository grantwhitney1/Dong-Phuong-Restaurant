import {Badge, IconButton} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";
import {
  StyledAppBar,
  StyledBox, StyledBoxLeftIcons,
  StyledBoxRightIcons,
  StyledIconButton,
  StyledToolbar,
  StyledTypography
} from "../../styles/components/navigation/primary-app-bar";

const PrimaryAppBar = () => {
  return (
    <StyledBox>
      <StyledAppBar position="static">
        <StyledToolbar>
          <StyledBoxLeftIcons>
            <StyledIconButton
              size="large"
              edge="start"
              color="inherit"
              aria-label="open drawer"
            >
              <MenuIcon/>
            </StyledIconButton>
          </StyledBoxLeftIcons>
          <StyledTypography variant="h4" noWrap>
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
        </StyledToolbar>
      </StyledAppBar>
    </StyledBox>
  );
}

export default PrimaryAppBar;