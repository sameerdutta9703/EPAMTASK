// Question
// https://www.codewars.com/kata/new-with-apply

function construct(Class) {
    var obj = Object.create(Class.prototype);
    Class.apply(obj, Array.prototype.splice.call(arguments, 1));
    return obj;

    //or we can just use the spread operator, giving the arguments in the function
    //return new Class(...args);
}