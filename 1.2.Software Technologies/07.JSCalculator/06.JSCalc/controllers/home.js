const Calculator = require('../models/Calculator');
module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let calculatorParameters = req.body['calculator'];
        let calculator = new Calculator(calculatorParameters.leftOperand, calculatorParameters.rightOperand, calculatorParameters.operator);
        res.render('home/index', {'calculator':calculator, 'result':calculator.calculateResult()})
    }
};