﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvexHullProcessor
{
	public class Tuple<T1, T2>
	{
		public T1 First { get; private set; }
		public T2 Second { get; private set; }
		public T1 Item1 { get { return First; } }
		public T2 Item2 { get { return Second; } }
		internal Tuple(T1 first, T2 second)
		{
			First = first;
			Second = second;
		}
	}

	public static class Tuple
	{
		public static Tuple<T1, T2> New<T1, T2>(T1 first, T2 second)
		{
			var tuple = new Tuple<T1, T2>(first, second);
			return tuple;
		}

		public static Tuple<T1, T2> Create<T1, T2>(T1 first, T2 second)
		{
			var tuple = new Tuple<T1, T2>(first, second);
			return tuple;
		}
	}
}
