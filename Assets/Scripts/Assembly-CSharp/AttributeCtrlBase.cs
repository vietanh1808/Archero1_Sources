using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class AttributeCtrlBase
{
	protected EntityBase m_Entity;

	private string _className;

	private int _classid;

	private List<Goods_goods.GoodData> list;

	private GameObject effect;

	private bool bInit;

	public string ClassName => null;

	public int ClassID => 0;

	public Skill_alone m_Data { get; private set; }

	public Skill_skill m_SkillData { get; private set; }

	private void ExcuteAttributes()
	{
	}

	private void InstallAttrs(int symbol)
	{
	}

	public void Install(EntityBase entity, Skill_skill skilldata, Skill_alone skill, params object[] args)
	{
	}

	private void CreateEffect()
	{
	}

	private void RemoveEffect()
	{
	}

	protected virtual void OnInstall(params object[] args)
	{
	}

	protected virtual void OnInstall()
	{
	}

	public void Uninstall()
	{
	}

	protected virtual void OnUninstall()
	{
	}
}
