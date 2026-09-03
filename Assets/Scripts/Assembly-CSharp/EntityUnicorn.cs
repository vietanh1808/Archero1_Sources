public class EntityUnicorn : EntityParentBase
{
	public EntityBase.Unicorn HostUnicorn { get; private set; }

	public bool IsReady { get; set; }

	public void DeInit()
	{
	}

	public override void SetEntityParent(EntityBase entity)
	{
	}

	public void SetUnicorn(EntityBase.Unicorn _unicorn)
	{
	}
}
