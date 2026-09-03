using UnityEngine;
using UnityEngine.UI;

namespace Guild.Hall
{
	public class GuildSiginBase : GuildBaseMono
	{
		public class RewardItem
		{
			public int id;

			public int num;

			public int type;
		}

		[Header("图标")]
		public Image icon;

		public Sprite closeSpr;

		public Sprite openSpr;

		[Header("名称")]
		public Text nameValue;

		public ButtonCtrl checkBtn;

		[Header("时间")]
		public Transform timeObject;

		public Text timeValue;

		public Image timeIcon;

		public GameObject redNode;

		protected string objName;

		public const long m = 60L;

		public const long h = 3600L;

		public const long d = 86400L;

		private float updateTimeTag;

		protected string GetTime(string key, params object[] values)
		{
			return null;
		}

		public override void OnInit()
		{
		}

		protected virtual void OnCheckClick()
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
