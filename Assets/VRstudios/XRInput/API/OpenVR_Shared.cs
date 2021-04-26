using System.Text;

namespace VRstudios
{
	public static class OpenVR_Shared
    {
        // NOTE: capacity must match 'propertyText' for equals to work (in this case 256)
        public static StringBuilder propertyText = new StringBuilder(256);
        public static StringBuilder propertyText_ViveController = new StringBuilder("vive_controller", 256);
        public static StringBuilder propertyText_IndexController = new StringBuilder("knuckles", 256);
    }
}