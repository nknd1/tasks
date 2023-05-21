class Solver
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (token)
                {
                    case "+": stack.Push(operand1 + operand2); break;
                    case "-": stack.Push(operand1 - operand2); break;
                    case "*": stack.Push(operand1 * operand2); break;
                    case "/": stack.Push(operand1 / operand2); break;               
                }
            }
        }
        Console.WriteLine(stack.Pop());
    }

}

