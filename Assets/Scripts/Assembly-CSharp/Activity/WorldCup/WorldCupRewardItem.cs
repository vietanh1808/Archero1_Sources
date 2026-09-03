using System.Collections.Generic;
using UnityEngine;

namespace Activity.WorldCup
{
	public class WorldCupRewardItem : MonoBehaviour
	{
		public enum Type
		{
			ChampClaimed = 0,
			ChampUnclaimed = 1,
			MatchClaimed = 2,
			MatchUnclaimed = 3
		}

		[SerializeField]
		private DxxText txtMatchTitleStage;

		[SerializeField]
		private DxxText txtMatchTitleTeam;

		[SerializeField]
		private DxxText txtMatchResult;

		[SerializeField]
		private DxxText txtMatchTie;

		[SerializeField]
		private DxxText txtChamp;

		[SerializeField]
		private DxxText txtExile;

		[SerializeField]
		private DxxText txtSupport;

		[SerializeField]
		private DxxText txtMySupportTeam;

		[SerializeField]
		private DxxText txtMyBet;

		[SerializeField]
		private DxxText txtReturn;

		[SerializeField]
		private DxxText txtMyBetCount;

		[SerializeField]
		private DxxText txtReturnCount;

		[SerializeField]
		private DxxText txtBtnClaim;

		[SerializeField]
		private DxxText txtClaimed;

		[SerializeField]
		private DxxText txtReturnCountIcon;

		[SerializeField]
		private GameObject goMatchTitle;

		[SerializeField]
		private GameObject goMatchResult;

		[SerializeField]
		private GameObject goMatchTie;

		[SerializeField]
		private GameObject goChampRoot;

		[SerializeField]
		private GameObject goMatchRoot;

		[SerializeField]
		private DxxImage imgIcon;

		[SerializeField]
		private DxxImage imgIcon2;

		[SerializeField]
		private DxxImage imgIcon3;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private Sprite spBall;

		[SerializeField]
		private Sprite spCup;

		private KeyValuePair<uint, BetData>? matchData;

		private ChampBetRecordData champData;

		private RecordPage page;

		private void Awake()
		{
		}

		private void Callback(bool b)
		{
		}

		public void Set(RecordPage recordPage, int index, Type type)
		{
		}

		private void SetChamp(int index, bool claimed)
		{
		}

		private void SetMatch(int index, bool claimed)
		{
		}
	}
}
