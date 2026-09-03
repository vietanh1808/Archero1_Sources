using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dxx.UI
{
	[AddComponentMenu("UI/Effects/TextColor3Dxx")]
	[RequireComponent(typeof(Text))]
	public class TextColor3Dxx : Shadow
	{
		private const float DOWNWIDTH = 6f;

		private Text m_Text;

		public Color topColor;

		public Color bottomColor;

		[SerializeField]
		private List<Vector2> shadowPosList;

		[SerializeField]
		public List<Color32> colorList;

		public Color32 middleoutline;

		[SerializeField]
		private Vector2 middleoutlineoffset;

		public Text text => null;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private byte GetAlpha(Color c, List<UIVertex> verts)
		{
			return 0;
		}

		private void ApplyShadowZeroAllocSelf(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}
	}
}
