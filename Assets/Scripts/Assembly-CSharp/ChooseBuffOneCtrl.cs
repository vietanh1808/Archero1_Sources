using System;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBuffOneCtrl : MonoBehaviour
{
	private int skillid;

	private DxxText text;

	private Image image;

	private int index;

	private RectTransform rectt;

	private float allspeed;

	private int endindex;

	private float endposy;

	private bool bStart;

	private Action mRandomName;

	private int mColumn;

	private int mCount;

	private const float time = 0.06f;

	private float movetime;

	private bool bLast;

	private bool bRevert;

	private int mRevertState;

	private float mEndPosY;

	private void Awake()
	{
	}

	public void Init(int skillid, DxxText text)
	{
	}

	private void Modify()
	{
	}

	public void OnClick()
	{
	}

	public bool IsResult()
	{
		return false;
	}

	private void Update()
	{
	}

	private void ModifyPositionY()
	{
	}

	public void AddAction(int column, int count, Action randomname)
	{
	}

	public int GetSkillId()
	{
		return 0;
	}
}
