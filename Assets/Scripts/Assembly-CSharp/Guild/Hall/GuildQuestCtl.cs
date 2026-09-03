using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Guild.Hall
{
	public class GuildQuestCtl : GuildBaseMono
	{
		public Text titleText;

		public Text leftTitle;

		public Text rightTitle;

		public Transform contentView;

		public GuildQuestItem tempItem;

		private GuildQuestInfo questInfo;

		private List<GuildQuestItem> itemList;

		private bool isResting;

		private float updateTimeTag;

		public override void OnInit()
		{
		}

		public override void OnOpen()
		{
		}

		public override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void RestQuestData()
		{
		}

		private GuildQuestItem CreatOneQuest()
		{
			return null;
		}

		private void RefQuestListUI()
		{
		}

		private void OnGuildInfoUpdate(object data)
		{
		}

		private void Update()
		{
		}

		protected virtual void UpdateTime()
		{
		}
	}
}
