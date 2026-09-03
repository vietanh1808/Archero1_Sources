public class EntityCallBase : EntityBase
{
	protected EntityBase m_Parent;

	protected AIBase m_AIBase;

	public CountDown m_CdText;

	private float m_fCdTime;

	public int ParentTeamID { get; protected set; }

	public int? CallId { get; set; }

	protected override void OnInitBefore()
	{
	}

	public void SetParent(EntityBase entity)
	{
	}

	public EntityBase GetParent()
	{
		return null;
	}

	private bool checkIfMeadowBattle()
	{
		return false;
	}

	public AIBase_TD InitAIBase_TD()
	{
		return null;
	}

	public AIBase_FrozenFort_Monster InitAIBase_FrozenFort()
	{
		return null;
	}

	public AIBase_Artifact_Monster InitAIBase_Artifact()
	{
		return null;
	}

	public AIBase_Backpack InitAIBase_Backpack()
	{
		return null;
	}

	public AIMeadowBattleBase InitAIMeadowBattle()
	{
		return null;
	}

	private void handleCustomeAttackWeights(AIMeadowBattleBase aiBase)
	{
	}

	protected override void OnCreateModel()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	protected override long GetBossHP()
	{
		return 0L;
	}

	protected override void OnDeadBefore()
	{
	}

	public override void RemoveMove()
	{
	}

	public AIBase GetAI()
	{
		return null;
	}

	public void SetCdTime(float time)
	{
	}

	public void SetCdTime(float time, string formater)
	{
	}

	public void HideCd()
	{
	}

	protected void CreateCdText()
	{
	}

	protected void ExcuteSoldierUp()
	{
	}
}
