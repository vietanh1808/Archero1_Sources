using GameProtocol;
using UnityEngine;
using XLua;

namespace Activity
{
	public class RedeemItem : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnRedeem;

		[SerializeField]
		private DxxText txtRedeem;

		[SerializeField]
		private DxxText txtLeftTimes;

		[SerializeField]
		private DxxText txtEmpty;

		[SerializeField]
		private DxxText txtItem;

		[SerializeField]
		private DxxText txtItem2;

		[SerializeField]
		private DxxText txtDiamond;

		[SerializeField]
		private DxxText discountTex;

		[SerializeField]
		private DxxImage imgIcon1;

		[SerializeField]
		private DxxImage imgIcon2;

		[SerializeField]
		private DxxImage imgEqual;

		[SerializeField]
		private DxxImage imgPanelBg;

		[SerializeField]
		private DxxImage imgTargetBg;

		[SerializeField]
		private GameObject goItem;

		[SerializeField]
		private GameObject goItem2;

		[SerializeField]
		private GameObject goDiamond;

		[SerializeField]
		private GameObject plus1;

		[SerializeField]
		private GameObject plus2;

		[SerializeField]
		private GameObject discountObj;

		[SerializeField]
		private GameObjectActivator activator;

		[SerializeField]
		private PropOneEquip propReward;

		[SerializeField]
		private uint id;

		private CActivityExchangeData data;

		private RedeemPanelStyle style;

		[SerializeField]
		private ButtonCtrl item1_Btn;

		[SerializeField]
		private ButtonCtrl item2_Btn;

		private CRewardItem item1Data;

		private CRewardItem item2Data;

		private static DelegateBridge __Hotfix0_get_sourceName;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClickItem;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_SetStatus;

		private static DelegateBridge _c__Hotfix0_ctor;

		private string sourceName => null;

		private void Awake()
		{
		}

		private void OnClickItem(CRewardItem item)
		{
		}

		public void SetData(int index, RedeemPanelStyle style)
		{
		}

		private void SetStyle()
		{
		}

		private void SetStatus(ActivityMgr.Status status)
		{
		}
	}
}
