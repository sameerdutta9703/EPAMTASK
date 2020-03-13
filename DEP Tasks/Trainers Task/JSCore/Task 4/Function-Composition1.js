// Question
// https://www.codewars.com/kata/function-composition-1

function compose(...parameters) {
    return function (a) {
        let result = a;
        for (let i = parameters.length - 1; i >= 0; i--) {
            result = parameters[i](result);
        }
        return result;
    }
}