'use simple'

// This is about basic use of array in JS 
// It covers all the built-in functions that support arrays

// Declaration
// let num = new Array();
// let num = [];
let num = [19, 10, 8, 17, 9];

//traverse through the array and print all the elements
for (let index = 0; index < num.length; index++) {
    alert(`num[${index}] is equal to ${val}`, index, num[index]);
}

//update element at i index
num[3] = -20;
alert(`num[3] is ${num[3]}`, num[3]);

//access out of bound
alert(`num[3] is ${num[5]}`, num[5]);

//get array size
alert("array size is "+ num.length);

