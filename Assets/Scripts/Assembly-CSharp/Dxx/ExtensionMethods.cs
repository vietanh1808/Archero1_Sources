using UnityEngine;

namespace Dxx
{
	public static class ExtensionMethods
	{
		public static int ToInt(this float @this)
		{
			return 0;
		}

		public static float ToFloat(this int @this)
		{
			return 0f;
		}

		public static bool Contains(this LayerMask mask, int layer)
		{
			return false;
		}

		public static bool Contains(this LayerMask mask, GameObject gameobject)
		{
			return false;
		}
	}
}
