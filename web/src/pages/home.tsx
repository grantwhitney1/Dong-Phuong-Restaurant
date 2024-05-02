import {Box, Button, Card, CardActionArea, CardContent, Divider, Stack, Tab, Tabs, Typography} from "@mui/material";
import Carousel from "react-material-ui-carousel";
import TapasIcon from '@mui/icons-material/Tapas';
import RiceBowlIcon from '@mui/icons-material/RiceBowl';
import BakeryDiningIcon from '@mui/icons-material/BakeryDining';
import RamenDiningIcon from '@mui/icons-material/RamenDining';
import EmojiFoodBeverageIcon from '@mui/icons-material/EmojiFoodBeverage';
import FacebookIcon from '@mui/icons-material/Facebook';
import MoreVertIcon from '@mui/icons-material/MoreVert';
import ImageOne from "/img/1.jpg";
import ImageTwo from "/img/2.jpg";
import ImageThree from "/img/3.jpg";
import ImageFour from "/img/4.jpg";
import ImageFive from "/img/5.jpg";
import ImageSix from "/img/6.jpg";
import ImageSeven from "/img/7.jpg";
import {blue, green, grey, red} from "@mui/material/colors";
import {TabContext, TabPanel} from "@mui/lab";
import {ReactJSXElement} from "@emotion/react/types/jsx-namespace";
import {styled} from "@mui/material/styles";
import {FC, SyntheticEvent, useState} from "react";

const StyledTypography = styled(Typography)(({theme}) => ({
  backgroundColor: 'rgba(0, 0, 0, 0.5)',
  color: 'white',
  width: '100%',
  textOverflow: 'ellipsis',
  overflow: 'hidden',
  fontFamily: "Quicksand, sans-serif",
  margin: theme.spacing(0, 'auto'),
  textAlign: "center"
}));

const StyledCard = styled(Card)({
  margin: '.5rem 0 .5rem 0'
});

const StyledMoreVertIcon = styled(MoreVertIcon)({
  margin: '1rem auto 0',
  fontSize: '4rem',
  color: grey['400'],
});

const StyledButton = styled(Button)(({theme}) => ({
  marginRight: theme.spacing(2),
  marginLeft: theme.spacing(2)
}));

const StyledTabs = styled(Tabs)({
  margin: '0 auto',
  maxWidth: '66vw'
});

const StyledBox = styled(Box)({
  margin: '0 auto 0 auto',
  maxWidth: '66vw'
});

const StyledDiv = styled('div')({
  display: 'flex',
  flexDirection: 'row',
  justifyContent: 'center',
  marginBottom: '2rem',
});

const StyledFacebookIcon = styled(FacebookIcon)({
  fontSize: '4rem',
  color: blue.A200,
  transition: 'all 250ms ease-in-out',
  '&:hover': {
    filter: 'brightness(0.8)',
    color: blue.A400,
    cursor: 'pointer',
  }
});

interface MenuItemProps {
  item: {
    name: string;
    description: string;
    price: number;
  };
}

interface MenuCategoryProps {
  category: string;
  items: Array<{
    name: string;
    description: string;
    price: number;
  }>;
}

const menuItems: Record<string, Array<{ name: string; description: string; price: number }>> = {
  "APPETIZERS": [
    {
      name: 'Chả Giò',
      description: 'Four fried shrimp & pork egg rolls',
      price: 5,
    },
    {
      name: 'Gỏi Cuốn',
      description: 'Two shrimp & pork egg rolls',
      price: 5,
    },
  ],
  "RICE BOWLS": [
    {
      name: 'Cơm Suon Nướng',
      description: 'Grilled pork chop over rice',
      price: 5,
    },
    {
      name: 'Cơm Thịt Nướng',
      description: 'Grilled pork over rice',
      price: 5,
    },
  ],
  "ROLLS": [
    {
      name: 'Bún Gà Nướng',
      description: 'Grilled chicken over vermicelli',
      price: 5,
    },
    {
      name: 'Bún Tôm Nướng',
      description: 'Grilled shrimp over vermicelli',
      price: 5,
    },
  ],
  "SOUPS": [
    {
      name: 'Phở Bò Viên',
      description: 'Beef meatball noodle soup',
      price: 5,
    },
    {
      name: 'Phở Tôm',
      description: 'Shrimp noodle soup',
      price: 5,
    },
  ],
  "BEVERAGES": [
    {
      name: 'Avocado Tapioca',
      description: '',
      price: 5,
    },
    {
      name: 'Banana Tapioca',
      description: '',
      price: 5,
    },
  ],
};

const categoryIcons: Record<string, ReactJSXElement> = {
  "APPETIZERS": <TapasIcon/>,
  "RICE BOWLS": <RiceBowlIcon/>,
  "ROLLS": <BakeryDiningIcon/>,
  "SOUPS": <RamenDiningIcon/>,
  "BEVERAGES": <EmojiFoodBeverageIcon/>,
};

const MenuItem: FC<MenuItemProps> = ({item}) => (
  <StyledCard>
    <CardActionArea>
      <CardContent>
        <Typography variant="h5" component="div">
          {item.name}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {item.description}
        </Typography>
        <Typography variant="body2" color={green['900']}>
          ${item.price}
        </Typography>
      </CardContent>
    </CardActionArea>
  </StyledCard>
);

