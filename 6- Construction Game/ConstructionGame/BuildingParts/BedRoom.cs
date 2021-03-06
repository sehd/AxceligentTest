﻿using System;

namespace ConstructionGame.BuildingParts
{
    class BedRoom : IBuildingPart
    {
        private readonly string name;

        public BedRoom(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string GetDescription()
        {
            return $"{name} room";
        }
    }
}
