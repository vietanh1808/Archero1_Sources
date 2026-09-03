using UnityEngine;
using XLua;

namespace Activity.Bingo
{
	public class BingoTicketBuyPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtBtnPrice;

		[SerializeField]
		private DxxText txtCount;

		[SerializeField]
		private DxxText txtQuota;

		[SerializeField]
		private DxxText NumTex;

		private int CurNum;

		private int MaxNum;

		private int MinNum;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		[SerializeField]
		private ButtonCtrl btnAdd;

		[SerializeField]
		private ButtonCtrl btnSubtract;

		[SerializeField]
		private ButtonCtrl btnMin;

		[SerializeField]
		private ButtonCtrl btnMax;

		[SerializeField]
		private ButtonCtrl btnBuy;

		private static DelegateBridge __Hotfix0_get_LeftQuota;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnValueChanged;

		private static DelegateBridge __Hotfix0_OnBtnBuyClick;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge _c__Hotfix0_ctor;

		private int LeftQuota => 0;

		private void Awake()
		{
		}

		private void OnValueChanged()
		{
		}

		private void OnBtnBuyClick()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
