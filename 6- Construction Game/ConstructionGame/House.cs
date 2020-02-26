using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructionGame
{
    class House
    {
        private readonly IEnumerable<IBuildingPart> buildingParts;

        public House(IEnumerable<IBuildingPart> buildingParts)
        {
            this.buildingParts = buildingParts ?? throw new ArgumentNullException(nameof(buildingParts));
        }

        public string Describe()
        {
            return string.Join(", ",
                buildingParts.Select(b => b.GetDescription()));
        }
    }
}
