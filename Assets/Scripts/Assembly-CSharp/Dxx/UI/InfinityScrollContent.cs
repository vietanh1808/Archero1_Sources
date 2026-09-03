using UnityEngine;
using UnityEngine.EventSystems;

namespace Dxx.UI
{
	public class InfinityScrollContent : UIBehaviour
	{
		public InfinityScrollGroup mGroup;

		protected DrivenRectTransformTracker m_Tracker;

		private RectTransform m_rectTransform;

		public RectTransform rectTransform => null;

		protected override void Awake()
		{
		}

		public void FitContent(Vector2 size)
		{
		}
	}
}
