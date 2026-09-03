using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class PrizeWheelTaskPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private DxxImage imgBtnCollapse;

		[SerializeField]
		private DxxImage imgShadow;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private ButtonCtrl btnBG;

		[SerializeField]
		private GameObject template;

		[SerializeField]
		private RectTransform contentRoot;

		[SerializeField]
		private RectTransform rtPanel;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private Canvas canvas;

		private PrizeWheelPanelStyle style;

		private bool isOpen;

		private LocalUnityObjctPool pool;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void SetStyle(PrizeWheelPanelStyle style)
		{
		}

		public void Open(bool withTween = true)
		{
		}

		public void Close(bool withTween = true)
		{
		}

		public void Refresh()
		{
		}
	}
}
