﻿/******************************************************************************
 *
 *    MIConvexHull, Copyright (C) 2013 David Sehnal, Matthew Campbell
 *
 *  This library is free software; you can redistribute it and/or modify it 
 *  under the terms of  the GNU Lesser General Public License as published by 
 *  the Free Software Foundation; either version 2.1 of the License, or 
 *  (at your option) any later version.
 *
 *  This library is distributed in the hope that it will be useful, 
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of 
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser 
 *  General Public License for more details.
 *  
 *****************************************************************************/

namespace ConvexHullProcessor
{
    static class Constants
    {
        /// <summary>
        /// A value used to determine if a vertex lies on a plane.
        /// </summary>
        public const double PlaneDistanceTolerance = 0.0000001;
		public const double epsilon = 0.00001;

		public static bool SamePosition(double[] v1, double[] v2, int dim)
		{
			for (int i = 0; i < dim; i++)
			{
				if (System.Math.Abs(v1[i] - v2[i]) > epsilon)
				{
					return false;
				}
			}
			return true;
		}
    }
}
