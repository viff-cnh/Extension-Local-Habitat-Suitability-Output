
using Landis.SpatialModeling;

namespace Landis.Extension.Output.LocalHabitat
{
    public class IntPixel : Pixel
    {
        public Band<int> MapCode  = "The numeric code for each map value";

        public IntPixel() 
        {
            SetBands(MapCode);
        }
    }
}
