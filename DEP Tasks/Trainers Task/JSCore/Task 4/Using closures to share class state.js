// Question
// http://www.codewars.com/kata/using-closures-to-share-class-state


var Cat = function (name, weight) {
    if (name == undefined || weight == undefined) {
        throw new Error();
    }
    this.name = name;
    this.weight = weight;
    Cat.count = ++Cat.count || 1;
    Cat.sum = Cat.sum + weight || weight;
    Cat.averageWeight = function () {
        return Cat.sum / Cat.count;
    }
};