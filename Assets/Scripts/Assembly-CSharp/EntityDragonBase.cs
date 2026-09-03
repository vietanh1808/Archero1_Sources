public class EntityDragonBase : EntityBase
{
	public EntityBase HostEntity;

	protected DragonVO mDragonVO;

	protected AIDragonBase aiDragon;

	public AIDragonBase GetAIDragon()
	{
		return null;
	}

	public DragonVO GetDragonVO()
	{
		return null;
	}

	public void SetDragonVO(DragonVO vo, EntityBase hostEntity)
	{
	}

	public override void Init(int charId)
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	public override void DeInit()
	{
	}

	public void StopAndDisappear()
	{
	}

	protected override void CreateModel()
	{
	}

	protected override void InitAnimations()
	{
	}

	private void addClip(string animName)
	{
	}

	protected void InitAI()
	{
	}

	public void StartAttack()
	{
	}
}
