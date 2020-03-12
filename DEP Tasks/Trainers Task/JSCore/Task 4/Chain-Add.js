Question
https://www.codewars.com/kata/a-chain-adding-function

function add(n) {
    var sol = function (x) {
        return add(n + x);
    }
    sol.toString = function () {
        return n;
    }
    return sol;
}