const MenuCategory: FC<MenuCategoryProps> = ({category, items}) => (
  <TabPanel value={category}>
    <Stack>
      {items.map((item, index) => (
        <MenuItem item={item} key={index}/>
      ))}
      <StyledMoreVertIcon/>
    </Stack>
  </TabPanel>
);

const Home = () => {
  const [value, setValue] = useState("APPETIZERS");

  const handleChange = (_event: SyntheticEvent, newValue: string) => {
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
        navButtonsProps={{
          style: {
            backgroundColor: red[500],
          }
        }}
        sx={{maxWidth: '66vw', margin: '0 auto'}}
      >
        <StyledBox>
          <StyledDiv>
            <img alt="Vietnamese Dish" height={512} style={{alignSelf: 'center'}} src={ImageOne}/>
          </StyledDiv>
        </StyledBox>
        <StyledBox>
          <StyledDiv>
            <img alt="Vietnamese Dish" height={512} style={{alignSelf: 'center'}} src={ImageTwo}/>
          </StyledDiv>
        </StyledBox>
        <StyledBox>
          <StyledDiv>
            <img alt="Vietnamese Dish" height={512} style={{alignSelf: 'center'}} src={ImageThree}/>
          </StyledDiv>
        </StyledBox>
        <StyledBox>
          <StyledDiv>
            <img alt="Vietnamese Dish" height={512} style={{alignSelf: 'center'}} src={ImageFour}/>
          </StyledDiv>
        </StyledBox>
        <StyledBox>
          <StyledDiv>
            <img alt="Vietnamese Dish" height={512} style={{alignSelf: 'center'}} src={ImageFive}/>
          </StyledDiv>
        </StyledBox>
        <StyledBox>
          <StyledDiv>
            <img alt="Vietnamese Dish" height={512} style={{alignSelf: 'center'}} src={ImageSix}/>
          </StyledDiv>
        </StyledBox>
      </Carousel>
      <Typography
        variant="h4"
        fontFamily="Cormorant SC, serif"
        fontWeight="800"
        textAlign="center"
        marginTop="4rem"
      >
        Try Our Exotic, Traditional Vietnamese Cuisine
      </Typography>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <TabContext value={value}>
        <StyledTabs
          centered
          variant="fullWidth"
          value={value}
          onChange={handleChange}
        >
          {Object.keys(menuItems).map((category) => (
            <Tab key={category} value={category} icon={categoryIcons[category]} label={category}/>
          ))}
        </StyledTabs>
        <StyledBox>
          {Object.keys(menuItems).map((category) => (
            <MenuCategory key={category} category={category} items={menuItems[category]}/>
          ))}
        </StyledBox>
      </TabContext>
      <StyledDiv>
        <StyledButton variant="contained">
          See Full Menu
        </StyledButton>
        <StyledButton variant="contained">
          Place an Online Order
        </StyledButton>
      </StyledDiv>
      <Typography
        variant="h4"
        fontFamily="Cormorant SC, serif"
        fontWeight="800"
        textAlign="center"
        marginTop="4rem"
      >
        {"A Taste of New Orleans' Diverse Taste and Culture"}
      </Typography>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <StyledDiv sx={{maxWidth: '66vw', margin: '0 auto'}}>
        <div style={{
          display: 'flex',
          flexDirection: 'column',
          width: '50%',
        }}>
          <img
            alt="Dong Phuong Bakery"
            style={{
              objectFit: 'contain',
            }}
            src={ImageSeven}
          />
          <StyledTypography>
            14207 Chef Menteur Hwy New Orleans, LA 70129
          </StyledTypography>
          <StyledTypography>
            (504) 254-0296
          </StyledTypography>
        </div>
        <Box
          display="flex"
          flexDirection="column"
          justifyContent="center"
        >
          <Typography
            fontFamily="Quicksand, sans-serif"
            fontWeight="500"
            marginLeft="4rem"
            textAlign="justify"
            sx={{textIndent: '2rem'}}
          >
            In a city where restaurants often rise and fall, a bakery founded by South Vietnamese refugees in the
            early
            1980s succeeded in elevating New Orleans’s reputation as one of the best food cities in the world — and
            placed
            the ingenuity and resilience of its Vietnamese community firmly in the spotlight.
          </Typography>
          <Typography
            fontFamily="Quicksand, sans-serif"
            fontWeight="500"
            marginLeft="4rem"
            marginTop="2rem"
            textAlign="justify"
            sx={{textIndent: '2rem'}}
          >
            Dong Phuong, as New Orleanians know it now, was built over four decades by three generations of a single
            family. Although the business first started as a haven for the Vietnamese community, members of the Tran
            family contributed to its explosive popularity, one recipe at a time.
          </Typography>
        </Box>
      </StyledDiv>
      <Divider sx={{margin: '2rem auto 2rem auto', maxWidth: '90vw'}} variant="middle"/>
      <StyledDiv>
        <a href="https://www.facebook.com/DPyumtum/">
          <StyledFacebookIcon/>
        </a>
      </StyledDiv>
    </Box>
  );
}

export default Home;
