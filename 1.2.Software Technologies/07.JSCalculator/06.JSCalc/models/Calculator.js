function Calculator(leftOperand, rightOperand, operator){
    this.leftOperand = Number(leftOperand);
    this.rightOperand = Number(rightOperand);
    this.operator = operator;
    this.calculateResult = function() {
        let result = 0;
        if (this.operator === "+") {
            result = this.leftOperand + this.rightOperand;
        }
        else if(this.operator === "-") {
            result = this.leftOperand - this.rightOperand;
        }
        else if(this.operator === "*") {
            result = this.leftOperand * this.rightOperand;
        }
        else {
            result = this.leftOperand / this.rightOperand;
        }
        return result;
    }
}
module.exports = Calculator;
