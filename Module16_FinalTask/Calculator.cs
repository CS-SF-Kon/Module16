using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16_FinalTask;

public class Calculator
{
    public int Additional(int a, int b)
    {
        if (b < int.MaxValue - a) // позволил себе доработать исходник в части проверки на переполнение типа и протестировать её
        {
            return a + b;
        }
        else
        {
            Console.WriteLine("Too big numbers for current type");
            return 0;
        }
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    public int Multiplication(int a, int b) // в оригинале было mIltiplication
    {
        return a * b;
    }

    public int Division(int a, int b)
    {
        try // можно было бы оставить проверяемый код без изменения, а тест сделать на невозвращение исключений и типа тест не выполнянется, значит, нужно дорабатывать код, но я решил его сразу доработать
        {
            return a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return 0;
    }
}
