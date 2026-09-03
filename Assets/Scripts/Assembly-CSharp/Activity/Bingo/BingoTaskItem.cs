using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.Bingo
{
	public class BingoTaskItem : MonoBehaviour
	{
		public Text TitleText;

		public Text PercentText;

		public Text GetRewardText;

		public ButtonCtrl GetBtn;

		private LocalUnityObjctPool Pool;

		public BingoTask Data;

		public (bool, bool, int) states;

		public PropOneEquip CopyProp;

		public GridLayoutGroup RewardParent;

		private List<PropOneEquip> RewardList;

		public Image bg_Img;

		public Image title_Img;

		public Image button_Img;

		public GameObject maskObj;

		private Dictionary<int, int> typeToTask;

		public void SetData(BingoTask data)
		{
		}

		public void Refresh()
		{
		}

		public virtual void OnLanguageChange()
		{
		}
	}
}
