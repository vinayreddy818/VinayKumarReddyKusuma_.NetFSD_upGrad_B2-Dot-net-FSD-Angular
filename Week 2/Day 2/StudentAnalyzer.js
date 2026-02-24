// Store marks in array
const marks = [60, 70, 65, 40, 50];

// Calculate total using reduce
const total = marks.reduce((sum, mark) => sum + mark, 0);

// Average
const average = total / marks.length;

// Pass / Fail 
const result = average >= 50 ? "Pass" : "Fail";

// Display output
console.log(`Total Marks: ${total}`);
console.log(`Average Marks: ${average}`);
console.log(`Result: ${result}`);