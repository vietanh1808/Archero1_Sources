using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleAssistantUICtrl : MonoBehaviour
{
	private const string Tag = "BattleAssistantUICtrl";

	[SerializeField]
	private ButtonCtrl m_btnAssistant;

	[SerializeField]
	private Image m_imgAssistant;

	[SerializeField]
	private Image m_imgAssistant_2;

	[SerializeField]
	private Image m_imgAssistant_3;

	[SerializeField]
	private Image m_imgAssistantMask_2;

	[SerializeField]
	private Image m_imgAssistantMask_3;

	[SerializeField]
	private Image m_imgCd;

	private float m_fTime;

	private float m_fCdTime;

	private Coroutine m_Coroutine;

	private Action<int> m_callback;

	private List<int> m_listIds;

	private int m_nIndex;

	private bool m_bIsDoorOpen;

	private BattleModuleData m_battleModuleData;

	public void Init(float time, List<int> ids, Action<int> callback)
	{
	}

	public void DeInit()
	{
	}

	public void UpdateUI()
	{
	}

	private void OnClick()
	{
	}

	private bool IsAllAssistantersDead()
	{
		return false;
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}
}
