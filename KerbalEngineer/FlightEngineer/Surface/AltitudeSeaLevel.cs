﻿// Name:    Kerbal Engineer Redux
// Author:  CYBUTEK
// License: Attribution-NonCommercial-ShareAlike 3.0 Unported

using KerbalEngineer.Extensions;
using KerbalEngineer.Simulation;
using UnityEngine;

namespace KerbalEngineer.FlightEngineer.Surface
{
    public class AltitudeSeaLevel : Readout
    {
        protected override void Initialise()
        {
            Name = "Altitude (Sea Level)";
            Description = "Shows your altitude relative to sea level.";
            Category = ReadoutCategory.Surface;
        }

        public override void Draw()
        {
            DrawLine(FlightGlobals.ActiveVessel.altitude.ToDistance());
        }
    }
}
