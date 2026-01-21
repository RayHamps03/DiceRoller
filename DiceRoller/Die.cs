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

    private static readonly Random rand = new();



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

        // Forces the die to start as a random number
        Roll();
    }
    /// <summary>
    /// Gets the number of sides for the die.
    /// </summary>
    public byte NumberOfSides { get; private set; }

    /// <summary>
    /// The current face up value for the die.
    /// </summary>
    public byte FaceUpValue { get; private set; }

    /// <summary>
    /// Generates a random value representing the result of rolling the die and updates the face-up value.
    /// </summary>
    /// <returns>A byte value between 1 and the number of sides on the die, inclusive, indicating the result of the roll.</returns>
    public byte Roll()
    {

        FaceUpValue = Convert.ToByte(rand.Next(1, NumberOfSides + 1));

        return FaceUpValue;
    }
}

