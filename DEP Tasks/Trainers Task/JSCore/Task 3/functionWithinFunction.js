// Question
// https://www.codewars.com/kata/a-function-within-a-function

function always(n) {
  return function fn() {
    return n;
  }
}