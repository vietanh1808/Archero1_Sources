using UnityEngine;
using UnityEngine.UI;

namespace Dxx.UI
{
	[AddComponentMenu("UI/Effects/Gradient Angle Dxx")]
	public class GradientAngle : BaseMeshEffect
	{
		[SerializeField]
		private Color32 startColor;

		[SerializeField]
		private Color32 endColor;

		[SerializeField]
		[Range(0f, 360f)]
		[Tooltip("渐变旋转角度")]
		private float angle;

		[SerializeField]
		[Tooltip("渐变偏移")]
		private float offset;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected Vector2 GetProjectivePoint(Vector2 pLine, float k, Vector2 pOut)
		{
			return default;
		}
	}
}
