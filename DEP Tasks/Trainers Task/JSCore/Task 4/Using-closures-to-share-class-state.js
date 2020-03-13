// Question
// http://www.codewars.com/kata/using-closures-to-share-class-state

function Cat(name, weight) {
    if (name == undefined || weight == undefined) {
        throw new Error();
    }
    if (Cat.counter) {
        Cat.counter++;
    } else {
        Cat.counter = 1;
    }
    if (Cat.Sum) {
        Cat.Sum += weight;
    } else {
        Cat.Sum = weight;
    }
    Object.defineProperty(this, "name", {
        get: function () {
            return name;
        },
        set: function (newName) {
            name = newName;
        },
        configurable: false,
    });
    Object.defineProperty(this, "weight", {
        get: function () {
            return weight;
        },
        set: function (newWeight) {
            Cat.Sum -= weight;
            weight = newWeight;
            Cat.Sum += weight;
        },
        configurable: false,
    });
}
Object.defineProperty(Cat, "averageWeight", {
    value: function () { return Cat.Sum / Cat.counter }
});
