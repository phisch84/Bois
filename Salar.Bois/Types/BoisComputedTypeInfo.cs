﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Salar.Bois.Types
{
	delegate void SerializeDelegate<T>(BinaryWriter writer, T instance, Encoding encoding);

	delegate T DeserializeDelegate<T>(BinaryReader reader, Encoding encoding);


	class BoisComputedTypeInfo
	{
		internal Delegate WriterDelegate;

		internal Delegate ReaderDelegate;

		internal MethodInfo WriterMethod;

		internal MethodInfo ReaderMethod;

		internal void InvokeWriter<T>(BinaryWriter writer, T instance, Encoding encoding)
		{
			((SerializeDelegate<T>)WriterDelegate).Invoke(writer, instance, encoding);
		}

		internal T InvokeReader<T>(BinaryReader reader, Encoding encoding)
		{
			return ((DeserializeDelegate<T>)ReaderDelegate).Invoke(reader, encoding);
		}
	}
}