using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller;
/// <summary>
/// Represents an individual die with a configurable
/// number of sides.
/// </summary>
public class Die
{
    /// <summary>
    /// Initializes a new instance of the Die class with the specified number of sides.
    /// </summary>
    /// <param name="numSides">The number of sides for the die. Must be greater than 1.</param>
    public Die(byte numSides) 
    {
        if (numSides <= 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), 
                $"{nameof(numSides)} must be greater than 0 and less than 21");
        }
        NumberOfSides = numSides;
    }
    /// <summary>
    /// Gets the number of sides for the die.
    /// </summary>
    public byte NumberOfSides { get; private set; }
}

