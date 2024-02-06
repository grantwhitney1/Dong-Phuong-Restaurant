import {AppBar, Badge, Box, IconButton, Toolbar, Typography} from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import NotificationsIcon from "@mui/icons-material/Notifications";

const PrimaryAppBar = () => {
    return (
      <Box sx={{ flexGrow: 1 }}>
          <AppBar
              position="static"
              sx={{ display: { backgroundColor: "#8F1621" } }}
          >
              <Toolbar>
                  <IconButton
                      size="large"
                      edge="start"
                      color="inherit"
                      aria-label="open drawer"
                      sx={{ mr: 2 }}
                  >
                      <MenuIcon />
                  </IconButton>
                  <Typography
                      variant="h6"
                      noWrap
                      component="div"
                      sx={{ display: { xs: 'none', sm: 'block', userSelect: 'none' } }}
                      fontFamily="inherit"
                  >
                      Dong Phuong Restaurant
                  </Typography>
                  <Box sx={{ display: { xs: 'flex', marginLeft: 'auto' } }}>
                      <IconButton
                          size="large"
                          color="inherit"
                      >
                          <Badge badgeContent={1} color="primary">
                              <NotificationsIcon />
                          </Badge>
                      </IconButton>
                      <IconButton
                          size="large"
                          color="inherit"
                      >
                          <AccountCircleIcon />
                      </IconButton>
                  </Box>
              </Toolbar>
          </AppBar>
      </Box>
    );
}

export default PrimaryAppBar;