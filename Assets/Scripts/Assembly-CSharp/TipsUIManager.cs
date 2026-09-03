using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class TipsUIManager : CInstance<TipsUIManager>
{
	private const int sortingOrderOffset = 20;

	private Dictionary<string, TipsUICtrl> mList;

	public void ShowPotion(int id, int quality)
	{
	}

	private TipsUICtrl ShowInternal(string value, Color color)
	{
		return null;
	}

	public void ShowSeasonBPCode(int code)
	{
	}

	public void ShowError(string key, int code)
	{
	}

	public void ShowGuildErrorCode(int code, int type)
	{
	}

	public void ShowGuildErrorCode(int code)
	{
	}

	private TipsUICtrl ShowInternalLong(string value, Color color)
	{
		return null;
	}

	public void Show(string value)
	{
	}

	public void ShowLongTime(string value)
	{
	}

	public void Show(ETips type, Color color, params string[] args)
	{
	}

	public void ShowTestServer(string value)
	{
	}

	public void Show(string value, float y)
	{
	}

	public void Show(ETips type, params string[] args)
	{
	}

	public void ShowResponseCodeTips(int code)
	{
	}

	public void ShowError(int sendcode, int errorcode)
	{
	}

	public void ShowError(string info)
	{
	}

	public void ShowError(int sendcode, int childtype, int errorcode)
	{
	}

	public void ShowError(CReqItemPacket data, CCommonRespMsg error)
	{
	}

	public void ShowError(int sendcode, CCommonRespMsg error)
	{
	}

	public void ShowError(int errorcode)
	{
	}

	public void ShowCode(short errorcode, int type = 0)
	{
	}

	public void Cache(GameObject o)
	{
	}

	public new void Clear()
	{
	}
}
