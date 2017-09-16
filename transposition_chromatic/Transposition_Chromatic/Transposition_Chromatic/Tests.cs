using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Transposition_Chromatic
{
    [TestFixture]
    class Tests
    {
        [Test, Description("Should return the same note.")]
        public void UnisonTests()
        {
            Assert.AreEqual("A", Harmonizer.Transpose("A", 0));
            Assert.AreEqual("A#", Harmonizer.Transpose("A#", 0));
            Assert.AreEqual("B", Harmonizer.Transpose("B", 0));
            Assert.AreEqual("C", Harmonizer.Transpose("C", 0));
            Assert.AreEqual("C#", Harmonizer.Transpose("C#", 0));
            Assert.AreEqual("D", Harmonizer.Transpose("D", 0));
            Assert.AreEqual("D#", Harmonizer.Transpose("D#", 0));
            Assert.AreEqual("E", Harmonizer.Transpose("E", 0));
            Assert.AreEqual("F", Harmonizer.Transpose("F", 0));
            Assert.AreEqual("F#", Harmonizer.Transpose("F#", 0));
            Assert.AreEqual("G", Harmonizer.Transpose("G", 0));
            Assert.AreEqual("G#", Harmonizer.Transpose("G#", 0));
        }

        [Test, Description("Should return the same note.")]
        public void OctaveTests()
        {
            Assert.AreEqual("A", Harmonizer.Transpose("A", 12));
            Assert.AreEqual("A#", Harmonizer.Transpose("A#", 12));
            Assert.AreEqual("B", Harmonizer.Transpose("B", 12));
            Assert.AreEqual("C", Harmonizer.Transpose("C", 12));
            Assert.AreEqual("C#", Harmonizer.Transpose("C#", 12));
            Assert.AreEqual("D", Harmonizer.Transpose("D", 12));
            Assert.AreEqual("D#", Harmonizer.Transpose("D#", 12));
            Assert.AreEqual("E", Harmonizer.Transpose("E", 12));
            Assert.AreEqual("F", Harmonizer.Transpose("F", 12));
            Assert.AreEqual("F#", Harmonizer.Transpose("F#", 12));
            Assert.AreEqual("G", Harmonizer.Transpose("G", 12));
            Assert.AreEqual("G#", Harmonizer.Transpose("G#", 12));
        }

        [Test, Description("Should return the same note.")]
        public void SubOctaveTests()
        {
            Assert.AreEqual("A", Harmonizer.Transpose("A", -12));
            Assert.AreEqual("A#", Harmonizer.Transpose("A#", -12));
            Assert.AreEqual("B", Harmonizer.Transpose("B", -12));
            Assert.AreEqual("C", Harmonizer.Transpose("C", -12));
            Assert.AreEqual("C#", Harmonizer.Transpose("C#", -12));
            Assert.AreEqual("D", Harmonizer.Transpose("D", -12));
            Assert.AreEqual("D#", Harmonizer.Transpose("D#", -12));
            Assert.AreEqual("E", Harmonizer.Transpose("E", -12));
            Assert.AreEqual("F", Harmonizer.Transpose("F", -12));
            Assert.AreEqual("F#", Harmonizer.Transpose("F#", -12));
            Assert.AreEqual("G", Harmonizer.Transpose("G", -12));
            Assert.AreEqual("G#", Harmonizer.Transpose("G#", -12));
        }

        [Test, Description("Should return the transposition of note A by positive number of semi-tones.")]
        public void PositiveIntervalsOfA()
        {
            Assert.AreEqual("A#", Harmonizer.Transpose("A", 1));
            Assert.AreEqual("B", Harmonizer.Transpose("A", 2));
            Assert.AreEqual("C", Harmonizer.Transpose("A", 3));
            Assert.AreEqual("C#", Harmonizer.Transpose("A", 4));
            Assert.AreEqual("D", Harmonizer.Transpose("A", 5));
            Assert.AreEqual("D#", Harmonizer.Transpose("A", 6));
            Assert.AreEqual("E", Harmonizer.Transpose("A", 7));
            Assert.AreEqual("F", Harmonizer.Transpose("A", 8));
            Assert.AreEqual("F#", Harmonizer.Transpose("A", 9));
            Assert.AreEqual("G", Harmonizer.Transpose("A", 10));
            Assert.AreEqual("G#", Harmonizer.Transpose("A", 11));
        }

        [Test, Description("Should return the transposition of note A by negative number of semi-tones.")]
        public void NegativeIntervalsOfA()
        {
            Assert.AreEqual("G#", Harmonizer.Transpose("A", -1));
            Assert.AreEqual("G", Harmonizer.Transpose("A", -2));
            Assert.AreEqual("F#", Harmonizer.Transpose("A", -3));
            Assert.AreEqual("F", Harmonizer.Transpose("A", -4));
            Assert.AreEqual("E", Harmonizer.Transpose("A", -5));
            Assert.AreEqual("D#", Harmonizer.Transpose("A", -6));
            Assert.AreEqual("D", Harmonizer.Transpose("A", -7));
            Assert.AreEqual("C#", Harmonizer.Transpose("A", -8));
            Assert.AreEqual("C", Harmonizer.Transpose("A", -9));
            Assert.AreEqual("B", Harmonizer.Transpose("A", -10));
            Assert.AreEqual("A#", Harmonizer.Transpose("A", -11));
        }

        [Test, Description("Should return the transposition of note A# by positive number of semi-tones.")]
        public void PositiveIntervalsOfASharp()
        {
            Assert.AreEqual("B", Harmonizer.Transpose("A#", 1));
            Assert.AreEqual("C", Harmonizer.Transpose("A#", 2));
            Assert.AreEqual("C#", Harmonizer.Transpose("A#", 3));
            Assert.AreEqual("D", Harmonizer.Transpose("A#", 4));
            Assert.AreEqual("D#", Harmonizer.Transpose("A#", 5));
            Assert.AreEqual("E", Harmonizer.Transpose("A#", 6));
            Assert.AreEqual("F", Harmonizer.Transpose("A#", 7));
            Assert.AreEqual("F#", Harmonizer.Transpose("A#", 8));
            Assert.AreEqual("G", Harmonizer.Transpose("A#", 9));
            Assert.AreEqual("G#", Harmonizer.Transpose("A#", 10));
            Assert.AreEqual("A", Harmonizer.Transpose("A#", 11));
        }

        [Test, Description("Should return the transposition of note A# by negative number of semi-tones.")]
        public void NegativeIntervalsOfASharp()
        {
            Assert.AreEqual("A", Harmonizer.Transpose("A#", -1));
            Assert.AreEqual("G#", Harmonizer.Transpose("A#", -2));
            Assert.AreEqual("G", Harmonizer.Transpose("A#", -3));
            Assert.AreEqual("F#", Harmonizer.Transpose("A#", -4));
            Assert.AreEqual("F", Harmonizer.Transpose("A#", -5));
            Assert.AreEqual("E", Harmonizer.Transpose("A#", -6));
            Assert.AreEqual("D#", Harmonizer.Transpose("A#", -7));
            Assert.AreEqual("D", Harmonizer.Transpose("A#", -8));
            Assert.AreEqual("C#", Harmonizer.Transpose("A#", -9));
            Assert.AreEqual("C", Harmonizer.Transpose("A#", -10));
            Assert.AreEqual("B", Harmonizer.Transpose("A#", -11));
        }

        [Test, Description("Should return the transposition of note B by positive number of semi-tones.")]
        public void PositiveIntervalsOfB()
        {
            Assert.AreEqual("C", Harmonizer.Transpose("B", 1));
            Assert.AreEqual("C#", Harmonizer.Transpose("B", 2));
            Assert.AreEqual("D", Harmonizer.Transpose("B", 3));
            Assert.AreEqual("D#", Harmonizer.Transpose("B", 4));
            Assert.AreEqual("E", Harmonizer.Transpose("B", 5));
            Assert.AreEqual("F", Harmonizer.Transpose("B", 6));
            Assert.AreEqual("F#", Harmonizer.Transpose("B", 7));
            Assert.AreEqual("G", Harmonizer.Transpose("B", 8));
            Assert.AreEqual("G#", Harmonizer.Transpose("B", 9));
            Assert.AreEqual("A", Harmonizer.Transpose("B", 10));
            Assert.AreEqual("A#", Harmonizer.Transpose("B", 11));
        }

        [Test, Description("Should return the transposition of note B by negative number of semi-tones.")]
        public void NegativeIntervalsOfB()
        {
            Assert.AreEqual("A#", Harmonizer.Transpose("B", -1));
            Assert.AreEqual("A", Harmonizer.Transpose("B", -2));
            Assert.AreEqual("G#", Harmonizer.Transpose("B", -3));
            Assert.AreEqual("G", Harmonizer.Transpose("B", -4));
            Assert.AreEqual("F#", Harmonizer.Transpose("B", -5));
            Assert.AreEqual("F", Harmonizer.Transpose("B", -6));
            Assert.AreEqual("E", Harmonizer.Transpose("B", -7));
            Assert.AreEqual("D#", Harmonizer.Transpose("B", -8));
            Assert.AreEqual("D", Harmonizer.Transpose("B", -9));
            Assert.AreEqual("C#", Harmonizer.Transpose("B", -10));
            Assert.AreEqual("C", Harmonizer.Transpose("B", -11));
        }

        [Test, Description("Should return the transposition of note C by positive number of semi-tones.")]
        public void PositiveIntervalsOfC()
        {
            Assert.AreEqual("C#", Harmonizer.Transpose("C", 1));
            Assert.AreEqual("D", Harmonizer.Transpose("C", 2));
            Assert.AreEqual("D#", Harmonizer.Transpose("C", 3));
            Assert.AreEqual("E", Harmonizer.Transpose("C", 4));
            Assert.AreEqual("F", Harmonizer.Transpose("C", 5));
            Assert.AreEqual("F#", Harmonizer.Transpose("C", 6));
            Assert.AreEqual("G", Harmonizer.Transpose("C", 7));
            Assert.AreEqual("G#", Harmonizer.Transpose("C", 8));
            Assert.AreEqual("A", Harmonizer.Transpose("C", 9));
            Assert.AreEqual("A#", Harmonizer.Transpose("C", 10));
            Assert.AreEqual("B", Harmonizer.Transpose("C", 11));
        }

        [Test, Description("Should return the transposition of note C by negative number of semi-tones.")]
        public void NegativeIntervalsOfC()
        {
            Assert.AreEqual("B", Harmonizer.Transpose("C", -1));
            Assert.AreEqual("A#", Harmonizer.Transpose("C", -2));
            Assert.AreEqual("A", Harmonizer.Transpose("C", -3));
            Assert.AreEqual("G#", Harmonizer.Transpose("C", -4));
            Assert.AreEqual("G", Harmonizer.Transpose("C", -5));
            Assert.AreEqual("F#", Harmonizer.Transpose("C", -6));
            Assert.AreEqual("F", Harmonizer.Transpose("C", -7));
            Assert.AreEqual("E", Harmonizer.Transpose("C", -8));
            Assert.AreEqual("D#", Harmonizer.Transpose("C", -9));
            Assert.AreEqual("D", Harmonizer.Transpose("C", -10));
            Assert.AreEqual("C#", Harmonizer.Transpose("C", -11));
        }

        [Test, Description("Should return the transposition of note C# by positive number of semi-tones.")]
        public void PositiveIntervalsOfCSharp()
        {
            Assert.AreEqual("D", Harmonizer.Transpose("C#", 1));
            Assert.AreEqual("D#", Harmonizer.Transpose("C#", 2));
            Assert.AreEqual("E", Harmonizer.Transpose("C#", 3));
            Assert.AreEqual("F", Harmonizer.Transpose("C#", 4));
            Assert.AreEqual("F#", Harmonizer.Transpose("C#", 5));
            Assert.AreEqual("G", Harmonizer.Transpose("C#", 6));
            Assert.AreEqual("G#", Harmonizer.Transpose("C#", 7));
            Assert.AreEqual("A", Harmonizer.Transpose("C#", 8));
            Assert.AreEqual("A#", Harmonizer.Transpose("C#", 9));
            Assert.AreEqual("B", Harmonizer.Transpose("C#", 10));
            Assert.AreEqual("C", Harmonizer.Transpose("C#", 11));
        }

        [Test, Description("Should return the transposition of note C# by negative number of semi-tones.")]
        public void NegativeIntervalsOfCSharp()
        {
            Assert.AreEqual("C", Harmonizer.Transpose("C#", -1));
            Assert.AreEqual("B", Harmonizer.Transpose("C#", -2));
            Assert.AreEqual("A#", Harmonizer.Transpose("C#", -3));
            Assert.AreEqual("A", Harmonizer.Transpose("C#", -4));
            Assert.AreEqual("G#", Harmonizer.Transpose("C#", -5));
            Assert.AreEqual("G", Harmonizer.Transpose("C#", -6));
            Assert.AreEqual("F#", Harmonizer.Transpose("C#", -7));
            Assert.AreEqual("F", Harmonizer.Transpose("C#", -8));
            Assert.AreEqual("E", Harmonizer.Transpose("C#", -9));
            Assert.AreEqual("D#", Harmonizer.Transpose("C#", -10));
            Assert.AreEqual("D", Harmonizer.Transpose("C#", -11));
        }

        [Test, Description("Should return the transposition of note D by positive number of semi-tones.")]
        public void PositiveIntervalsOfD()
        {
            Assert.AreEqual("D#", Harmonizer.Transpose("D", 1));
            Assert.AreEqual("E", Harmonizer.Transpose("D", 2));
            Assert.AreEqual("F", Harmonizer.Transpose("D", 3));
            Assert.AreEqual("F#", Harmonizer.Transpose("D", 4));
            Assert.AreEqual("G", Harmonizer.Transpose("D", 5));
            Assert.AreEqual("G#", Harmonizer.Transpose("D", 6));
            Assert.AreEqual("A", Harmonizer.Transpose("D", 7));
            Assert.AreEqual("A#", Harmonizer.Transpose("D", 8));
            Assert.AreEqual("B", Harmonizer.Transpose("D", 9));
            Assert.AreEqual("C", Harmonizer.Transpose("D", 10));
            Assert.AreEqual("C#", Harmonizer.Transpose("D", 11));
        }

        [Test, Description("Should return the transposition of note D by negative number of semi-tones.")]
        public void NegativeIntervalsOfD()
        {
            Assert.AreEqual("C#", Harmonizer.Transpose("D", -1));
            Assert.AreEqual("C", Harmonizer.Transpose("D", -2));
            Assert.AreEqual("B", Harmonizer.Transpose("D", -3));
            Assert.AreEqual("A#", Harmonizer.Transpose("D", -4));
            Assert.AreEqual("A", Harmonizer.Transpose("D", -5));
            Assert.AreEqual("G#", Harmonizer.Transpose("D", -6));
            Assert.AreEqual("G", Harmonizer.Transpose("D", -7));
            Assert.AreEqual("F#", Harmonizer.Transpose("D", -8));
            Assert.AreEqual("F", Harmonizer.Transpose("D", -9));
            Assert.AreEqual("E", Harmonizer.Transpose("D", -10));
            Assert.AreEqual("D#", Harmonizer.Transpose("D", -11));
        }

        [Test, Description("Should return the transposition of note D# by positive number of semi-tones.")]
        public void PositiveIntervalsOfDSharp()
        {
            Assert.AreEqual("E", Harmonizer.Transpose("D#", 1));
            Assert.AreEqual("F", Harmonizer.Transpose("D#", 2));
            Assert.AreEqual("F#", Harmonizer.Transpose("D#", 3));
            Assert.AreEqual("G", Harmonizer.Transpose("D#", 4));
            Assert.AreEqual("G#", Harmonizer.Transpose("D#", 5));
            Assert.AreEqual("A", Harmonizer.Transpose("D#", 6));
            Assert.AreEqual("A#", Harmonizer.Transpose("D#", 7));
            Assert.AreEqual("B", Harmonizer.Transpose("D#", 8));
            Assert.AreEqual("C", Harmonizer.Transpose("D#", 9));
            Assert.AreEqual("C#", Harmonizer.Transpose("D#", 10));
            Assert.AreEqual("D", Harmonizer.Transpose("D#", 11));
        }

        [Test, Description("Should return the transposition of note D# by negative number of semi-tones.")]
        public void NegativeIntervalsOfDSharp()
        {
            Assert.AreEqual("D", Harmonizer.Transpose("D#", -1));
            Assert.AreEqual("C#", Harmonizer.Transpose("D#", -2));
            Assert.AreEqual("C", Harmonizer.Transpose("D#", -3));
            Assert.AreEqual("B", Harmonizer.Transpose("D#", -4));
            Assert.AreEqual("A#", Harmonizer.Transpose("D#", -5));
            Assert.AreEqual("A", Harmonizer.Transpose("D#", -6));
            Assert.AreEqual("G#", Harmonizer.Transpose("D#", -7));
            Assert.AreEqual("G", Harmonizer.Transpose("D#", -8));
            Assert.AreEqual("F#", Harmonizer.Transpose("D#", -9));
            Assert.AreEqual("F", Harmonizer.Transpose("D#", -10));
            Assert.AreEqual("E", Harmonizer.Transpose("D#", -11));
        }

        [Test, Description("Should return the transposition of note E by positive number of semi-tones.")]
        public void PositiveIntervalsOfE()
        {
            Assert.AreEqual("F", Harmonizer.Transpose("E", 1));
            Assert.AreEqual("F#", Harmonizer.Transpose("E", 2));
            Assert.AreEqual("G", Harmonizer.Transpose("E", 3));
            Assert.AreEqual("G#", Harmonizer.Transpose("E", 4));
            Assert.AreEqual("A", Harmonizer.Transpose("E", 5));
            Assert.AreEqual("A#", Harmonizer.Transpose("E", 6));
            Assert.AreEqual("B", Harmonizer.Transpose("E", 7));
            Assert.AreEqual("C", Harmonizer.Transpose("E", 8));
            Assert.AreEqual("C#", Harmonizer.Transpose("E", 9));
            Assert.AreEqual("D", Harmonizer.Transpose("E", 10));
            Assert.AreEqual("D#", Harmonizer.Transpose("E", 11));
        }

        [Test, Description("Should return the transposition of note E by negative number of semi-tones.")]
        public void NegativeIntervalsOfE()
        {
            Assert.AreEqual("D#", Harmonizer.Transpose("E", -1));
            Assert.AreEqual("D", Harmonizer.Transpose("E", -2));
            Assert.AreEqual("C#", Harmonizer.Transpose("E", -3));
            Assert.AreEqual("C", Harmonizer.Transpose("E", -4));
            Assert.AreEqual("B", Harmonizer.Transpose("E", -5));
            Assert.AreEqual("A#", Harmonizer.Transpose("E", -6));
            Assert.AreEqual("A", Harmonizer.Transpose("E", -7));
            Assert.AreEqual("G#", Harmonizer.Transpose("E", -8));
            Assert.AreEqual("G", Harmonizer.Transpose("E", -9));
            Assert.AreEqual("F#", Harmonizer.Transpose("E", -10));
            Assert.AreEqual("F", Harmonizer.Transpose("E", -11));
        }

        [Test, Description("Should return the transposition of note F by positive number of semi-tones.")]
        public void PositiveIntervalsOfF()
        {
            Assert.AreEqual("F#", Harmonizer.Transpose("F", 1));
            Assert.AreEqual("G", Harmonizer.Transpose("F", 2));
            Assert.AreEqual("G#", Harmonizer.Transpose("F", 3));
            Assert.AreEqual("A", Harmonizer.Transpose("F", 4));
            Assert.AreEqual("A#", Harmonizer.Transpose("F", 5));
            Assert.AreEqual("B", Harmonizer.Transpose("F", 6));
            Assert.AreEqual("C", Harmonizer.Transpose("F", 7));
            Assert.AreEqual("C#", Harmonizer.Transpose("F", 8));
            Assert.AreEqual("D", Harmonizer.Transpose("F", 9));
            Assert.AreEqual("D#", Harmonizer.Transpose("F", 10));
            Assert.AreEqual("E", Harmonizer.Transpose("F", 11));
        }

        [Test, Description("Should return the transposition of note F by negative number of semi-tones.")]
        public void NegativeIntervalsOfF()
        {
            Assert.AreEqual("E", Harmonizer.Transpose("F", -1));
            Assert.AreEqual("D#", Harmonizer.Transpose("F", -2));
            Assert.AreEqual("D", Harmonizer.Transpose("F", -3));
            Assert.AreEqual("C#", Harmonizer.Transpose("F", -4));
            Assert.AreEqual("C", Harmonizer.Transpose("F", -5));
            Assert.AreEqual("B", Harmonizer.Transpose("F", -6));
            Assert.AreEqual("A#", Harmonizer.Transpose("F", -7));
            Assert.AreEqual("A", Harmonizer.Transpose("F", -8));
            Assert.AreEqual("G#", Harmonizer.Transpose("F", -9));
            Assert.AreEqual("G", Harmonizer.Transpose("F", -10));
            Assert.AreEqual("F#", Harmonizer.Transpose("F", -11));
        }

        [Test, Description("Should return the transposition of note F# by positive number of semi-tones.")]
        public void PositiveIntervalsOfFSharp()
        {
            Assert.AreEqual("G", Harmonizer.Transpose("F#", 1));
            Assert.AreEqual("G#", Harmonizer.Transpose("F#", 2));
            Assert.AreEqual("A", Harmonizer.Transpose("F#", 3));
            Assert.AreEqual("A#", Harmonizer.Transpose("F#", 4));
            Assert.AreEqual("B", Harmonizer.Transpose("F#", 5));
            Assert.AreEqual("C", Harmonizer.Transpose("F#", 6));
            Assert.AreEqual("C#", Harmonizer.Transpose("F#", 7));
            Assert.AreEqual("D", Harmonizer.Transpose("F#", 8));
            Assert.AreEqual("D#", Harmonizer.Transpose("F#", 9));
            Assert.AreEqual("E", Harmonizer.Transpose("F#", 10));
            Assert.AreEqual("F", Harmonizer.Transpose("F#", 11));
        }

        [Test, Description("Should return the transposition of note F# by negative number of semi-tones.")]
        public void NegativeIntervalsOfFSharp()
        {
            Assert.AreEqual("F", Harmonizer.Transpose("F#", -1));
            Assert.AreEqual("E", Harmonizer.Transpose("F#", -2));
            Assert.AreEqual("D#", Harmonizer.Transpose("F#", -3));
            Assert.AreEqual("D", Harmonizer.Transpose("F#", -4));
            Assert.AreEqual("C#", Harmonizer.Transpose("F#", -5));
            Assert.AreEqual("C", Harmonizer.Transpose("F#", -6));
            Assert.AreEqual("B", Harmonizer.Transpose("F#", -7));
            Assert.AreEqual("A#", Harmonizer.Transpose("F#", -8));
            Assert.AreEqual("A", Harmonizer.Transpose("F#", -9));
            Assert.AreEqual("G#", Harmonizer.Transpose("F#", -10));
            Assert.AreEqual("G", Harmonizer.Transpose("F#", -11));
        }

        [Test, Description("Should return the transposition of note G by positive number of semi-tones.")]
        public void PositiveIntervalsOfG()
        {
            Assert.AreEqual("G#", Harmonizer.Transpose("G", 1));
            Assert.AreEqual("A", Harmonizer.Transpose("G", 2));
            Assert.AreEqual("A#", Harmonizer.Transpose("G", 3));
            Assert.AreEqual("B", Harmonizer.Transpose("G", 4));
            Assert.AreEqual("C", Harmonizer.Transpose("G", 5));
            Assert.AreEqual("C#", Harmonizer.Transpose("G", 6));
            Assert.AreEqual("D", Harmonizer.Transpose("G", 7));
            Assert.AreEqual("D#", Harmonizer.Transpose("G", 8));
            Assert.AreEqual("E", Harmonizer.Transpose("G", 9));
            Assert.AreEqual("F", Harmonizer.Transpose("G", 10));
            Assert.AreEqual("F#", Harmonizer.Transpose("G", 11));
        }

        [Test, Description("Should return the transposition of note G by negative number of semi-tones.")]
        public void NegativeIntervalsOfG()
        {
            Assert.AreEqual("F#", Harmonizer.Transpose("G", -1));
            Assert.AreEqual("F", Harmonizer.Transpose("G", -2));
            Assert.AreEqual("E", Harmonizer.Transpose("G", -3));
            Assert.AreEqual("D#", Harmonizer.Transpose("G", -4));
            Assert.AreEqual("D", Harmonizer.Transpose("G", -5));
            Assert.AreEqual("C#", Harmonizer.Transpose("G", -6));
            Assert.AreEqual("C", Harmonizer.Transpose("G", -7));
            Assert.AreEqual("B", Harmonizer.Transpose("G", -8));
            Assert.AreEqual("A#", Harmonizer.Transpose("G", -9));
            Assert.AreEqual("A", Harmonizer.Transpose("G", -10));
            Assert.AreEqual("G#", Harmonizer.Transpose("G", -11));
        }

        [Test, Description("Should return the transposition of note G# by positive number of semi-tones.")]
        public void PositiveIntervalsOfGSharp()
        {
            Assert.AreEqual("A", Harmonizer.Transpose("G#", 1));
            Assert.AreEqual("A#", Harmonizer.Transpose("G#", 2));
            Assert.AreEqual("B", Harmonizer.Transpose("G#", 3));
            Assert.AreEqual("C", Harmonizer.Transpose("G#", 4));
            Assert.AreEqual("C#", Harmonizer.Transpose("G#", 5));
            Assert.AreEqual("D", Harmonizer.Transpose("G#", 6));
            Assert.AreEqual("D#", Harmonizer.Transpose("G#", 7));
            Assert.AreEqual("E", Harmonizer.Transpose("G#", 8));
            Assert.AreEqual("F", Harmonizer.Transpose("G#", 9));
            Assert.AreEqual("F#", Harmonizer.Transpose("G#", 10));
            Assert.AreEqual("G", Harmonizer.Transpose("G#", 11));
        }

        [Test, Description("Should return the transposition of note G# by negative number of semi-tones.")]
        public void NegativeIntervalsOfGSharp()
        {
            Assert.AreEqual("G", Harmonizer.Transpose("G#", -1));
            Assert.AreEqual("F#", Harmonizer.Transpose("G#", -2));
            Assert.AreEqual("F", Harmonizer.Transpose("G#", -3));
            Assert.AreEqual("E", Harmonizer.Transpose("G#", -4));
            Assert.AreEqual("D#", Harmonizer.Transpose("G#", -5));
            Assert.AreEqual("D", Harmonizer.Transpose("G#", -6));
            Assert.AreEqual("C#", Harmonizer.Transpose("G#", -7));
            Assert.AreEqual("C", Harmonizer.Transpose("G#", -8));
            Assert.AreEqual("B", Harmonizer.Transpose("G#", -9));
            Assert.AreEqual("A#", Harmonizer.Transpose("G#", -10));
            Assert.AreEqual("A", Harmonizer.Transpose("G#", -11));
        }
    }
}
