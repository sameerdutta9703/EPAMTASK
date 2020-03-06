// Question
// https://www.codewars.com/kata/santaclausable-interface

function isSantaClausable(obj) {
       return ['sayHoHoHo', 'distributeGifts', 'goDownTheChimney'].every(function (methord) {
              return typeof obj[methord] == 'function';
       });
}