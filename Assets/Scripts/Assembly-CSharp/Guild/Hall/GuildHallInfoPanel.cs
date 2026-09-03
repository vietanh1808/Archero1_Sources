using Habby.Guild.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Guild.Hall
{
	public class GuildHallInfoPanel : GuildBaseMono
	{
		[Header("文字信息")]
		public Text guildName;

		public Text memberCount;

		public Text guildLv;

		public Text guildSor;

		public Text guildId;

		public Text infoBtnText;

		[Header("进度条")]
		public Image sorBar;

		[Header("公会图标")]
		[SerializeField]
		private GuildBadgeItem guildBadgeItem;

		[Header("按钮")]
		public ButtonCtrl infoBtn;

		public ButtonCtrl chanlBtn;

		public ButtonCtrl Button_Rank;

		public DxxText Text_Rank;

		[SerializeField]
		private RedNodeOneCtrl redNode;

		private int curLevel;

		private int curExp;

		private float expFillDuration;

		private bool isTweening;

		public override void OnInit()
		{
		}

		public override void OnOpen()
		{
		}

		private void OnFakeDataChange(object o)
		{
		}

		private void CacheApplyList()
		{
		}

		private void CacheActivityObject()
		{
		}

		private static bool CanApplyJoin()
		{
			return false;
		}

		public override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void SetUI(object o)
		{
		}

		private void SetUI()
		{
		}

		private void SetBasicInfo()
		{
		}

		private void SetExp()
		{
		}

		private void CheckLevel(GuildInfoData data)
		{
		}

		private void SetRedPoint()
		{
		}
	}
}
