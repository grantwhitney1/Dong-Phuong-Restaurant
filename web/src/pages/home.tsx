import {Box, Button, Divider, Tab, Tabs, Typography} from "@mui/material";
import Carousel from "react-material-ui-carousel";
import TapasIcon from '@mui/icons-material/Tapas';
import RiceBowlIcon from '@mui/icons-material/RiceBowl';
import BakeryDiningIcon from '@mui/icons-material/BakeryDining';
import RamenDiningIcon from '@mui/icons-material/RamenDining';
import EmojiFoodBeverageIcon from '@mui/icons-material/EmojiFoodBeverage';
import React from "react";

const Home = () => {
  const [value, setValue] = React.useState(0);

  const handleChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
  };

  return (
    <Box>
      <Typography
        variant="h4"
        fontFamily="Cormorant SC, serif"
        fontWeight="800"
        textAlign="center"
        marginTop="4rem"
      >
        Welcome to Dong Phuong Vietnamese Restaurant
      </Typography>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <Carousel
        autoPlay
        stopAutoPlayOnHover
        navButtonsAlwaysVisible
        sx={{
          width: '50%',
          margin: '0 auto'
        }}
      >
        {
          [1, 2, 3, 4, 5, 6, 7].map((item, index) => (
            <div key={index} style={{
              display: 'flex',
              flexDirection: 'column',
              width: 'auto',
              justifyContent: 'center'
            }}>
              <img height={512} style={{alignSelf: 'center'}} src={`../../public/img/${item}.jpg`}/>
            </div>
          ))
        }
      </Carousel>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <Typography
        variant="h4"
        fontFamily="Cormorant SC, serif"
        fontWeight="800"
        textAlign="center"
      >
        Try Our Exotic, Traditional Vietnamese Cuisine
      </Typography>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <Tabs
        centered
        variant="fullWidth"
        value={value}
        onChange={handleChange}
        sx={{margin: '0 auto', maxWidth: '66vw'}}
      >
        <Tab icon={<TapasIcon/>} label="APPETIZERS"/>
        <Tab icon={<RiceBowlIcon/>} label="RICE BOWLS"/>
        <Tab icon={<BakeryDiningIcon/>} label="ROLLS"/>
        <Tab icon={<RamenDiningIcon/>} label="SOUPS"/>
        <Tab icon={<EmojiFoodBeverageIcon/>} label="BEVERAGES"/>
      </Tabs>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <div style={{
        display: 'flex',
        flexDirection: 'row',
        width: '100vw',
        justifyContent: 'center',
      }}>
        <Button variant="contained" sx={{marginRight: '2rem'}}>
          See Full Menu
        </Button>
        <Button variant="contained" sx={{marginLeft: '2rem'}}>
          Place an Online Order
        </Button>
      </div>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <Typography
        variant="h4"
        fontFamily="Cormorant SC, serif"
        fontWeight="800"
        textAlign="center"
      >
        {"A Taste of New Orleans' Diverse Taste and Culture"}
      </Typography>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
    </Box>
  );
}

export default Home;