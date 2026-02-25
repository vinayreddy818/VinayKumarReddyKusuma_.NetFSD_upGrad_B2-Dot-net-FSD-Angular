
// Product Array

const products = [
"Laptop",
"Mobile Phone",
"Headphones",
"Keyboard",
"Mouse",
"Monitor",
"Smart Watch"
];

const searchBox = document.getElementById("searchBox");
const productList = document.getElementById("productList");
const message = document.getElementById("message");


function displayProducts(list){
    productList.innerHTML = "";
    if(list.length === 0){
    message.textContent = "No Results Found";
    return;
}
    message.textContent = "";
    list.forEach(function(product){
    const li = document.createElement("li");
    li.textContent = product;
    productList.appendChild(li);
});

}

searchBox.addEventListener("input",function(){
const searchText = searchBox.value.toLowerCase();
const filteredProducts = products.filter(function(product){
return product.toLowerCase().includes(searchText);

});

displayProducts(filteredProducts);

});

displayProducts(products);
