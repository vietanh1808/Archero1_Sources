using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class TDRewardPop : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private ButtonCtrl btnClose;

		private static readonly Vector2 vector2;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void Open(int index, Transform anchor)
		{
		}

		public void Close()
		{
		}
	}
}
