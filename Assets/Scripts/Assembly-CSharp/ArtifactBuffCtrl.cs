using System.Collections.Generic;
using UnityEngine;

public class ArtifactBuffCtrl : MonoBehaviour
{
	private List<int> deBuffs;

	private List<int> buffs;

	private EntityArtifactBase m_Entity;

	public void SetBelongEntity(EntityArtifactBase entity)
	{
	}

	public void InitBuffs(int[] buffs, int[] debuffs)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private EntityBase GetTarget(Collider other)
	{
		return null;
	}
}
