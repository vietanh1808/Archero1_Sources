using System;
using System.Collections.Generic;
using Habby.Guild.Data;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

namespace Guild.Hall
{
	public class GuildDonateUIPanel : GuildBaseMono
	{
		public class DonateItem
		{
			private Action<DonateItem> btnCall;

			private GameObject itemObject;

			private GameObject selectObject;

			public Guild_DonateConfig config { get; private set; }

			public PropOneEquip propOneEquip { get; private set; }

			public CostItem costItem { get; private set; }

			public DonateItem(Guild_DonateConfig cfg, Action<DonateItem> delgate)
			{
			}

			public void SetGameObject(GameObject itemobj)
			{
			}

			public void RefItem()
			{
			}

			public void SetSelect(bool selected)
			{
			}

			public bool IsEnough()
			{
				return false;
			}

			public void AddItemCount(int num)
			{
			}

			public void PushDataToProp(PropOneEquip propOne)
			{
			}

			public void OnClick()
			{
			}
		}

		[Header("面板信息")]
		public Text panleTiele;

		public Text refresTime;

		public ButtonCtrl closeBtn;

		[Header("钻石捐献信息")]
		public Text diamondName;

		public Text diamondGiveSor;

		public Text diamondGiveValue;

		public Text diamonBtnValue;

		public ButtonCtrl donatDiamondBtn;

		[Header("金币捐献信息")]
		public Text goldName;

		public Text goldGiveSor;

		public Text goldGiveValue;

		public Text goldlefttime;

		public Text goldBtnValue;

		public ButtonCtrl donatGoldBtn;

		[Header("选中道具捐献信息")]
		public Text itemDontTitle;

		public Text itemDontelefttime;

		public Image curItemIcon;

		public PropOneEquip curEquipOne;

		public Text curItemGiveSor;

		public Text curItemGiveDiamond;

		public Text curItemNeedText;

		public Text itemDonateBtnText;

		public ButtonCtrl itemDonateBtn;

		[Header("道具列表信息")]
		public RectTransform itemView;

		public Transform itemTemp;

		private bool isOpen;

		private DiamondCostList diamondCostList;

		private Guild_DonateConfig diamondCfg;

		private Guild_DonateConfig goldCfg;

		private DonateItem curDonateItem;

		private CostItem goldCostItem;

		private List<DonateItem> itemList;

		private bool isdonateing;

		public override void OnInit()
		{
		}

		private void InitUI()
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

		private void RestUI()
		{
		}

		private void RestGoldDonate()
		{
		}

		private void RestDiamondDonate()
		{
		}

		private void ResetItemDonate()
		{
		}

		private int GetDonateMaxCount(DonateCountType pType, out int donateCount)
		{
			donateCount = default;
			return 0;
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void ClickCloseBtn()
		{
		}

		private void OnItemClick(DonateItem sender)
		{
		}

		private void OnDiamondDonateClick()
		{
		}

		private void OnGoldDonateClick()
		{
		}

		private void OnItemDonateClick()
		{
		}

		private void SendDiamondDonate()
		{
		}

		private bool SendDonatRequest(int caseId, MessageDelgate<ActionDonateToGuild> pOnComplete)
		{
			return false;
		}

		private void ShowDonateErrorCode(int code, int type)
		{
		}

		private void ShowSuccReward(int sor, int xp)
		{
		}

		private void OnGuildInfoUpdate(GuildInfoData data)
		{
		}

		private void OnGuildInfoChanged(object data)
		{
		}

		private void Update()
		{
		}

		private void UpdateTime()
		{
		}

		private void SendTGPPoint(int code, string step, int donatType, int gems, int conins, int itemId, int itemCount, int score, int xp)
		{
		}
	}
}
