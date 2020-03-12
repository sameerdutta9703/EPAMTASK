// Questions
// https://www.codewars.com/kata/extract-nested-object-reference

Object.prototype.hash = function (string) {
    var arr = string.split(".");
    var result = this;
    for (var i = 0; i < arr.length; i++) {
        if (result[arr[i]] != undefined) {
            result = result[arr[i]];
        }
        else {
            return undefined;
        }
    }
    return result;
}