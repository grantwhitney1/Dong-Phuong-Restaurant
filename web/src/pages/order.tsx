import React, { useEffect, useState } from "react";

type PreparedGood = {
  id: number;
  name: string;
  description: string;
  price: number;
};

const Order: React.FC = () => {
  const [goods, setGoods] = useState<PreparedGood[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchGoods = async () => {
      try {
        const response = await fetch("https://localhost:7217/api/PreparedGoods", {
          method: "GET",
          headers: { "Content-Type": "application/json" },
        });
    
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
    
        const dataObject = await response.json();
        const goods: PreparedGood[] = dataObject.data;  // Here 'data' is the property holding the actual goods array.
    
        console.log(goods);  // Optional: just to check if data is loaded correctly.
        setGoods(goods);
        setLoading(false);
        
      } catch (error) {
        console.error("An error occurred while fetching goods:", error);
      }
    };
    
    fetchGoods();
  }, []);

  if (loading) {
    return <h1>Loading...</h1>;
  }

  return (
    <>
      <h1>Order</h1>
      {goods.map((good: PreparedGood) => (
        <div key={good.id}>
          <h2>{good.name}</h2>
          <p>{good.description}</p>
          <h3>Price: {good.price}</h3>
        </div>
      ))}
    </>
  );
};

export default Order;