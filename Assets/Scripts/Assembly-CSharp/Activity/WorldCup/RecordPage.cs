using System;
using UnityEngine;

namespace Activity.WorldCup
{
	public class RecordPage : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtBtnClaimAll;

		[SerializeField]
		private WorldCupRewardInfinity infinity;

		[SerializeField]
		private ButtonCtrl btnClaimAll;

		[SerializeField]
		private ButtonCtrl btnClose;

		private int umatchCount;

		private int matchCount;

		private int champCount;

		private int uchampCount;

		private Action onClose;

		private void Awake()
		{
		}

		public void Open(Action onClose)
		{
		}

		public void Refresh(bool init = false)
		{
		}

		public void Close()
		{
		}
	}
}
