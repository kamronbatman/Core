﻿#region Header
//   Vorspire    _,-'/-'/  Crypto_Init.cs
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
using System.Linq;
using System.Security.Cryptography;
#endregion

namespace VitaNex.Crypto
{
	[CoreService("Crypto", "3.0.0.0", TaskPriority.Highest)]
	public static partial class CryptoService
	{
		static CryptoService()
		{
			HashTypes = ((CryptoHashType)0).GetValues<CryptoHashType>();

			Providers =
				HashTypes.Select(h => new CryptoHashCodeProvider((int)h, HashAlgorithm.Create(h.ToString())))
						 .Where(p => p.Provider != null)
						 .ToDictionary(p => p.ProviderID, p => p);
		}
	}
}