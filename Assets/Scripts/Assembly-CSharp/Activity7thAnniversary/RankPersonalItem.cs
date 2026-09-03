using System;
using UnityEngine;

namespace Activity7thAnniversary
{
	public class RankPersonalItem : SailingRankPersonalItem
	{
		[SerializeField]
		private ButtonCtrl _btnInfo;

		[SerializeField]
		private ButtonCtrl _btnInfo2;

		private Action<RankingItemData, Vector3> OnClickInfo2Btn;

		public void Refresh(SailingRankingItemData data, RankType type, Action<RankingItemData, Vector3> onClick, RectTransform scrollRect = null)
		{
		}

		protected override void OnRefreshStatus()
		{
		}

		protected override void ClickUserInfo()
		{
		}

		protected override void LoadPowerImg(RankType type)
		{
		}

		protected override void UpdateRankBg()
		{
		}
	}
}
