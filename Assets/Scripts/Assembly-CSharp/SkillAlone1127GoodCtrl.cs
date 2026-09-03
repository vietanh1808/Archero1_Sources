using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1127GoodCtrl : MonoBehaviour
{
	private CapsuleCollider m_Collider;

	private SkillAlone1127GoodCtrl another;

	private Action<SkillAlone1127GoodCtrl, SkillAlone1127GoodCtrl> OnTriggerEvent;

	private EntityBase m_Entity;

	private bool isPortalEnable;

	private List<SkillAlone1127GoodCtrl> portalList;

	private Func<SkillAlone1127GoodCtrl, SkillAlone1127GoodCtrl> GetAnotherPortal;

	private bool isDynamicAnothter;

	private CapsuleCollider Collider => null;

	public void Init(SkillAlone1127GoodCtrl target, EntityBase entity, Action<SkillAlone1127GoodCtrl, SkillAlone1127GoodCtrl> OnTriggerEvent)
	{
	}

	public void Init(EntityBase entity, Action<SkillAlone1127GoodCtrl, SkillAlone1127GoodCtrl> OnTriggerEvent, Func<SkillAlone1127GoodCtrl, SkillAlone1127GoodCtrl> getAnother)
	{
	}

	public void SetEnable(bool enable)
	{
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	public void DeInit()
	{
	}
}
