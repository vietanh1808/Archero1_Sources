using UnityEngine;

public class CountDown : MonoBehaviour
{
	private EntityBase m_Entity;

	private float m_fTime;

	private string m_strCdTextFormater;

	public DxxText cdText;

	private Transform mTransform;

	private void Awake()
	{
	}

	public void Init(EntityBase entity, float time)
	{
	}

	public void Init(EntityBase entity, float time, string formater)
	{
	}

	private void LateUpdate()
	{
	}

	public void DeInit()
	{
	}
}
