using System;
using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2267 : SkillAloneBase
{
	public List<GameObject> statueList;

	public GameObject goServerSatatue;

	public GameObject goPlayerStatue;

	private EntityBase entityOther;

	private Material serverWorshipMat;

	private Material otherWorshipMat;

	private ParticleSystem serverWorshipEffect;

	private ParticleSystem otherWorshipEffect;

	private GameObject goFootDir;

	private GameObject goCD;

	private float worshipCd;

	private bool isServerWorshipOk;

	private bool isOtherWorshipOk;

	private Camera uiCamera;

	private Camera screenCamera;

	private RectTransform infoParent;

	private List<PVPPlayerStatueInfo> infoList;

	private SequencePool mSeqPool;

	private float serverCdTime;

	private float otherCdTime;

	private bool isReq;

	protected override void OnInstall()
	{
	}

	private void CreateStatue(PVPStatueData sData)
	{
	}

	private void CreatePlayerStatue()
	{
	}

	private GameObject CreatePlayerStatue(bool isSelf)
	{
		return null;
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	private void CreateFootDirection()
	{
	}

	private void CreateWorshipEffect()
	{
	}

	private void CreateWorshipCircle()
	{
	}

	private void CreateStatueCollider()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ClearStatue(RoomGenerateBase.Room room)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	protected void SyncWorshipOK(bool isServer)
	{
	}

	private void Update(float timeScale)
	{
	}

	private Vector2 CalculatePos(Vector3 myPos, Vector3 targetPos)
	{
		return default;
	}

	private void ReqWorShip(Action<bool> callback, bool isSelf = true)
	{
	}

	private void SendSdk(bool isSelf, string rewardList)
	{
	}
}
