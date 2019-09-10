//In Javascript we use let keyword to declair variables.
//this keyword refer to current Object.









function getKeys(object, array) {
    Object.keys(object).forEach(function (key) {
        array.push(key);
        array = getKeys(obj[key], arr);
    });
    return array;
}