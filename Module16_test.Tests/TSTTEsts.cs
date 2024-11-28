using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using Module16_test;

namespace Module16_test.Tests;

public class TSTTEsts
{
    [Test]
    public void Sum_CorrectValue()
    {
        var unit = new TST();

        Assert.AreEqual(5, unit.Sum(2, 3));
    }
}
