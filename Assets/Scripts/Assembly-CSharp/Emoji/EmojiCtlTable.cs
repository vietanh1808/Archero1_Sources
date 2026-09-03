using System;
using System.Collections.Generic;
using UnityEngine;

namespace Emoji
{
	public class EmojiCtlTable
	{
		private Queue<EmojiObjectUICtl> que;

		private Transform parent;

		private EmojiObject emojiInfo;

		public EmojiCtlTable(EmojiObject pObj, Transform pParent)
		{
		}

		public void PlayOne(EntityBase pOwner, Action<EmojiObjectUICtl> pOnComplete = null)
		{
		}

		public void PlayOneWithArrow(int trangle, EntityBase pOwner, Action<EmojiObjectUICtl> pOnComplete = null)
		{
		}

		private EmojiObjectUICtl GetEmoji()
		{
			return null;
		}

		private EmojiObjectUICtl CreatEmoji()
		{
			return null;
		}

		private void OnEmojiComplete(EmojiObjectUICtl pSender)
		{
		}
	}
}
