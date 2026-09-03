using UnityEngine;
using UnityEngine.UI;

namespace Dxx.UI
{
	[AddComponentMenu("UI/Effects/TextColorDxx")]
	[RequireComponent(typeof(Text))]
	public class TextColorDxx : BaseMeshEffect
	{
		public Color32 topColor;

		public Color32 bottomColor;

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
