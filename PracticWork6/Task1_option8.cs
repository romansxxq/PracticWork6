using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticWork6
{
    internal class Task1_option8
    {
        static void Main(string[] args)
        {
            double m, n, a, b,c,res;
            String S;
            m = 36;
            n = 26;
        Repeat:
            S = m.ToString();

        Repeat1:
            S = Interaction.InputBox("Введіть m ", "Введення", S);
            try
            {
                m = Convert.ToDouble(S);
            }
            catch (System.FormatException){
                if (MessageBox.Show("Ви ввели не число" + Strings.Chr(15) + Strings.Chr(13) + "Бажаєте повторити?", 
                    "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                goto Repeat1;
                else
                    return;
            }
            S = n.ToString();
        Repeat2:
            S = Interaction.InputBox("Введіть n ", "Введення",S);
            try
            {
                n = Convert.ToDouble(S);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число" + Strings.Chr(15) + Strings.Chr(13) + "Бажаєте повторити?",
                   "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                goto Repeat2;
                else
                    return;
            }
            a = 2 * m;
            b = Math.Sqrt(m*n)/3;
            c = m+2* n;

            double max = Math.Max(a , Math.Max(b, c));
            int countMax = 0;
            if (a == max)
                countMax++;
            if (b == max)
                countMax++;
            if (c == max)
                countMax++;
            if (MessageBox.Show($"При m = {m} та n = {n} обчислено a = {a}, b = {b}, c = {c}" +
                $"\nМаксимальне значення: {max}\nКількість максимальних значень: {countMax}" + Strings.Chr(13) +
                "Бажаєте повторити?", "Результати обчислень", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                goto Repeat2;
        }
    }
}
