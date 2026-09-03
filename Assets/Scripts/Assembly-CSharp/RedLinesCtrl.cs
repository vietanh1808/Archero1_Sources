using System.Collections.Generic;

public class RedLinesCtrl
{
	private List<RedLineCtrl> list;

	public List<RedLineCtrl> RedLineCtrlList => null;

	protected virtual RedLineCtrl createRedLineCtrl()
	{
		return null;
	}

	public void PlayLinesAnim(float time = 0.3f)
	{
	}

	public void Init(EntityBase entity, bool throughwall, int ReboundCount, int count, float perangle, float offsetX = 0f)
	{
	}

	public void Init(EntityBase entity, bool throughwall, int ReboundCount, int count, float perangle, int forwardCnt = 1, float forwardOffsetX = 1f, float offsetX = 0f)
	{
	}

	public void DeInit()
	{
	}

	public void Update()
	{
	}
}
