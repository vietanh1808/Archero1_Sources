using UnityEngine;

namespace Activity.WorldCup
{
	public class BetMatchItem : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTeamLeft;

		[SerializeField]
		private DxxText txtTeamRight;

		[SerializeField]
		private DxxText txtScore;

		[SerializeField]
		private DxxText txtResultWait;

		[SerializeField]
		private DxxText txtBtnLeft;

		[SerializeField]
		private DxxText txtBtnTie;

		[SerializeField]
		private DxxText txtBtnRight;

		[SerializeField]
		private DxxText txtTokenBet;

		[SerializeField]
		private DxxText txtRate;

		[SerializeField]
		private DxxText txtWinPop;

		[SerializeField]
		private DxxText txtLosePop;

		[SerializeField]
		private DxxText txtWinCountPop;

		[SerializeField]
		private DxxText txtLoseCountPop;

		[SerializeField]
		private DxxText txtBetStatus;

		[SerializeField]
		private DxxText txtStatus;

		[SerializeField]
		private DxxImage imgBtnLeft;

		[SerializeField]
		private DxxImage imgBtnRight;

		[SerializeField]
		private DxxImage imgBtnTie;

		[SerializeField]
		private DxxImage imgLeftVoted;

		[SerializeField]
		private DxxImage imgRightVoted;

		[SerializeField]
		private Sprite btnBgNormal;

		[SerializeField]
		private Sprite btnBgSelected;

		[SerializeField]
		private ButtonCtrl btnLeft;

		[SerializeField]
		private ButtonCtrl btnRight;

		[SerializeField]
		private ButtonCtrl btnTie;

		[SerializeField]
		private ButtonCtrl btnPop;

		[SerializeField]
		private PointerDownHandler pointerDownHandler;

		[SerializeField]
		private GameObject goVS;

		[SerializeField]
		private GameObject goTie;

		[SerializeField]
		private GameObject goLeftWin;

		[SerializeField]
		private GameObject goRightWin;

		[SerializeField]
		private GameObject goPop;

		private WorldCupMatch data;

		private BetMakingPanel panel;

		private int selectedResult;

		private int CurrentBetTotal;

		private bool isTeamCertain => false;

		private bool started => false;

		private void Awake()
		{
		}

		private bool CheckMax()
		{
			return false;
		}

		public void SetData(BetMakingPanel panel, WorldCupMatch data)
		{
		}

		private void Refresh()
		{
		}

		private void RefreshTexts()
		{
		}

		private void SetInGame()
		{
		}

		private void SetFinished()
		{
		}

		private void SetNotStart()
		{
		}

		private void RefreshButtons()
		{
		}
	}
}
