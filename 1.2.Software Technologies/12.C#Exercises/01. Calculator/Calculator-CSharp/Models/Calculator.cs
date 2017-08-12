using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Calculator_CSharp.Models
{
    public class Calculator
    {
        public decimal LeftOperand { get; set; }

        public decimal RightOperand { get; set; }

        public char Operator { get; set; }

        public decimal Result { get; set; }

        public decimal Calculate() 
        {
            if (this.Operator == '+')
            {
                return LeftOperand + RightOperand;
            }
            else if (this.Operator == '-')
            {
                return LeftOperand - RightOperand;
            }
            else if (this.Operator == '/')
            {
                return LeftOperand / RightOperand;
            }
            else
            {
                return LeftOperand * RightOperand;
            }
        }

        public Calculator()
        {
            this.Result = 0;
        }
        public Calculator(decimal leftOperand, decimal rightOperand, char op)
        {
            this.LeftOperand = leftOperand;
            this.RightOperand = rightOperand;
            this.Operator = op;
        }
    }
}