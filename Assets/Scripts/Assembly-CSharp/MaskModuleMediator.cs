using PureMVC.Interfaces;

public class MaskModuleMediator : MediatorBase, IMediator, INotifier
{
	public MaskModuleMediator()
		: base(null)
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	protected override void OnRegisterEvery()
	{
	}
}
