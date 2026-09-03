using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class RedeemWorldCupItem : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnRedeem;

		[SerializeField]
		private DxxText txtItemCount;

		[SerializeField]
		private DxxText txtLeftCount;

		[SerializeField]
		private PropOneEquip propReward;

		[SerializeField]
		private DxxImage imgIcon;

		[SerializeField]
		private Image Image_BG;

		private uint id;

		private CWorldCupExchangeData data;

		private RedeemWorldCupPanel panel;

		private void Awake()
		{
		}

		public void OnClick()
		{
		}

		public void SetData(RedeemWorldCupPanel redeemWorldCupPanel, int index)
		{
		}

		private void Refresh()
		{
		}

		private void SetGray(bool isSet)
		{
		}
	}
}
