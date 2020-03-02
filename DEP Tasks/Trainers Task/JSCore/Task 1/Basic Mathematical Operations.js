// Questions
// http://www.codewars.com/kata/basic-mathematical-operations

function basicOp(operation, value1, value2) {
  var ans = 0;

  if (operation === '+') {
    ans = value1 + value2;
  }
  else if (operation === '-') {
    ans = value1 - value2;
  }
  else if (operation === '*') {
    ans = value1 * value2;
  }
  else if (operation === '/') {
    ans = value1 / value2;
  }
  return ans;
}