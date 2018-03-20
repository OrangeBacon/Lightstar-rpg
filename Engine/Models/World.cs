using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models {
    public class World {
        List<Location> _locations = new List<Location>();

        internal void AddLocation(int XCoordinate, int YCoordinate, string Name, string Description, string ImageName) {
            Location loc = new Location() {
                XCoordinate = XCoordinate,
                YCoordinate = YCoordinate,
                Name = Name,
                Description = Description,
                ImageName = ImageName
            };
            _locations.Add(loc);
        }

        public Location LocationAt(int XCoordinate, int YCoordinate) {
            foreach (var loc in _locations) {
                if(loc.XCoordinate == XCoordinate && loc.YCoordinate == YCoordinate) {
                    return loc;
                }
            }
            return null;
        }
    }
}
