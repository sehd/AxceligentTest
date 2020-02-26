using System;
using System.Collections.Generic;

namespace ConstructionGame
{
    internal class Building
    {
        private readonly List<IBuildingPart> buildingParts;
        public Building()
        {
            buildingParts = new List<IBuildingPart>();
        }

        internal Building AddBalcony()
        {
            buildingParts.Add(new Balcony());
            return this;
        }

        internal Building AddBedroom(string name)
        {
            buildingParts.Add(new BedRoom(name));
            return this;
        }

        internal Building AddKitchen()
        {
            buildingParts.Add(new Kitchen());
            return this;
        }

        internal House Build()
        {
            return new House(buildingParts);
        }
    }
}