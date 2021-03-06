﻿using System;

namespace OpenIRacingTools.Sdk.Model.Types
{
    public struct Measure
    {
        public Measure(double value, string unit = "m")
        {
            switch (unit)
            {
                case "m":
                    Meters = value;
                    break;

                case "km":
                    Meters = value * 1000;
                    break;

                default:
                    throw new NotSupportedException($"Unit {unit} is not supported.");
            }
        }

        public double Meters { get; private set; }

        private object ToDump()
        {
            return $"{Meters} m ({GetType().Name})";
        }
    }
}
