using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

namespace Activity.Bingo
{
	public class BingoTaskPanel : MonoBehaviour
	{
		[SerializeField]
		private BingoScoreBar bingoScoreBar;

		[SerializeField]
		private ButtonCtrl closeBtn;

		[SerializeField]
		private DxxText titleTex;

		[SerializeField]
		private BingoTaskItem itemObj;

		[SerializeField]
		private Transform itemParent;

		[SerializeField]
		private ButtonCtrl bgBtn;

		private List<BingoTaskItem> items;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void OnHandleNotification(INotification notification)
		{
		}

		public void RefreshList()
		{
		}

		public void Close()
		{
		}
	}
}
