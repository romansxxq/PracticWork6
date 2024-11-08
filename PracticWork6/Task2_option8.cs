using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticWork6
{
    internal class Task2_option8
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, D;
            string S, res;
            a = 25;
            b = 7;
            c = -3;
        Repeat:
            S = a.ToString();

        Repeat1:
            S = Interaction.InputBox("Введіть a ", "Введення", S);
            try
            {
                a = Convert.ToDouble(S);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число" + Strings.Chr(15) + Strings.Chr(13) + "Бажаєте повторити?",
                    "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    goto Repeat1;
                else
                    return;
            }
            S = b.ToString();
        Repeat2:
            S = Interaction.InputBox("Введіть b ", "Введення", S);
            try
            {
                b = Convert.ToDouble(S);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число" + Strings.Chr(15) + Strings.Chr(13) + "Бажаєте повторити?",
                   "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    goto Repeat2;
                else
                    return;
            }
            S = c.ToString();
        Repeat3:
            S = Interaction.InputBox("Введіть c ", "Введення", S);
            try
            {
                c = Convert.ToDouble(S);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число" + Strings.Chr(15) + Strings.Chr(13) + "Бажаєте повторити?",
                   "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    goto Repeat3;
                else
                    return;
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        res = "Рівняння має безліч розв'язків.";
                    }
                    else
                    {
                        res = "Рівняння не має розв'язків.";
                    }
                }
                else
                {
                    double x = -c / b;
                    res = $"Рівняння має один корінь: x = {x}";
                }
            }
            else
            {
                D = b * b - 4 * a * c;

                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    res = $"Рівняння має два корені: x1 = {x1}, x2 = {x2}";
                }
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    res = $"Рівняння має кратний корінь: x = {x}";
                }
                else
                {
                    res = "Рівняння не має розв'язків.";
                }
            }
            if (MessageBox.Show($"При a = {a}, b = {b}, b = {c} Результат:" + res.ToString() + "\nБажаєте повторити?", "Результати обчислень", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                goto Repeat;

        }

    }
}

//using System;
//using Microsoft.VisualBasic;
//using System.Windows.Forms;

//namespace PracticWork6
//{
//    class Task2_option8
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c, x1, x2, D;
//            string REZ, s;
//            a = 25;
//            b = 7;
//            c = -3;
//            s = a.ToString();

//        PovorA:
//            s = Interaction.InputBox("Введіть a:", "Введення", s);
//            try
//            {
//                a = Convert.ToDouble(s);
//            }
//            catch (System.FormatException)
//            {
//                if (MessageBox.Show("Ви ввели не число!\n\nБажаєте повторити?", "Увага!",
//                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
//                    goto PovorA;
//                else return;
//            }

//            s = b.ToString();
//        PovorB:
//            s = Interaction.InputBox("Введіть b:", "Введення", s);
//            try
//            {
//                b = Convert.ToDouble(s);
//            }
//            catch (System.FormatException)
//            {
//                if (MessageBox.Show("Ви ввели не число!\n\nБажаєте повторити?", "Увага!",
//                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
//                    goto PovorB;
//                else return;
//            }

//            s = c.ToString();
//        PovorC:
//            s = Interaction.InputBox("Введіть c:", "Введення", s);
//            try
//            {
//                c = Convert.ToDouble(s);
//            }
//            catch (System.FormatException)
//            {
//                if (MessageBox.Show("Ви ввели не число!\n\nБажаєте повторити?", "Увага!",
//                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
//                    goto PovorC;
//                else return;
//            }

//            if (a != 0)
//            {
//                D = b * b - 4 * a * c;
//                if (D > 0)
//                {
//                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
//                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
//                    REZ = "Рівняння має два корені x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
//                }
//                else if (D < 0)
//                {
//                    REZ = "Рівняння розв'язків не має";
//                }
//                else
//                {
//                    x1 = -b / (2 * a);
//                    REZ = "Рівняння має кратний корінь x = " + x1.ToString();
//                }
//            }
//            else
//            {
//                if (b != 0)
//                {
//                    x1 = -c / b;
//                    REZ = "Рівняння має один корінь x = " + x1.ToString();
//                }
//                else
//                {
//                    if (c == 0)
//                        REZ = "Рівняння має безліч розв'язків";
//                    else
//                        REZ = "Рівняння розв'язків не має";
//                }
//            }

//            if (MessageBox.Show("При a = " + a.ToString() + ", b = " + b.ToString() + ", c = " + c.ToString() +
//                "" + REZ + "\nБажаєте розрахувати ще?", "Результати обчислень",
//                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
//                goto PovorA;
//        }
//    }
//}
