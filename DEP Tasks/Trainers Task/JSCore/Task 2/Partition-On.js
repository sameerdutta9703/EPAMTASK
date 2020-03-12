// Questions
// http://www.codewars.com/kata/partition-on

function partitionOn(pred, items) {
  var partIndex = 0;
  for (var i = 0; i < items.length; i++) {
    if (!pred(items[i])) {
      var temp = items[i];
      items.splice(i, 1);
      items.splice(partIndex, 0, temp);
      partIndex++;
    }
  }
  return partIndex;
}