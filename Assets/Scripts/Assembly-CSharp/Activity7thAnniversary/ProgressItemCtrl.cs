using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

namespace Activity7thAnniversary
{
	public class ProgressItemCtrl : MonoBehaviour
	{
		[SerializeField]
		private Image _imgProgress;

		[SerializeField]
		private Image _imgLockedBg;

		[SerializeField]
		private Image _imgUnlockedBg;

		[SerializeField]
		private Image _imgSelectedBg;

		[SerializeField]
		private Image _imgFirstUnlock;

		[SerializeField]
		private Image _imgBattle;

		[SerializeField]
		private DxxText _textStage;

		private Daily_StageInfo_130 _data;

		private Action<Daily_StageInfo_130> _onClick;

		private Activity7thAnniversaryMgr _mgr;

		public ProgressItemCtrl Init(Daily_StageInfo_130 data, Action<Daily_StageInfo_130> onClick, bool isLast)
		{
			return null;
		}

		public void OnClick()
		{
		}
	}
}
