using System.Collections.Generic;
using UnityEngine;

public class RedLineCtrl
{
	protected EntityBase m_Entity;

	private bool bEnd;

	private List<GameObject> RedLineList;

	private List<BulletRedLineCtrl> lineCtrlList;

	private float resultangle;

	private Vector3 resultpos;

	private Vector3 nextpos;

	private float lastangle;

	protected int ReboundCount;

	private float offsetangle;

	private bool bThroughWall;

	private float offsetPosX;

	private int layerMask;

	protected List<float> offsetAngleList;

	public List<BulletRedLineCtrl> LineCtrlList => null;

	public void Init(EntityBase entity, bool throughwall, int ReboundCount, float offsetangle, float offsetPosX = 0f)
	{
	}

	public void DeInit()
	{
	}

	protected virtual GameObject getRedLineResource()
	{
		return null;
	}

	protected virtual Transform getRedLineNode()
	{
		return null;
	}

	private void CreateRedLine()
	{
	}

	protected virtual Transform getOriginalTrans()
	{
		return null;
	}

	private void UpdateLinesData()
	{
	}

	public void PlayLinesAnim(float time = 0.3f)
	{
	}

	private void UpdateLinesLength()
	{
	}

	private void UpdateLineLength(int index)
	{
	}

	protected virtual void getReflectAngle(ref float resultangle, float incidenceAngle, Vector3 hitPos, int index)
	{
	}

	private void RemoveRedLine()
	{
	}

	public void Update()
	{
	}
}
