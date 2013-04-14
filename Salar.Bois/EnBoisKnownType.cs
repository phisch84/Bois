﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Salar.Bois
{
	enum EnBoisKnownType : byte
	{
		Unknown = 0,
		Int16,
		Int32,
		Int64,
		UInt16,
		UInt32,
		UInt64,
		Double,
		Decimal,
		Single,
		Byte,
		SByte,
		ByteArray,
		String,
		Char,
		Guid,
		Bool,
		Enum,
		DateTime,
		TimeSpan,
		DataSet,
		DataTable,
		NameValueColl,
		Color,
		Version,
		DbNull,
	}
}
