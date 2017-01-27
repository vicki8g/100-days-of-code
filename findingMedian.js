// tester value so can replace
var array = [ 29, 30, 33, 50, 99, 100 ]

function median(array) {
var tempArray = array.sort(function (a,b){return a-b});
console.log(tempArray);
if (tempArray.length %2 === 0) {
  return (tempArray[(tempArray.length/ 2) -1] + tempArray[(tempArray.length/ 2)]) / 2;
}
  
return tempArray[Math.floor(tempArray.length/ 2)];
}
