using UIKit;
using UnityEngine;
using UnityEngine.UI;

namespace Activity7thAnniversary
{
	public class RankRewardDetailItem : UITableViewCell
	{
		[SerializeField]
		private DxxText ranking;

		[SerializeField]
		private Image rewardBg;

		[SerializeField]
		private Transform rewardParent;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject decorateObj;

		[SerializeField]
		private Image decorate1;

		[SerializeField]
		private Image decorate2;

		private StageRankItemData data;

		private StageRankItemData previousData;

		private int curArea;

		private LocalUnityObjctPool pool;

		private bool isInit;

		private RectTransform _scrollViewRect;

		private void Init()
		{
		}

		private void InitObjectPool()
		{
		}

		public void Refresh(StageRankItemData data, StageRankItemData previousData, RectTransform scrollRect)
		{
		}

		private void RefreshText()
		{
		}

		private void RefreshItem()
		{
		}

		private void RefreshStatus()
		{
		}
	}
}
