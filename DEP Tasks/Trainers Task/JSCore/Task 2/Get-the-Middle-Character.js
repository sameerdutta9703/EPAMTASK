// Questions
// http://www.codewars.com/kata/get-the-middle-character

function getMiddle(str) {
  var position;
  var length;

  if (str.length % 2 != 0) {
    position = str.length / 2;
    length = 1;
  } else {
    position = str.length / 2 - 1;
    length = 2;
  }

  return str.substring(position, position + length);
}