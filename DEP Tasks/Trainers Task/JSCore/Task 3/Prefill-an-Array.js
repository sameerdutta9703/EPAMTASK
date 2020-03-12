// Question
// https://www.codewars.com/kata/prefill-an-array

function prefill(n, v) {
  if (n != parseInt(n, 10) || (n < 0)) {
    throw new TypeError(n + " is invalid");
  }
  else if (n == 0) {
    return [];
  }
  var arr = Array(n).fill(v);
  return arr;
}