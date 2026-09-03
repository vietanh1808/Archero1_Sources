using UnityEngine;

namespace Activity7thAnniversary
{
	public class BuyTimesCtrl : MonoBehaviour
	{
		[SerializeField]
		private DxxText _textTitle;

		[SerializeField]
		private DxxText _textTips;

		[SerializeField]
		private DxxText _textRemainTimes;

		[SerializeField]
		private DxxText _textPrice;

		[SerializeField]
		private ButtonCtrl _btnClose;

		[SerializeField]
		private ButtonCtrl _btnBuy;

		private Activity7thAnniversaryMgr _mgr;

		public void Init()
		{
		}

		public void Open()
		{
		}

		public void OnLanguageChanged()
		{
		}
	}
}
