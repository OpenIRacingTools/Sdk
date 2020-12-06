﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIRacingTools.Sdk.Model
{
    public class RadioNg
    {
        public int RadioNum { get; private set; }
        public int HopCount { get; private set; }
        public int TunedToFrequencyNum { get; private set; }
        public bool ScanningIsOn { get; private set; }
        public List<RadioFrequency> Frequencies { get; private set; }
    }
}
