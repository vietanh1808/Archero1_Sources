using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class BPItem : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnNormal;

		[SerializeField]
		private ButtonCtrl btnPremium;

		[SerializeField]
		private ButtonCtrl btnBuy;

		[SerializeField]
		private DxxText txtActive;

		[SerializeField]
		private DxxText txtCheckIn;

		[SerializeField]
		private DxxText txtBtnBuy;

		[SerializeField]
		private GameObject goCheckIn;

		[SerializeField]
		private GameObject goCheckInBuy;

		[SerializeField]
		private GameObject goActive;

		[SerializeField]
		private GameObject goLineUp;

		[SerializeField]
		private GameObject goLineDown;

		[SerializeField]
		private GameObject goUnlockBg;

		[SerializeField]
		private RectTransform rtLeft;

		[SerializeField]
		private RectTransform rtRight;

		[SerializeField]
		private DxxImage imgBtnNormal;

		[SerializeField]
		private DxxImage imgBtnPremium;

		[SerializeField]
		private DxxImage imgBgNormal;

		[SerializeField]
		private DxxImage imgBgPremium;

		[SerializeField]
		private DxxImage imgSplitUp;

		[SerializeField]
		private DxxImage imgSplitDown;

		private List<PropOneEquip> list;

		private BPItemStruct rewardData;

		private ushort type;

		private LocalUnityObjctPool pool;

		private int index;

		private BPPanelStyle style;

		private List<DxxImage> locks;

		private List<Transform> cangets;

		private List<Image> gots;

		private static DelegateBridge __Hotfix0_GetSource;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_BtnNormalOnClick;

		private static DelegateBridge __Hotfix0_BtnPremiumOnClick;

		private static DelegateBridge __Hotfix0_BtnBuyClick;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_RefreshActiveBuy;

		private static DelegateBridge __Hotfix0_RefreshCheckInBuy;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_SetLock;

		private static DelegateBridge __Hotfix0_SetCanGet;

		private static DelegateBridge __Hotfix0_SetGot;

		private static DelegateBridge _c__Hotfix0_ctor;

		private string GetSource(bool isPremium)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void BtnNormalOnClick()
		{
		}

		private void BtnPremiumOnClick()
		{
		}

		private void BtnBuyClick()
		{
		}

		internal void SetData(int index, ushort type, LocalUnityObjctPool pool, BPPanelStyle curStyle)
		{
		}

		private void RefreshActiveBuy()
		{
		}

		private void RefreshCheckInBuy()
		{
		}

		private void SetStyle()
		{
		}

		private void SetLock(bool isLock, bool isPremium)
		{
		}

		private void SetCanGet(bool canGet, bool isPremium)
		{
		}

		private void SetGot(bool isGot, bool isPremium)
		{
		}
	}
}
