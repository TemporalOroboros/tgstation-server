﻿using System;

namespace Tgstation.Server.Client.Rights
{
	/// <summary>
	/// Rights for <see cref="Components.IByondClient"/>
	/// </summary>
	[Flags]
	public enum ByondRights
	{
		/// <summary>
		/// User has no rights
		/// </summary>
		None = 0,
		/// <summary>
		/// User may check the installed BYOND version
		/// </summary>
		ReadInstalled = 1,
		/// <summary>
		/// User may check the staged BYOND version
		/// </summary>
		ReadStaged = 2,
		/// <summary>
		/// User may install any BYOND version if none is installed
		/// </summary>
		Install = 4,
		/// <summary>
		/// User may upgrade the installed BYOND version
		/// </summary>
		Upgrade = 8,
		/// <summary>
		/// User may downgrade the installed BYOND version
		/// </summary>
		Downgrade = 16,
		/// <summary>
		/// User may cancel any pending installation job
		/// </summary>
		Cancel = 32
	}
}
