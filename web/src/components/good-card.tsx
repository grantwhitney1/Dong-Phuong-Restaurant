import React from 'react';
import Card from '@mui/material/Card';
import CardHeader from '@mui/material/CardHeader';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import Avatar from '@mui/material/Avatar';
import { red } from '@mui/material/colors';
import Button from '@mui/material/Button';

type Good = {
  id: number;
  name: string;
  description: string;
  price: number;
};

type GoodCardProps = {
  good: Good;
};

const GoodCard: React.FC<GoodCardProps> = ({ good }) => (
  <Card sx={{ maxWidth: 500, margin: 2, position: 'relative'}}>
    <CardHeader
      avatar={
        <Avatar sx={{ bgcolor: red[500] }} aria-label="recipe">
          {good.name.charAt(0)}
        </Avatar>
      }
      title={good.name}
      subheader={`Price: $${good.price.toFixed(2)}`} // Changed line
    />
    <CardContent>
      <Typography variant="body2" color="text.secondary">
        {good.description}
      </Typography>
    </CardContent>
    <Button variant="outlined" color="primary" sx={{
      position: 'absolute',
      top: '50%', 
      right: '10px', 
      transform: 'translateY(-50%)'
    }}>
      Add to cart
    </Button>
  </Card>
);

export default GoodCard;