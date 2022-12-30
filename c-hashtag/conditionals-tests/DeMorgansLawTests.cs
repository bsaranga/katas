using System;
using System.Collections.Generic;
using Xunit;

namespace conditionals;

public class DeMorgansLawTests
{
    [Fact]
    public void NegationOfConjunction()
    {
        Func<List<bool>, bool> conditional1 = p => !(p[0] && p[1]);
        Func<List<bool>, bool> conditional2 = p => !p[0] || !p[1];

        var truthTable = new List<List<bool>>
        {
            new List<bool> { true, true },
            new List<bool> { false, true },
            new List<bool> { true, false },
            new List<bool> { false, false },
        };

        truthTable.ForEach(args => {
            var res1 = conditional1(args);
            var res2 = conditional2(args);
            Assert.Equal(res1, res2);
        });
    }

    [Fact]
    public void NegationOfDisjunction()
    {
        Func<List<bool>, bool> conditional1 = p => !(p[0] || p[1]);
        Func<List<bool>, bool> conditional2 = p => !p[0] && !p[1];

        var truthTable = new List<List<bool>>
        {
            new List<bool> { true, true },
            new List<bool> { false, true },
            new List<bool> { true, false },
            new List<bool> { false, false },
        };

        truthTable.ForEach(args => {
            var res1 = conditional1(args);
            var res2 = conditional2(args);
            Assert.Equal(res1, res2);
        });
    }

    [Fact]
    public void Simplification()
    {
        // Given
        bool isRaining = false;
        float temperature = 10;
        bool roadIsIcy = true;
        float gasLevel = 10;
        float reserveLevel = 11;
        float alcoholThreshold = 56;
    
        // When
        if (!isRaining && !(temperature < 0) && !roadIsIcy && (gasLevel > reserveLevel) && (alcoholThreshold > 50)) {
            Console.WriteLine("Safe to Drive");
        } else Console.WriteLine("Not Safe");

        if ((isRaining || (temperature < 0) || roadIsIcy) || !(gasLevel > reserveLevel) || !(alcoholThreshold > 50)) {
            Console.WriteLine("Safe to Drive");
        } else Console.WriteLine("Not Safe");
    
        // Then
    }
}