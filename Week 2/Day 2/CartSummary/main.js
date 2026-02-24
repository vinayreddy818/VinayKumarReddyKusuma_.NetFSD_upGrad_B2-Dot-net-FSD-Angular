import { Total } from './cart.js';

const products = [
    { name: "Shorts", price: 500, quantity: 2 },
    { name: "Tsirts", price: 1000, quantity: 1 },
    { name: "Shoes", price: 1500, quantity: 1 }
];

const totalValue = Total(products);

products.map(item => {
    console.log(`${item.name} - ${item.price} x ${item.quantity}`);
});

console.log(`Total Cart Value: ${totalValue}`);