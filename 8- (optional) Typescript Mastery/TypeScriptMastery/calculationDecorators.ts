export function subtract(subtractNumber: number): Function {
    return function (target, key, descriptor) {
        if (descriptor === undefined) {
            descriptor = Object.getOwnPropertyDescriptor(target, key);
        }
        let originalMethod = descriptor.value;
        descriptor.value = function (num: number) {
            return originalMethod(num) - subtractNumber;
        }
        //console.log(descriptor.value(1));
        return descriptor;
    }
}

export function multiply(multiplyNum: number): Function {
    return function (target, key, descriptor) {
        if (descriptor === undefined) {
            descriptor = Object.getOwnPropertyDescriptor(target, key);
        }
        let originalMethod = descriptor.value;
        descriptor.value = function (num: number) {
            return originalMethod(num) * multiplyNum;
        }
        //console.log(descriptor.value(1));
        return descriptor;
    }
}