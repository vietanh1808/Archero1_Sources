using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class AppFacade : Facade, IFacade, INotifier, IDisposable
{
	protected override void InitializeController()
	{
	}

	protected override void InitializeModel()
	{
	}

	protected override void InitializeView()
	{
	}

	public AppFacade()
		: base(null)
	{
	}
}
