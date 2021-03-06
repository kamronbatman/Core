#region Header
//   Vorspire    _,-'/-'/  RequestFlags.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2016  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;
#endregion

namespace VitaNex.Modules.WebStats
{
	[Flags]
	public enum WebStatsRequestFlags
	{
		None = 0x00,
		Server = 0x01,
		Stats = 0x02,
		Players = 0x04,
		PlayerGuilds = 0x08,
		PlayerStats = 0x10,
		PlayerSkills = 0x20,
		PlayerEquip = 0x40,

		All = Server | Stats | Players | PlayerGuilds | PlayerStats | PlayerSkills | PlayerEquip
	}
}