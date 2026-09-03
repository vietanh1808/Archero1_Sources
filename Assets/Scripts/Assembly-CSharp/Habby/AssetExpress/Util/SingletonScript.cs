using UnityEngine;

namespace Habby.AssetExpress.Util
{
	public abstract class SingletonScript<T> : MonoBehaviour where T : SingletonScript<T>
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
