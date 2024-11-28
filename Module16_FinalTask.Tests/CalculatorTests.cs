using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using Module16_FinalTask;

namespace Module16_FinalTask.Tests;

public class CalculatorTests
{
    [Test]
    public void AdditionalConsidersTheBorders() // проверка на отработку переполнения типа
    {
        var unit = new Calculator();
        Assert.That(0, Is.EqualTo(unit.Additional(int.MaxValue, int.MaxValue)));
    }

    [Test]
    public void DivisionDontThrowsExeptions() // проверка на отработку нуля в знаменателе
    {
        var unit = new Calculator();
        Assert.DoesNotThrow(() => unit.Division(1, 0));
    }

    [Test]
    public void SubstractionReturnsCorrectValue() // простая проверка
    {
        var unit = new Calculator();
        Assert.That(15, Is.EqualTo(unit.Subtraction(22, 7))); // в пакете 3.13 Equals рекомендовали заменить на AreEqual, в этом пакете (4.2.2) просят использовать That(smth, Is.EqualTo(smth))
    }

    [Test]
    public void MultiplicationReturnsCorrectValue() // простая проверка
    {
        var unit = new Calculator();
        Assert.That(56, Is.EqualTo(unit.Multiplication(7, 8)));
    }
}
