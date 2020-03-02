// Question
// http://www.codewars.com/kata/transportation-on-vacation

function rentalCarCost(days) {
  var amount = 0;
  if (days >= 7) {
    amount = (days * 40) - 50;
  }
  else if (days < 7 && days >= 3) {
    amount = (days * 40) - 20;
  }
  else {
    amount = days * 40;
  }
  return amount;
}