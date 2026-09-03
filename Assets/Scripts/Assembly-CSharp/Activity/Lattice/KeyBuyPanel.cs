using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class KeyBuyPanel : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnGift;

		[SerializeField]
		private ButtonCtrl btnTask;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtBtnGift;

		[SerializeField]
		private DxxText txtBtnTask;

		[SerializeField]
		private DxxText txtContentGift;

		[SerializeField]
		private DxxText txtContentTask;

		[SerializeField]
		private DxxText txtCountdownGift;

		[SerializeField]
		private DxxText txtCountdownTask;

		private float timer;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_BtnGiftOnClick;

		private static DelegateBridge __Hotfix0_BtnTaskOnClick;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_RefreshCountdown;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void BtnGiftOnClick()
		{
		}

		private void BtnTaskOnClick()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Update()
		{
		}

		private void RefreshCountdown()
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
