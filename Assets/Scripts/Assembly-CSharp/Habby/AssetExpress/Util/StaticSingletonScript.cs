using UnityEngine;

namespace Habby.AssetExpress.Util
{
	public abstract class StaticSingletonScript<T> : MonoBehaviour where T : StaticSingletonScript<T>
	{
		protected static T instance;

		public static T Instance => null;

		public virtual void Awake()
		{
		}

		public virtual void OnDestroy()
		{
		}
	}
}
