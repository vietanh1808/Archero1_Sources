using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2180CombineBuffCtrl : MonoBehaviour
{
	[SerializeField]
	private Transform skillParent;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private List<Transform> allBuffEffectTrans;

	[SerializeField]
	private List<ParticleSystem> allBuffAddEffectPar;

	private List<int> allBuffList;

	private List<int> allActiveBuff;

	public void Init(List<int> allBuffList)
	{
	}

	public void AddBuffEffect(int buffID)
	{
	}

	public void ClearEffect()
	{
	}

	private void Update()
	{
	}

	private void RefreshEffect(int curAddBuff)
	{
	}
}
