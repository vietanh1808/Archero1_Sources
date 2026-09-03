using System;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class BetMakingChampPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtContentValue;

		[SerializeField]
		private DxxText txtContent2;

		[SerializeField]
		private DxxText txtCurOdd;

		[SerializeField]
		private DxxText txtCurBet;

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

		private int thisTimeMax;

		private int curValue;

		private Action onConfirm;

		private uint id;

		private void Awake()
		{
		}

		public void Open(uint id, Action onConfirm)
		{
		}

		private void Refresh()
		{
		}

		public void Close()
		{
		}
	}
}
