using System;
using UnityEngine;

public class SkillGetItem : MonoBehaviour
{
	public ButtonCtrl clickBtn;

	public PauseUISkillIconCtrl skillIconCtrl;

	public Action<Vector3, int> onClick;

	public void Init(int skillId)
	{
	}
}
