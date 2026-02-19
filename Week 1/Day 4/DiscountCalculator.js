
function DiscountCalculator(amount){

let discount = 0;
let finalAmount = 0;

if (amount >= 5000) {
    discount = amount * 0.20;
} else if (amount >= 3000) {
    discount = amount * 0.10;
} else {
    discount = 0;
}

finalAmount = amount - discount;

console.log("Purchased Amount: " + amount);
console.log("Discount: " + discount);
console.log("Final Payable Amount: " + finalAmount);
}
let amount=7000
DiscountCalculator(amount)