using UnityEngine;
using UnityEngine.UI;

public class DailyRoleReversalSkillBtn : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image fillMask;

	private const string DailyRoleReversalSkillBtnUpdater = "DailyRoleReversalSkillBtnUpdater";

	private float CDTime;

	private float curAccumulativeTime;

	private bool isInit;

	private bool IsSkillBtnEnable => false;

	private float SkillPercent => 0f;

	private LocalSave.DailyRoleReversalSkillVO SkillVO => null;

	private void Init()
	{
	}

	public void Refresh(float CDTime)
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickBtn()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	public void Close()
	{
	}
}
