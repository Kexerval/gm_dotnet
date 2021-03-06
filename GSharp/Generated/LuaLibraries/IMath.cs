//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSharp.Generated.LuaLibraries {
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System;
    
    
    /// <summary>
    /// The math library is a standard Lua library that provides functions for manipulating numbers. In Garry's Mod several additional math functions have been added.
    /// </summary>
    public interface IMath {
        
        /// <summary>
        /// Calculates the absolute value of a number (effectively removes any negative sign).
        /// </summary>
        /// <returns>Type: System.Double - absolute_value</returns>
        /// <param name='x'>The number to get the absolute value of.</param>
        double abs(double x);
        
        /// <summary>
        /// Returns the arc cosine of the given number.
        /// </summary>
        /// <returns>Type: System.Double -  acos</returns>
        /// <param name='normal'>Value in range of -1 - 1.</param>
        double acos(double normal);
        
        /// <summary>
        /// Calculates the difference between two angles.
        /// </summary>
        /// <returns>Type: System.Double - The difference between the angles between -180 and 180</returns>
        /// <param name='a'>The first angle.</param>
        /// <param name='b'>The second angle.</param>
        double AngleDifference(double a, double b);
        
        /// <summary>
        /// Increments an angle towards another by specified rate.NoteThis function is for numbers representing angles (0-360), NOT TypeAngle objects!
        /// </summary>
        /// <returns>Type: System.Double - Modified angle</returns>
        /// <param name='currentAngle'>The current angle to increase</param>
        /// <param name='targetAngle'>The angle to increase towards</param>
        /// <param name='rate'>The amount to approach the target angle by</param>
        double ApproachAngle(double currentAngle, double targetAngle, double rate);
        
        /// <summary>
        /// Gradually approaches the target value by the specified amount.
        /// </summary>
        /// <returns>Type: System.Double - New current value, closer to the target than it was previously.</returns>
        /// <param name='current'>The value we're currently at.</param>
        /// <param name='target'>The target value. This function will never overshoot this value.</param>
        /// <param name='change'>The amount that the current value is allowed to change by to approach the target. (It makes no difference whether this is positive or negative.)</param>
        double Approach(double current, double target, double change);
        
        /// <summary>
        /// Returns the arc sine of the given number.
        /// </summary>
        /// <returns>Type: System.Double -  asin</returns>
        /// <param name='normal'>Value in range of -1 - 1.</param>
        double asin(double normal);
        
        /// <summary>
        /// Returns math.atan(y / x) in radians. The result is between -math.pi and math.pi.
        /// </summary>
        /// <returns>Type: System.Double - atan2</returns>
        /// <param name='y'>Y coordinate.</param>
        /// <param name='x'>X coordinate.</param>
        double atan2(double y, double x);
        
        /// <summary>
        /// Returns the arc tangents of the given number.
        /// </summary>
        /// <returns>Type: System.Double -  atan</returns>
        /// <param name='normal'>Value in range of -1 - 1.</param>
        double atan(double normal);
        
        /// <summary>
        /// Converts a binary string into a number.
        /// </summary>
        /// <returns>Type: System.Double - Base 10 number.</returns>
        /// <param name='string'>Binary string to convert</param>
        double BinToInt(string @string);
        
        /// <summary>
        /// Basic code for [[wikipedia:Bézier curve|Bézier-Spline]] algorithm.
        /// </summary>
        /// <returns>Type: System.Object - Point on Bezier curve, related to tDiff.</returns>
        /// <param name='tDiff'></param>
        /// <param name='tPoints'>A table of TypeVectors</param>
        /// <param name='tMax'></param>
        object BSplinePoint(double tDiff, object[] tPoints, double tMax);
        
        /// <summary>
        /// Basic code for Bezier-Spline algorithm.
        /// </summary>
        /// <param name='i'></param>
        /// <param name='k'></param>
        /// <param name='t'></param>
        /// <param name='tinc'></param>
        void calcBSplineN(double i, double k, double t, double tinc);
        
        /// <summary>
        /// Ceils or rounds a number up.
        /// </summary>
        /// <returns>Type: System.Double - ceiled numbers</returns>
        /// <param name='number'>The number to be rounded up.</param>
        double ceil(double number);
        
        /// <summary>
        /// Clamps a number between a minimum and maximum value
        /// </summary>
        /// <returns>Type: System.Double - The clamped value.</returns>
        /// <param name='input'>The number to clamp.</param>
        /// <param name='min'>The minimum value, this function will never return a number less than this.</param>
        /// <param name='max'>The maximum value, this function will never return a number greater than this.</param>
        double Clamp(double input, double min, double max);
        
        /// <summary>
        /// Returns hyperbolic cosine of the given number.
        /// </summary>
        /// <returns>Type: System.Double -  hcos</returns>
        /// <param name='number'>Value in radians.</param>
        double cosh(double number);
        
        /// <summary>
        /// Returns cosine of given angle.
        /// </summary>
        /// <returns>Type: System.Double - Cosine of given angle</returns>
        /// <param name='number'>Angle in radians</param>
        double cos(double number);
        
        /// <summary>
        /// Converts radians to degrees.
        /// </summary>
        /// <returns>Type: System.Double -  degrees</returns>
        /// <param name='radians'>Value to be converted to degrees.</param>
        double deg(double radians);
        
        /// <summary>
        /// Returns the difference between two points in 2D space.
        /// </summary>
        /// <returns>Type: System.Double - Distance between the two points</returns>
        /// <param name='x1'>X position of first point</param>
        /// <param name='y1'>Y position of first point</param>
        /// <param name='x2'>X position of second point</param>
        /// <param name='y2'>Y position of second point</param>
        double Distance(double x1, double y1, double x2, double y2);
        
        /// <summary>
        /// Calculates the progress of a value fraction, taking in to account given easing fractions
        /// </summary>
        /// <returns>Type: System.Double - Eased Value</returns>
        /// <param name='progress'>Fraction of the progress to ease</param>
        /// <param name='easeIn'>Fraction of how much easing to begin with</param>
        /// <param name='easeOut'>Fraction of how much easing to end with</param>
        double EaseInOut(double progress, double easeIn, double easeOut);
        
        /// <summary>
        /// Returns the x power of the euler constant.
        /// </summary>
        /// <returns>Type: System.Double -  result</returns>
        /// <param name='exponent'>The exponent for the function.</param>
        double exp(double exponent);
        
        /// <summary>
        /// Floors or rounds a number down.
        /// </summary>
        /// <returns>Type: System.Double - floored numbers</returns>
        /// <param name='number'>The number to be rounded down.</param>
        double floor(double number);
        
        /// <summary>
        /// Returns the modulus of the specified values.'''NB''': While this is similar to the % operator, '''it will return a negative value if the first argument is negative''', whereas the % operator will return a ''positive'' value '''even if the first operand is negative'''.
        /// </summary>
        /// <returns>Type: System.Double - The calculated modulus.</returns>
        /// <param name='base'>The base value.</param>
        /// <param name='modulator'>The modulator.</param>
        double fmod(double @base, double modulator);
        
        /// <summary>
        /// used to split the number value into a normalized fraction and an exponent. Two values are returned: the first is a value always in the range 1/2 (inclusive) to 1 (exclusive) and the second is an exponent.
        /// </summary>
        /// <returns>Type: System.Double -  normalizedFraction</returns>
        /// <param name='inputValue'>The value to get the normalized fraction and the exponent from.</param>
        double frexp(double inputValue);
        
        /// <summary>
        /// Converts an integer to a binary (base-2) string.
        /// </summary>
        /// <returns>Type: System.String - Binary number string. The length of this will always be a multiple of 3.</returns>
        /// <param name='int'>Number to be converted.</param>
        string IntToBin(double @int);
        
        /// <summary>
        /// Takes a normalised number and returns the floating point representation.
        /// </summary>
        /// <returns>Type: System.Double -  result</returns>
        /// <param name='normalizedFraction'>The value to get the normalized fraction and the exponent from.</param>
        /// <param name='exponent'>The value to get the normalized fraction and the exponent from.</param>
        double ldexp(double normalizedFraction, double exponent);
        
        /// <summary>
        /// Returns the base-10 logarithm of x. This is usually more accurate than math.log(x, 10).
        /// </summary>
        /// <param name='x'>The value to get the base from exponent from.</param>
        void log10(double x);
        
        /// <summary>
        /// With one argument, return the natural logarithm of x (to base e).With two arguments, return the logarithm of x to the given base, calculated as log(x)/log(base).
        /// </summary>
        /// <returns>Type: System.Double - Logarithm of x to the given base</returns>
        /// <param name='x'>The value to get the base from exponent from.</param>
        /// <param name='base'></param>
        double log(double x, [OptionalAttribute()] double @base);
        
        /// <summary>
        /// Returns the largest value of all arguments.
        /// </summary>
        /// <returns>Type: System.Double - The largest number</returns>
        /// <param name='numbers'>Numbers to get the largest from</param>
        double max(object numbers);
        
        /// <summary>
        /// Returns the smallest value of all arguments.
        /// </summary>
        /// <returns>Type: System.Double - The smallest number</returns>
        /// <param name='numbers'>Numbers to get the smallest from.</param>
        double min(object numbers);
        
        /// <summary>
        /// Returns the integral and fractional component of the modulo operation.
        /// </summary>
        /// <param name='base'>The base value.</param>
        void modf(double @base);
        
        /// <summary>
        /// Normalizes angle, so it returns value between -180 and 180.
        /// </summary>
        /// <returns>Type: System.Double - The normalized angle, in the range of -180 to 180 degrees.</returns>
        /// <param name='angle'>The angle to normalize, in degrees.</param>
        double NormalizeAngle(double angle);
        
        /// <summary>
        /// Returns x raised to the power y.In particular, math.pow(1.0, x) and math.pow(x, 0.0) always return 1.0, even when x is a zero or a NaN. If both x and y are finite, x is negative, and y is not an integer then math.pow(x, y) is undefined.
        /// </summary>
        /// <returns>Type: System.Double - y power of x</returns>
        /// <param name='x'>Base.</param>
        /// <param name='y'>Exponent.</param>
        double pow(double x, double y);
        
        /// <summary>
        /// Converts an angle in degrees to it's equivalent in radians.
        /// </summary>
        /// <returns>Type: System.Double - radians</returns>
        /// <param name='degrees'>The angle measured in degrees.</param>
        double rad(double degrees);
        
        /// <summary>
        /// Seeds the random number generator. The same seed will guarantee the same sequence of numbers each time with LibraryFunctionmathrandom.For shared random values across predicted realms, use LibraryFunctionutilSharedRandom.WarningIncorrect usage of this function will affect ''all'' random numbers in the game.
        /// </summary>
        /// <param name='seed'>The new seed</param>
        void randomseed(double seed);
        
        /// <summary>
        /// When called without arguments, returns a uniform pseudo-random real number in the range 0 to 1 which includes 0 but excludes 1.When called with an integer number m, returns a uniform pseudo-random integer in the range 1 to m inclusive.When called with two integer numbers m and n, returns a uniform pseudo-random integer in the range m to n inclusive.
        /// </summary>
        /// <returns>Type: System.Double - Random value</returns>
        /// <param name='m'>If m is the only parameter: upper limit.<br />If n is also provided: lower limit.If provided, this must be an integer.</param>
        /// <param name='n'>Upper limit.If provided, this must be an integer.</param>
        double random(double m, double n);
        
        /// <summary>
        /// Returns a random float between min and max.
        /// </summary>
        /// <returns>Type: System.Double - Random float between min and max.</returns>
        /// <param name='min'>The minimum value.</param>
        /// <param name='max'>The maximum value.</param>
        double Rand(double min, double max);
        
        /// <summary>
        /// Rounds the given value to the nearest whole number or to the given decimal places.
        /// </summary>
        /// <returns>Type: System.Double - The rounded value.</returns>
        /// <param name='value'>The value to round.</param>
        /// <param name='decimals'>The decimal places to round to.</param>
        double Round(double value, [OptionalAttribute()] double decimals);
        
        /// <summary>
        /// Returns hyperbolic sine of the given number.
        /// </summary>
        /// <returns>Type: System.Double -  sinh</returns>
        /// <param name='number'>Value in radians.</param>
        double sinh(double number);
        
        /// <summary>
        /// Returns sine of given angle.
        /// </summary>
        /// <returns>Type: System.Double - Sine for given angle</returns>
        /// <param name='number'>Angle in radians</param>
        double sin(double number);
        
        /// <summary>
        /// Returns the square root of the number.
        /// </summary>
        /// <returns>Type: System.Double - squareRoot</returns>
        /// <param name='value'>Value to get the square root of.</param>
        double sqrt(double value);
        
        /// <summary>
        /// Returns hyperbolic tangents of the given number.
        /// </summary>
        /// <returns>Type: System.Double -  tanh</returns>
        /// <param name='number'>Value in radians.</param>
        double tanh(double number);
        
        /// <summary>
        /// Returns tangents of given angle.
        /// </summary>
        /// <returns>Type: System.Double -  tangents</returns>
        /// <param name='value'>Angle in radians</param>
        double tan(double value);
        
        /// <summary>
        /// Returns the fraction of where the current time is relative to the start and end times
        /// </summary>
        /// <returns>Type: System.Double - Fraction</returns>
        /// <param name='start'>Start time in seconds</param>
        /// <param name='end'>End time in seconds</param>
        /// <param name='current'>Current time in seconds</param>
        double TimeFraction(double start, double end, double current);
        
        /// <summary>
        /// DeprecatedYou should use LibraryFunctionmathDistance insteadReturns the difference between two points in 2D space. Alias of LibraryFunctionmathDistance.
        /// </summary>
        /// <returns>Type: System.Double - Distance between the two points.</returns>
        /// <param name='x1'>X position of first point</param>
        /// <param name='y1'>Y position of first point</param>
        /// <param name='x2'>X position of second point</param>
        /// <param name='y2'>Y position of second point</param>
        double Dist(double x1, double y1, double x2, double y2);
        
        /// <summary>
        /// DeprecatedThis is removed in Lua versions later than what GMod is currently using. You should use the % operator or LibraryFunctionmathfmod instead.Returns the modulus of the specified values. Same as LibraryFunctionmathfmod.
        /// </summary>
        /// <returns>Type: System.Double - The calculated modulus</returns>
        /// <param name='base'>The base value</param>
        /// <param name='modulator'>Modulator</param>
        double mod(double @base, double modulator);
        
        /// <summary>
        /// Remaps the value from one range to another
        /// </summary>
        /// <returns>Type: System.Double - The number in the new range</returns>
        /// <param name='value'>The value</param>
        /// <param name='inMin'>The minimum of the initial range</param>
        /// <param name='inMax'>The maximum of the initial range</param>
        /// <param name='outMin'>The minimum of new range</param>
        /// <param name='outMax'>The maximum of new range</param>
        double Remap(double value, double inMin, double inMax, double outMin, double outMax);
        
        /// <summary>
        /// Rounds towards zero.
        /// </summary>
        /// <param name='num'>The number to truncate</param>
        /// <param name='digits'>The amount of digits to keep after the point.</param>
        void Truncate(double num, double digits);
    }
}
