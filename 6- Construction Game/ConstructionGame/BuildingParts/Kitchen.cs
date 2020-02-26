using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionGame.BuildingParts
{
    class Kitchen : IBuildingPart
    {
        public string GetDescription()
        {
            return "kitchen";
        }
    }
}
