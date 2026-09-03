using System.Collections.Generic;
using UnityEngine;

namespace Dxx
{
	[CreateAssetMenu]
	public class DxxAnimationAsset : ScriptableObject
	{
		public enum AniType
		{
			Model = 0,
			Wing = 1
		}

		private class AniAssetBundle
		{
			public AssetBundle ab;

			private string _tempPath;

			private string tempTag;

			public AniAssetBundle(string path)
			{
			}

			public void Release()
			{
			}

			public AnimationClip GetClip(string name)
			{
				return null;
			}
		}

		private static Dictionary<string, AniAssetBundle> m_dicAbs;

		public string Tag;

		public string MappingPath;

		public AniType m_emType;

		public List<AnimationClip> m_listAnimationClips;

		private Dictionary<string, AnimationClip> m_dicAnimationClips;

		public static AssetBundle GetAniAssetBundle(string bundlePath)
		{
			return null;
		}

		private void Init()
		{
		}

		public AnimationClip GetClip(string name)
		{
			return null;
		}

		public AnimationClip GetClip(string name, string subPath)
		{
			return null;
		}

		public List<AnimationClip> GetClips()
		{
			return null;
		}

		public void Release()
		{
		}
	}
}
