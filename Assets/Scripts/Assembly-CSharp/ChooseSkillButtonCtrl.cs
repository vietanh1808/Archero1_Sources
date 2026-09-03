using UnityEngine;

public class ChooseSkillButtonCtrl : MonoBehaviour
{
	private ChooseSkillOneCtrl[] list;

	private bool m_bPress;

	private bool m_bLongPress;

	private float m_fTime;

	private bool LongPress
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void OnPressDown()
	{
	}

	public void OnPressUp()
	{
	}

	public void OnClick(int recordSkillID = 0)
	{
	}

	public void OnLockClick()
	{
	}

	private void OnLongPress(bool value)
	{
	}

	public int GetSkillId()
	{
		return 0;
	}
}
