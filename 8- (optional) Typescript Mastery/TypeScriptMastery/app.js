"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var calculationDecorators_1 = require("./calculationDecorators");
var MathClass = /** @class */ (function () {
    function MathClass() {
    }
    MathClass.prototype.addOne = function (number) {
        return number + 1;
    };
    __decorate([
        calculationDecorators_1.subtract(1),
        calculationDecorators_1.multiply(2)
    ], MathClass.prototype, "addOne", null);
    return MathClass;
}());
console.log(new MathClass().addOne(2)); //should print 5
