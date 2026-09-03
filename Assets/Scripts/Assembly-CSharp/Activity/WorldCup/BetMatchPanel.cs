using UnityEngine;

namespace Activity.WorldCup
{
	public class BetMatchPanel : PanelBase
	{
		[SerializeField]
		private Tab _tab;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtSubTitle;

		[SerializeField]
		private DxxText txtCountdown;

		[SerializeField]
		private DxxText txtBtnRecord;

		[SerializeField]
		private DxxText txtBtnSwitch;

		[SerializeField]
		private MatchPage matchPage;

		[SerializeField]
		private ChampionPage championPage;

		[SerializeField]
		private RecordPage recordPage;

		[SerializeField]
		private ButtonCtrl btnRecord;

		[SerializeField]
		private ButtonCtrl btnSwitch;

		[SerializeField]
		private ButtonCtrl btnTip;

		[SerializeField]
		private DxxImage imgBtnSwitch;

		[SerializeField]
		private Sprite spriteChampion;

		[SerializeField]
		private Sprite spriteMatch;

		[SerializeField]
		private RedNodeCtrl redNodeReward;

		[SerializeField]
		private RedNodeCtrl redNodeChampBet;

		private bool isShowingChamp;

		private long endTime;

		private float timeCount;

		private void Awake()
		{
		}

		private void RefreshCountdown()
		{
		}

		public override void Open()
		{
		}

		private void RefreshRedNode()
		{
		}

		public void RefreshUI()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void Update()
		{
		}
	}
}
