using UnityEngine;
using XLua;

namespace Activity.Bingo
{
	public class BingoLineRewardItem : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject goTick;

		[SerializeField]
		private GameObject goTip;

		[SerializeField]
		private DxxText txtGet;

		[SerializeField]
		private GameObject effectObj;

		private int index;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Start;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_ShowEffect;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnClick()
		{
		}

		public void SetData(int index)
		{
		}

		public void ShowEffect()
		{
		}

		public void Refresh()
		{
		}
	}
}
