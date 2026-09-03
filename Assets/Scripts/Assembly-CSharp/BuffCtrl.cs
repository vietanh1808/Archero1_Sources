using System.Collections.Generic;
using TableTool;

public class BuffCtrl : EntityCtrlBase
{
	protected List<BuffAloneBase> mBuffAllList;

	protected Dictionary<int, BuffAloneBase> mBuffs_eResetTime;

	protected Dictionary<int, BuffAloneBase> mBuffs_eOnlyOne;

	protected Dictionary<int, List<BuffAloneBase>> mBuffs_Overlap;

	protected Dictionary<int, BuffAloneBase> mBuffs_eOverlapAndResetTime;

	private List<BuffAloneBase> removeList;

	private BuffAloneBase data1;

	public override void OnStart(List<EBattleAction> actIds)
	{
	}

	public override void ExcuteCommend(EBattleAction id, object action)
	{
	}

	private void AddBuff(BattleStruct.BuffStruct bs)
	{
	}

	private void CheckCoverBuff(in BattleStruct.BuffStruct data)
	{
	}

	private bool CheckRefreshBuff(in BattleStruct.BuffStruct data, out BattleStruct.BuffStruct[] sts)
	{
		sts = null;
		return false;
	}

	private void RemoveBuff(BattleStruct.BuffStruct data)
	{
	}

	private BuffAloneBase getBuff(BattleStruct.BuffStruct data, Buff_alone buff_alone, bool bOverlapEffect = true)
	{
		return null;
	}

	protected void RemoveBuff(int buffId, BuffAloneBase removebuff = null)
	{
	}

	private void removebuff_overlap(int index, int buffId, BuffAloneBase buff)
	{
	}

	public override void OnUpdate(float delta)
	{
	}

	public override void OnRemove()
	{
	}

	public bool IsHaveDebuff(int id)
	{
		return false;
	}

	public bool IsHaveFireDebuff()
	{
		return false;
	}

	public bool IsHaveThunderDebuff()
	{
		return false;
	}

	public bool IsHavePoisonDebuff()
	{
		return false;
	}

	public bool IsHaveIceDebuff()
	{
		return false;
	}

	public bool IsHaveBlackDebuff()
	{
		return false;
	}

	public bool IsHaveElementDebuff(int buffId, string att_element)
	{
		return false;
	}

	public bool IsHaveBuffById(int buffId, out BuffAloneBase buffData)
	{
		buffData = null;
		return false;
	}

	public List<int> GetAllBuffIds()
	{
		return null;
	}

	public int GetDebuffCount()
	{
		return 0;
	}
}
