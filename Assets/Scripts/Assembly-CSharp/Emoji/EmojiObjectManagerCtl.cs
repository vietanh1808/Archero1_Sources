using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

namespace Emoji
{
	public class EmojiObjectManagerCtl : MediatorCtrlBase
	{
		public GameObject window;

		public Transform emojiParent;

		private Dictionary<int, EmojiCtlTable> emojiMap;

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		private void android_escape()
		{
		}

		protected override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void PlayEmoji(EmojiObject pObj)
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}
	}
}
