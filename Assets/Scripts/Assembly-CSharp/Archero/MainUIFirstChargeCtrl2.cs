using UnityEngine;

namespace Archero
{
	public class MainUIFirstChargeCtrl2 : MainUIButtonBase
	{
		public ButtonCtrl mButton;

		public RedNodeCtrl mRedCtrl;

		public GameObject child;

		public DxxText txt_Name;

		[SerializeField]
		private DxxText mTextName;

		private void Awake()
		{
		}

		private void show(bool value)
		{
		}

		public void Open()
		{
		}

		public new void UpdateUI()
		{
		}

		private void UpdateRed()
		{
		}

		public override long GetOpenTime()
		{
			return 0L;
		}

		public override int GetPriority()
		{
			return 0;
		}

		public override RectTransform GetTransform()
		{
			return null;
		}

		public override bool IsShow()
		{
			return false;
		}

		public void onButtonIcon()
		{
		}

		public override void OnLanguageChange()
		{
		}
	}
}
