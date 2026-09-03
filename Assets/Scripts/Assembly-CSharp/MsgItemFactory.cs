using System.Collections.Generic;
using Habby.Guild.Data;
using UnityEngine;

public sealed class MsgItemFactory : CInstance<MsgItemFactory>
{
	public GameObject Poller;

	private LocalUnityObjctPool mPool;

	public void init(GameObject parent)
	{
	}

	private void createItemCache()
	{
	}

	private void createItemCacheOne<T>(ChatMsgType type) where T : MsgItemBase
	{
	}

	public void collectMsgItem()
	{
	}

	public MsgItemBase getMsgItem(ChatMsgType type)
	{
		return null;
	}

	public GuildMessageEntity createMsgEntity(string text)
	{
		return null;
	}

	public MsgDataBase GetMsgData(GuildMessageEntity pMsg)
	{
		return null;
	}

	public ChatMsgDataBase createChatMsgOne(GuildMessageEntity pMsg)
	{
		return null;
	}

	public ChatMsgDataBase createChatMsgOne(MsgDataBase msg)
	{
		return null;
	}

	public MsgDataText createMsgText(GuildMessageEntity pMsg)
	{
		return null;
	}

	public MsgDataAction createMsgAction(GuildMessageEntity pMsg)
	{
		return null;
	}

	public ChatMsgDataBase createChatMsgForText(MsgDataText msgText)
	{
		return null;
	}

	public ChatMsgDataBase createChatMsgForAction(ActionData action)
	{
		return null;
	}

	public void updateMsgDataOne(ChatMsgDataBase d, ActionData action, string fromid)
	{
	}

	public ChatMsgDataBase createChatDataGuild(ActionData action)
	{
		return null;
	}

	public ChatMsgDataBase createChatDataGuildLevel(ActionData action)
	{
		return null;
	}

	public ChatMsgDataBase createChatDataActivityGift(ActionData action)
	{
		return null;
	}

	public List<ChatMsgDataBase> createGuildMsgLevelAdd(int level)
	{
		return null;
	}

	public ChatMsgDataBase createChatDataChat(ActionData action)
	{
		return null;
	}

	public ChatMsgDataHelp createChatDataHelp(ActionData action)
	{
		return null;
	}

	public ChatMsgDataGift createChatDataGift(ActionData action)
	{
		return null;
	}

	public ChatMsgDataGift createChatDataGift(ActionGiftBoxList.GiftItem item)
	{
		return null;
	}

	public ChatMsgDataCombine CreateChatDataCombine(ActionData action)
	{
		return null;
	}

	public ChatMsgDataBattle CreateChatDataBattle(ActionData action)
	{
		return null;
	}
}
