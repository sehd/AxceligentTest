import { subtract, multiply } from "./calculationDecorators";

class MathClass {

    @subtract(1)
    @multiply(2)
    addOne(number: number) {
        return number + 1;
    }
}

console.log(new MathClass().addOne(2)) //should print 5
