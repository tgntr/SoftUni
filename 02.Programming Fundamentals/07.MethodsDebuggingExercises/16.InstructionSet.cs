using System;

class InstructionSet
{
    static void Main()
    {
        string instruction = Console.ReadLine();
        string[] instructions = instruction.Split(' ');
        long result = 0;
        while (instructions[0] != "END")
        {
            
            switch (instructions[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(instructions[1]);
                        result = operandOne + 1;
                        Console.WriteLine(result);
                        instruction = Console.ReadLine();
                        instructions = instruction.Split(' ');
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(instructions[1]);
                        result = operandOne - 1;
                        Console.WriteLine(result);
                        instruction = Console.ReadLine();
                        instructions = instruction.Split(' ');
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(instructions[1]);
                        long operandTwo = long.Parse(instructions[2]);
                        result = operandOne + operandTwo;
                        Console.WriteLine(result);
                        instruction = Console.ReadLine();
                        instructions = instruction.Split(' ');
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(instructions[1]);
                        long operandTwo = long.Parse(instructions[2]);
                        result = operandOne * operandTwo;
                        Console.WriteLine(result);
                        instruction = Console.ReadLine();
                        instructions = instruction.Split(' ');
                        break;
                    }
                    
            }
        }
        
    }
}