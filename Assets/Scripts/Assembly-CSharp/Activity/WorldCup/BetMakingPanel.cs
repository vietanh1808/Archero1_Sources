using System;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class BetMakingPanel : PanelBase
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTip1;

		[SerializeField]
		private DxxText txtTipValue;

		[SerializeField]
		private DxxText txtTip2;

		[SerializeField]
		private DxxText txtWinTip;

		[SerializeField]
		private DxxText txtWinTipValue;

		[SerializeField]
		private DxxText txtLoseTip;

		[SerializeField]
		private DxxText txtLoseTipValue;

		[SerializeField]
		private DxxText txtValue;

		[SerializeField]
		private DxxText txtMaxBet;

		[SerializeField]
		private DxxText txtBtnConfirm;

		[SerializeField]
		private ButtonCtrl btnConfirm;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnAdd;

		[SerializeField]
		private ButtonCtrl btnReduce;

		[SerializeField]
		private Slider slider;

		private int myMax;

		private int allowedMax;

		private int curValue;

		private Action onConfirm;

		private WorldCupMatch match;

		private int result;

		private int lastBetValue;

		private void Awake()
		{
		}

		public void Open(WorldCupMatch match, int result, Action onConfirm)
		{
		}

		private new void Refresh()
		{
		}

		public new void Close()
		{
		}
	}
}
