
using Landis.SpatialModeling;

namespace Landis.Extension.Output.LocalHabitat
{
    public class BytePixel : Pixel
    {
        public Band<byte> MapCode  = "The numeric code for each ecoregion";

        public BytePixel() 
        {
            SetBands(MapCode);
        }
    }
}
