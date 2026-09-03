using System;
using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class BadgeManager : CInstance<BadgeManager>
{
	public bool isPullCardData;

	public BadgeActData actData;

	private bool isReReqS3;

	public BadgeActS3Data S3Data;

	private List<BadgeTagItemData> tagList;

	public Dictionary<int, List<BadgeBagItemData>> bagDict;

	public Dictionary<int, BadgeBagItemData> bagQuickDict;

	public Dictionary<int, List<BadgeCardItemData>> cardDict;

	public Dictionary<int, BadgeCardItemData> cardQuickDict;

	private List<BadgeBoxItemData> boxDataList;

	public List<BadgeTaskItemData> taskDataList;

	public int TagS3_Current => 0;

	public int OpenTagLocal => 0;

	public int Tag => 0;

	public int CurrentUpId => 0;

	public long LeftTime => 0L;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public List<BadgeBagItemData> GetBagList(int tagId)
	{
		return null;
	}

	public List<BadgeBagItemData> GetCurrentTagBagList()
	{
		return null;
	}

	public void reqS3Data()
	{
	}

	private void ParseJson()
	{
	}

	private BadgeS3Base GetS3TagDataOne(int tag)
	{
		return null;
	}

	private void setTagConfigData()
	{
	}

	public bool isOpenS3()
	{
		return false;
	}

	private void initTagData()
	{
	}

	public void initBagData()
	{
	}

	public void initCardData()
	{
	}

	public bool isOpenHeroUI()
	{
		return false;
	}

	public BadgeTagItemData GetTagItemData(int tagId)
	{
		return null;
	}

	public List<BadgeTagItemData> GetTagList()
	{
		return null;
	}

	public List<BadgeTagItemData> GetTagShowList()
	{
		return null;
	}

	public int GetTotalCardsCount(int tag)
	{
		return 0;
	}

	public int GetActiveCardsCount(int tag)
	{
		return 0;
	}

	public void requestBagOneReward(int bagId, Action<STRespGameBadge, int> action = null)
	{
	}

	public void requestBagAllReward(int tagId, Action<STRespGameBadge, int> action = null)
	{
	}

	public int GetBagOneCardsCount(int bagId)
	{
		return 0;
	}

	public int GetBagOneActiveCardsCount(int bagId)
	{
		return 0;
	}

	public Sprite GetCardBagCover(int bagId)
	{
		return null;
	}

	public List<BadgeCardItemData> GetCardListFromBag(int bagId)
	{
		return null;
	}

	public List<BadgeCardItemData> GetCardListFromTag(int tagId)
	{
		return null;
	}

	public bool canGetRewardBagOne(int bagId)
	{
		return false;
	}

	public bool canGetRewardBagAll(int tagId)
	{
		return false;
	}

	public BadgeS3UP GetS3UPDataOne(int upId)
	{
		return null;
	}

	public bool IsBagInUpGroupCurrent(int bagId)
	{
		return false;
	}

	public int GetUpLeftTimeCurrent()
	{
		return 0;
	}

	public int GetUpLeftTime(int upId)
	{
		return 0;
	}

	public bool isLastGroupUp(int upId)
	{
		return false;
	}

	public bool isLastUpWhenActEnd()
	{
		return false;
	}

	public void requestCardData(Action<STRespGameBadge, int> action = null)
	{
	}

	private void parseCardData(STRespGameBadge data)
	{
	}

	private BadgeBagItemData GetBagItemData(int bagId)
	{
		return null;
	}

	private BadgeCardItemData GetCardItemData(int cardId)
	{
		return null;
	}

	public void requestBagOpen(int bagId, int count, Action<STRespGameBadge, int> action = null)
	{
	}

	public void requestCardActive(int cardId, Action<STRespGameBadge, int> action = null)
	{
	}

	public bool CanActivateCard(BadgeCardItemData cardItem)
	{
		return false;
	}

	public bool IsBagAllActivated(int bagId)
	{
		return false;
	}

	public bool IsTagAllActivated(int tagId)
	{
		return false;
	}

	public bool HasActiveCard()
	{
		return false;
	}

	public List<string> GetConfigAttrs(int tag, int bagId)
	{
		return null;
	}

	public List<string> GetAttrTotalList()
	{
		return null;
	}

	public List<string> GetAttrOneList(int tag)
	{
		return null;
	}

	public List<string> combineAttributeList(List<string> preList)
	{
		return null;
	}

	public void requestActData(Action<STRespActivityBadge, int> action = null)
	{
	}

	private void parseActData(STRespActivityBadge data)
	{
	}

	public bool isOpenAct()
	{
		return false;
	}

	public void requestBoxGet(int boxid, Action<STRespActivityBadge, int> action = null)
	{
	}

	private void parseBoxData(STRespActivityBadge data)
	{
	}

	public List<BadgeBoxItemData> GetBoxDataList()
	{
		return null;
	}

	public BadgeBoxItemData GetBoxItemData(int boxId)
	{
		return null;
	}

	public int GetNeedMaxPoint()
	{
		return 0;
	}

	public void requestTaskGet(Action<STRespActivityBadge, int> action = null)
	{
	}

	private void parseTaskData(STRespActivityBadge data)
	{
	}

	public List<BadgeTaskItemData> GetTaskList()
	{
		return null;
	}

	public long GetDayLeftTime()
	{
		return 0L;
	}

	public bool canSendCardOther()
	{
		return false;
	}

	public int GetEventIdByCard(int cardId)
	{
		return 0;
	}

	public int GetGuildWishCount(ref int total, ref int have)
	{
		return 0;
	}

	public bool IsMainIconRed()
	{
		return false;
	}

	public bool IsRed_CardActive()
	{
		return false;
	}

	public bool IsRed_CardActiveFromTag(int tagId)
	{
		return false;
	}

	public bool IsRed_CardActiveFromBag(int bagId)
	{
		return false;
	}

	public bool IsRed_BagReward()
	{
		return false;
	}

	public bool IsRed_BagReward(int tagId)
	{
		return false;
	}

	public bool IsRed_TagReward()
	{
		return false;
	}

	public bool IsRed_TaskGet()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
