public class HitStruct
{
	public EntityBase source;

	public long before_hit;

	public long real_hit;

	public long true_hit;

	public HitType type;

	public HitBulletStruct bulletdata;

	public HitSourceType sourcetype;

	public EElementType element;

	public int skillAloneId;

	public int soundid;

	public int buffid;

	public string arg0;

	public float BackRatio;

	public bool RealHitRaiseFlag;

	public bool IsDualCrit;

	public bool IsArtifact;

	public HitStruct Clone()
	{
		return null;
	}

	public void Reset()
	{
	}

	public void Deconstruct(out HitType _type, out long _before_hit)
	{
		_type = default;
		_before_hit = default;
	}
}
