using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace Dxx
{
	[CreateAssetMenu]
	public class DxxSpriteAtlas : ScriptableObject
	{
		public enum ReleaseType
		{
			Timer = 0,
			Never = 1
		}

		public ReleaseType m_emReleaseType;

		public string tag;

		private Sprite[] sprites;

		private Dictionary<string, int> nameToIndex;

		public SpriteAtlas atlas;

		public bool CanRelease => false;

		public Sprite GetSprite(string spriteName)
		{
			return null;
		}

		public void Release()
		{
		}
	}
}
