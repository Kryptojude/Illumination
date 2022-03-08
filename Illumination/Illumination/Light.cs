using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Illumination
{
    class Light
    {
        Point Location;
        Point Direction_Unit_Vector;

        public Light(Point start_location, Point start_direction_unit_vector)
        {
            Location = start_location;
            Direction_Unit_Vector = start_direction_unit_vector;
        }

        private Point DistanceToVector(int distance)
        {

        }

        public void Advance(int distance)
        {
            // Turn distance into (x,y)
            Point add_vector = DistanceToVector(distance);
            // Add vector onto Location
            Point new_location = new Point();
            Location.X += add_vector.X;
            Location.Y += add_vector.Y;
        }
    }
}
