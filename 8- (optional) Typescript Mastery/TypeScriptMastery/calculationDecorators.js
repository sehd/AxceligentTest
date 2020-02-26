"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function subtract(subtractNumber) {
    return function (target, key, descriptor) {
        if (descriptor === undefined) {
            descriptor = Object.getOwnPropertyDescriptor(target, key);
        }
        var originalMethod = descriptor.value;
        descriptor.value = function (num) {
            return originalMethod(num) - subtractNumber;
        };
        return descriptor;
    };
}
exports.subtract = subtract;
function multiply(multiplyNum) {
    return function (target, key, descriptor) {
        if (descriptor === undefined) {
            descriptor = Object.getOwnPropertyDescriptor(target, key);
        }
        var originalMethod = descriptor.value;
        descriptor.value = function (num) {
            return originalMethod(num) * multiplyNum;
        };
        return descriptor;
    };
}
exports.multiply = multiply;
