using System;
using System.Collections.Generic;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	public class MacroCommand : Notifier, ICommand, INotifier
	{
		private readonly IList<object> m_subCommands;

		public MacroCommand()
		{
		}

		public MacroCommand(IEnumerable<Type> types)
		{
		}

		public MacroCommand(IEnumerable<ICommand> commands)
		{
		}

		public MacroCommand(IEnumerable<object> commandCollection)
		{
		}

		public void Execute(INotification notification)
		{
		}

		protected virtual void InitializeMacroCommand()
		{
		}

		protected void AddSubCommand(Type commandType)
		{
		}

		protected void AddSubCommand(ICommand command)
		{
		}
	}
}
