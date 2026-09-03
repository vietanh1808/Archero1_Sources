using UnityEngine;
using UnityEngine.EventSystems;

namespace SoftMasking.Samples
{
	[RequireComponent(typeof(RectTransform))]
	public class PaintedMask : UIBehaviour
	{
		public Camera renderCamera;

		public SoftMask targetMask;

		private RenderTexture _renderTexture;

		private Vector2 maskSize => default;

		protected override void Start()
		{
		}
	}
}
