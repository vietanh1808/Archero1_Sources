using System;
using UnityEngine;

namespace Activity7thAnniversary
{
	public class RankCharItem : SailRankCharItem
	{
		[SerializeField]
		private ButtonCtrl _btnInfo;

		private Action<RankingItemData, Vector3> OnClickInfoBtn;

		public void Init(SailingRankingItemData data, RankType type, Action<RankingItemData, Vector3> onClick)
		{
		}

		protected override void OnClickPlayerMainBtn()
		{
		}
	}
}
