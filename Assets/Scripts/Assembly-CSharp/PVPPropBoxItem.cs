using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class PVPPropBoxItem : MonoBehaviour
{
	public Image boxImg;

	public ButtonCtrl mButton;

	public Action<Vector3, List<Drop_DropModel.DropData>> OnClickEvent;

	private PVPRewardBoxData mdata;

	private void Awake()
	{
	}

	public void Init(PVPRewardBoxData data)
	{
	}

	public List<Drop_DropModel.DropData> GetList()
	{
		return null;
	}

	private void OnClickBase()
	{
	}
}
