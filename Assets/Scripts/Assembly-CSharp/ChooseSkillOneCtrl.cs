using System;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSkillOneCtrl : MonoBehaviour
{
	private int skillid;

	private DxxText text;

	private FitContentText skillDesc;

	protected Image image;

	private int index;

	private RectTransform rectt;

	private float allspeed;

	private int endindex;

	private float endposy;

	private ChooseSkillProxy.ChooseSkillType type;

	private Image bgImage;

	private bool bStart;

	private Action mRandomName;

	private int mNum;

	private int mColumn;

	private int mCount;

	private const float time = 0.1f;

	private float movetime;

	private bool bLast;

	private bool bRevert;

	private int mRevertState;

	private float mEndPosY;

	private int? stopAniIndex;

	private void Awake()
	{
	}

	public virtual void Init(int skillid, DxxText text, ChooseSkillProxy.ChooseSkillType type)
	{
	}

	public virtual void Init(int skillid, DxxText text, FitContentText skillDesc, ChooseSkillProxy.ChooseSkillType type)
	{
	}

	public void Init2(int skillid, DxxText text, ChooseSkillProxy.ChooseSkillType type)
	{
	}

	protected virtual void UpdateIcon()
	{
	}

	private void Modify()
	{
	}

	public void OnClick(int recordSkillID = 0)
	{
	}

	public void OnLockClick()
	{
	}

	public bool GetSkillId(out int id)
	{
		id = default;
		return false;
	}

	public void OnLongPress(bool bLongPress)
	{
	}

	protected virtual void LearnSkill()
	{
	}

	public int GetShowSkill()
	{
		return 0;
	}

	private void Update()
	{
	}

	protected virtual void OnScrollEnd(int id)
	{
	}

	private void ModifyPositionY()
	{
	}

	public void AddAction(int num, int column, int count, Action randomname, int? stopAniIndex)
	{
	}

	public void JumpAni()
	{
	}

	public bool IsEnd()
	{
		return false;
	}
}
