import React, {SyntheticEvent, useCallback, useEffect, useState} from 'react';
import {Tab} from "@mui/material";
import {TabContext, TabPanel} from "@mui/lab";
import {apiBaseUrl} from "../utils/vite-env";
import {MenuItem, StyledBox, StyledTabs} from "./home";

type Good = {
  id: number;
  name: string;
  category: string;
  description: string;
  price: number;
};


type GoodCategories = {
  Appetizers: Good[];
  Rolls: Good[];
  "Rice Bowls": Good[];
  "Served Over Rice": Good[];
  Salads: Good[];
  Soups: Good[];
  Specialties: Good[];
  Beverages: Good[];
  "Tapioca Beverages": Good[];
  "Packaged Goods": Good[];
};

const Order: React.FC = () => {
  const [goods, setGoods] = useState<Record<string, Good[]>>({
    Appetizers: [],
    Rolls: [],
    "Rice Bowls": [],
    "Served Over Rice": [],
    Salads: [],
    Soups: [],
    Specialties: [],
    Beverages: [],
    "Tapioca Beverages": [],
    "Packaged Goods": [],
  });

  const [activeTab, setActiveTab] = useState<keyof GoodCategories>('Appetizers');

  useEffect(() => {
    const fetchGoods = async (endpoint: string, category: string) => {
      try {
        const response = await fetch(`${apiBaseUrl}api/${endpoint}`, {
          method: "GET",
          headers: {"Content-Type": "application/json"}
        });
        const dataObject = await response.json();
        const categoryGoods: Good[] = dataObject.data.filter((x: Good) => x.category === category);
        setGoods(prevState => ({...prevState, [category]: categoryGoods}));
      } catch (error) {
        console.error(`An error occurred while fetching ${category}:`, error);
      }
    };
    (async () => {
      await fetchGoods('PreparedGoods', 'Appetizers');
      await fetchGoods('PreparedGoods', 'Rolls');
      await fetchGoods('PreparedGoods', 'Rice Bowls');
      await fetchGoods('PreparedGoods', 'Served Over Rice');
      await fetchGoods('PreparedGoods', 'Salads');
      await fetchGoods('PreparedGoods', 'Soups');
      await fetchGoods('PreparedGoods', 'Specialties');
      await fetchGoods('Drinks', 'Beverages');
      await fetchGoods('Drinks', 'Tapioca Beverages');
      await fetchGoods('PackagedGoods', 'Packaged Goods');
    })()
  }, []);

  const handleTabClick = useCallback((_event: SyntheticEvent, newValue: keyof (GoodCategories)) => {
    setActiveTab(newValue);
  }, [setActiveTab]);

  return (
    <>
      <TabContext value={activeTab}>
        <StyledTabs
          centered
          variant="scrollable"
          value={activeTab}
          onChange={handleTabClick}
        >
          {Object.keys(goods).map((category) => (
            <Tab key={category} value={category} label={category}/>
          ))}
        </StyledTabs>
        <StyledBox>
          {Object.keys(goods).map((category: string) => (
            <TabPanel key={category} value={category}>
              {goods[category].map((item: Good) => (
                <MenuItem key={item.id} item={item}/>
              ))}
            </TabPanel>
          ))}
        </StyledBox>
      </TabContext>
    </>
  );
};

export default Order;