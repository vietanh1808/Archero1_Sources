using System;
using System.Collections.Generic;
using Habby.Guild.Data;
using UnityEngine;

public class GuildMemberItemCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText txtRankNo;

	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private DxxText txtRank;

	[SerializeField]
	private DxxText txtActivity;

	[SerializeField]
	private HeadItem headItem;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private ButtonCtrl btn_Manor;

	public GuildMemberInfo data;

	public int index;

	private Action<GuildMemberItemCtrl> onClick;

	private RectTransform _scrollViewRect;

	private void Awake()
	{
	}

	public void OnClickManorBtn()
	{
	}

	public void SetData(int index, List<GuildMemberInfo> dataArr, Action<GuildMemberItemCtrl> onClick, RectTransform scrollViewRect, bool isSelfIn = false)
	{
	}

	private void SetDynamicUI()
	{
	}

	private void Update()
	{
	}
}
