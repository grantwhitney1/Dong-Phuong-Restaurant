import {Box, Button, Divider, Tab, Tabs, Typography} from "@mui/material";
import Carousel from "react-material-ui-carousel";
import TapasIcon from '@mui/icons-material/Tapas';
import RiceBowlIcon from '@mui/icons-material/RiceBowl';
import BakeryDiningIcon from '@mui/icons-material/BakeryDining';
import RamenDiningIcon from '@mui/icons-material/RamenDining';
import EmojiFoodBeverageIcon from '@mui/icons-material/EmojiFoodBeverage';
import ImageOne from "../../public/img/1.jpg";
import ImageTwo from "../../public/img/2.jpg";
import ImageThree from "../../public/img/3.jpg";
import ImageFour from "../../public/img/4.jpg";
import ImageFive from "../../public/img/5.jpg";
import ImageSix from "../../public/img/6.jpg";
import ImageSeven from "../../public/img/7.jpg";

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
        <div key={1} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageOne}/>
        </div>
        <div key={2} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageTwo}/>
        </div>
        <div key={3} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageThree}/>
        </div>
        <div key={4} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageFour}/>
        </div>
        <div key={5} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageFive}/>
        </div>
        <div key={6} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageSix}/>
        </div>
        <div key={7} style={{
          display: 'flex',
          flexDirection: 'column',
          width: 'auto',
          justifyContent: 'center'
        }}>
          <img height={512} style={{alignSelf: 'center'}} src={ImageSeven}/>
        </div>
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