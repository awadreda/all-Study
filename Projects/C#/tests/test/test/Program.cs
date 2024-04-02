using System;
using System.Data;

class MathExpressionEvaluator
{
    static void Main()
    {
        string expression = "12+3-6*(1+6)";
        double result = EvaluateMathExpression(expression);

        Console.WriteLine("Expression: " + expression);
        Console.WriteLine("Result: " + result);
    }

    static double EvaluateMathExpression(string expression)
    {
        // Create a DataTable to use its Compute method
        DataTable table = new DataTable();

        // Add a column to the DataTable
        DataColumn column = new DataColumn("expression", typeof(double));
        table.Columns.Add(column);

        // Create a new DataRow
        DataRow row = table.NewRow();
        row["expression"] = expression;

        // Add the DataRow to the DataTable
        table.Rows.Add(row);

        // Use the Compute method to evaluate the expression
        double result = double.Parse((string)row["expression"]);

        return result;
    }
}
