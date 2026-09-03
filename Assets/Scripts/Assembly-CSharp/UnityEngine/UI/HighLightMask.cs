namespace UnityEngine.UI
{
	public class HighLightMask : MaskableGraphic, ICanvasRaycastFilter
	{
		[SerializeField]
		private RectTransform _target;

		private Vector3 _targetMin;

		private Vector3 _targetMax;

		private bool _canRefresh;

		private Transform _cacheTrans;

		public void SetTarget(RectTransform target)
		{
		}

		private void _SetTarget(Vector3 tarMin, Vector3 tarMax)
		{
		}

		private void _RefreshView()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		bool ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 screenPos, Camera eventCamera)
		{
			return false;
		}

		protected override void Awake()
		{
		}
	}
}
