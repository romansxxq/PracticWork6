using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace QuadraticEquationSolver
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            double a, b, c;
            string input;
            string result;

        RepeatInput:
            input = Interaction.InputBox("Введіть значення a, b, c через пробіл (наприклад: 1 6 3):", "Введення коефіцієнтів", "1 6 3");
            string[] coefficients = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (coefficients.Length < 3)
            {
                MessageBox.Show("Помилка: введіть три значення для a, b та c.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto RepeatInput;
            }

            try
            {
                a = Convert.ToDouble(coefficients[0]);
                b = Convert.ToDouble(coefficients[1]);
                c = Convert.ToDouble(coefficients[2]);
            }
            catch (FormatException)
            {
                if (MessageBox.Show("Ви ввели не число.\nБажаєте повторити?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    goto RepeatInput;
                }
                else
                {
                    return;
                }
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        result = "Рівняння має безліч розв'язків.";
                    }
                    else
                    {
                        result = "Рівняння не має розв'язків.";
                    }
                }
                else
                {
                    double x = -c / b;
                    result = $"Рівняння має один корінь: x = {x}";
                }
            }
            else
            {
                double D = b * b - 4 * a * c;

                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    result = $"Рівняння має два корені: x1 = {x1}, x2 = {x2}";
                }
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    result = $"Рівняння має кратний корінь: x = {x}";
                }
                else
                {
                    result = "Рівняння не має розв'язків.";
                }
            }

            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
//if (a == 0)
//{
//    if (b == 0)
//    {
//        if (c == 0)
//        {
//            res = "Рівняння має безліч розв'язків";
//        }
//        else
//        {
//            res = "Рівняння розв'язків не має";
//        }
//    }
//    else
//    {
//        x1 = -c / b;
//        res = $"Рівняння має один корінь x = {x1}";
//    }
//}
//else
//{
//    D = b * b - (4 * a * c);
//    if (D > 0)
//    {
//        x1 = ((-b - Math.Sqrt(D)) / (2 * a));
//        x2 = ((-b + Math.Sqrt(D)) / (2 * a));
//        res = $"Рівняння має два корені x1 = {x1}\nx2={x2}";
//    }
//    else
//    {
//        if (D < 0)
//        {
//            res = "Рівняння розв'язків немає";
//        }
//        else
//        {
//            x1 = -b / (2 * a);
//            res = $"Рівняння має кратний корінь x = {x1}";
//        }
//    }
//}