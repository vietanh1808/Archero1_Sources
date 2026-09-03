using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class BabySkillUICtrl : MonoBehaviour
{
	private class IconTime
	{
		public EntityBase e;

		public Transform t;

		public float fStartTime;

		public float fLastValue;
	}

	public GameObject CopyOne;

	public AnimationCurve Curve;

	private LocalUnityObjctPool mObjPool;

	private List<EntityBabyBase> babies;

	private List<IconTime> skillIcons;

	private SequencePool mSeqPol;

	private const float m_fTotalTime = 1.4f;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	private void OnCreateBaby()
	{
	}

	private void InitBabies()
	{
	}

	public void OnBabyAddNewSkill(EntityBase baby, int id)
	{
	}

	private void Update()
	{
	}

	private void OnChangeHero(int heroid)
	{
	}
}
