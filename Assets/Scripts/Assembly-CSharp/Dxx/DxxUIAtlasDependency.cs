using UnityEngine;

namespace Dxx
{
	public class DxxUIAtlasDependency : ScriptableObject
	{
		public UIAtlasDependency[] uiAtlasDependencies;

		public DxxUIAtlasDependency(UIAtlasDependency[] uiAtlasDependencies)
		{
		}

		public string[] GetDependencyAtlasNames(string key)
		{
			return null;
		}
	}
}
