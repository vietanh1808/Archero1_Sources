public class BodyMaskCamera
{
	private EntityBase m_Entity;

	private float updateTime;

	private float currentTime;

	private RoomState state;

	protected virtual float Width => 0f;

	protected virtual float Height => 0f;

	public BodyMaskCamera(EntityBase entity)
	{
	}

	public void DeInit()
	{
	}

	private void OnUpdate(float delta)
	{
	}
}
