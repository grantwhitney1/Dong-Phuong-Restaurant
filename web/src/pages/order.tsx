import React, { useEffect, useState } from 'react';
import GoodCard from '../components/good-card';

type Good = {
  id: number;
  name: string;
  description: string;
  price: number;
};

type GoodCategories = {
  preparedGoods: Good[];
  drinks: Good[];
  packagedGoods: Good[];
};

const Order: React.FC = () => {
  const [goods, setGoods] = useState<GoodCategories>({ preparedGoods: [], drinks: [], packagedGoods: [] });
  const [filteredGoods, setFilteredGoods] = useState<GoodCategories>({ preparedGoods: [], drinks: [], packagedGoods: [] });
  const [loading, setLoading] = useState(true);
  const [activeTab, setActiveTab] = useState<keyof GoodCategories>('preparedGoods');
  const [searchTerm, setSearchTerm] = useState("");

  const cardContainerStyle = {
    display: 'grid',
    gridTemplateColumns: '1fr 1fr',
    gap: '20px',
    padding: '20px'
  };
  
  useEffect(() => {
    const fetchGoods = async (endpoint: string, category: keyof GoodCategories) => {
      try {
        const response = await fetch(`https://localhost:7217/api/${endpoint}`, { method: "GET", headers: { "Content-Type": "application/json" } });
        if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
        const dataObject = await response.json();
        const categoryGoods: Good[] = dataObject.data;
        setGoods(prevState => ({...prevState, [category]: categoryGoods}));
      } catch (error) {
        console.error(`An error occurred while fetching ${category}:`, error);
      }
    };
    fetchGoods('PreparedGoods', 'preparedGoods');
    fetchGoods('Drinks', 'drinks');
    fetchGoods('PackagedGoods', 'packagedGoods');
  }, []);

  useEffect(() => {
    setSearchTerm('');
    const allGoodsLoaded = Object.values(goods).every(categoryGoods => categoryGoods.length > 0);
    setFilteredGoods(goods);
    setLoading(!allGoodsLoaded);
  }, [goods]);

  const handleTabClick = (category: keyof GoodCategories) => setActiveTab(category);

  const handleSearch = (e: React.ChangeEvent<HTMLInputElement>) => {
    const search = e.target.value.toLowerCase();
    setSearchTerm(search);
    
    const filtered = Object.keys(goods).reduce((acc, category) => {
        acc[category as keyof GoodCategories] = goods[category as keyof GoodCategories].filter(good =>
          good.name.toLowerCase().includes(search) || 
          good.description?.toLowerCase().includes(search)
        );
        return acc;
      }, {} as GoodCategories);
  
      console.log(filtered);
      setFilteredGoods(filtered);
  };

  if (loading) {
    return <h1>Loading...</h1>;
  }

  return (
    <>
      <h1>Order</h1>
      <input type="text" value={searchTerm} placeholder="Search..." onChange={handleSearch} />
      <div>
        {Object.keys(goods).map((category) => (
          <button onClick={() => handleTabClick(category as keyof GoodCategories)} key={category}>{category}</button>
        ))}
      </div>
      <div style={cardContainerStyle}>
        {filteredGoods[activeTab].map((good: Good) => (
          <GoodCard key={good.id} good={good} />
        ))}
      </div>
    </>
  );
};

export default Order;