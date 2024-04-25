import React, { useState } from 'react';

const Order = () => {
  const [filter, setFilter] = useState('all');
  const [isVegan, setIsVegan] = useState(false);

  const handleFilterChange = (event: { target: { value: React.SetStateAction<string>; }; }) => {
    setFilter(event.target.value);
  };
    
  const handleVeganChange = (event: { target: { checked: boolean | ((prevState: boolean) => boolean); }; }) => {
    setIsVegan(event.target.checked);
  };

  const sampleItems = [
    { id: 1, name: 'Sample Item 1', type: 'all', vegan: true },
        { id: 2, name: 'Sample Item 2', type: 'appetizers', vegan: false },
        { id: 3, name: 'Sample Item 3', type: 'riceBowls', vegan: true },
        { id: 4, name: 'Sample Item 4', type: 'vermicelli', vegan: false },
        { id: 5, name: 'Sample Item 5', type: 'pho', vegan: false },
        { id: 6, name: 'Sample Item 6', type: 'drinks', vegan: true },
        { id: 7, name: 'Sample Item 7', type: 'all', vegan: false },
        { id: 8, name: 'Sample Item 8', type: 'appetizers', vegan: true },
        { id: 9, name: 'Sample Item 9', type: 'riceBowls', vegan: false },
        { id: 10, name: 'Sample Item 10', type: 'vermicelli', vegan: false },
        { id: 11, name: 'Sample Item 11', type: 'pho', vegan: true },
        { id: 12, name: 'Sample Item 12', type: 'drinks', vegan: false },
        { id: 13, name: 'Sample Item 13', type: 'all', vegan: true },
        { id: 14, name: 'Sample Item 14', type: 'appetizers', vegan: false },
        { id: 15, name: 'Sample Item 15', type: 'riceBowls', vegan: true },
        { id: 16, name: 'Sample Item 16', type: 'vermicelli', vegan: false },
        { id: 17, name: 'Sample Item 17', type: 'pho', vegan: false },
        { id: 18, name: 'Sample Item 18', type: 'drinks', vegan: true },
  ];

  let displayedItems = sampleItems.filter(item => filter === 'all' || item.type === filter);
  if (isVegan) {
    displayedItems = displayedItems.filter(item => item.vegan);
  }

  return (
    <div>
      <h1>Order Page</h1>
      
      <input 
        type="text" 
        placeholder="Search..." 
        style={{fontSize: '20px', padding: '10px'}}
      />
            
      <select onChange={handleFilterChange} style={{fontSize: '20px', padding: '10px', marginRight: '10px', marginLeft: '10px'}}>
        <option value="all">All</option>
        <option value="appetizers">Appetizers</option>
        <option value="riceBowls">Rice Bowls</option>
        <option value="vermicelli">Vermicelli</option>
        <option value="pho">Pho</option>
        <option value="drinks">Drinks</option>
      </select>
      
      <label>
        <input type="checkbox" onChange={handleVeganChange} style={{marginLeft: '10px'}}/>
        Vegan options only:
      </label>
      
      <div style={{ display: 'flex', flexWrap: 'wrap', justifyContent: 'space-between' }}>
        {displayedItems.map(item => (
          <div key={item.id} style={{border: '1px solid', margin: '10px', padding: '10px', flexBasis: '45%'}}>
            <h3>{item.name}</h3>
            <p>Type: {item.type}</p>
          </div>
        ))}
      </div>
    </div>
  );
};

export default Order;