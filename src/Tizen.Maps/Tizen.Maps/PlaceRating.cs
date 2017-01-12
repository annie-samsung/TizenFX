﻿/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Maps
{
    /// <summary>
    /// Place Rating information, used in Place Discovery and Search requests
    /// </summary>
    public class PlaceRating
    {
        private int _count;
        private double _average;

        internal PlaceRating(Interop.PlaceRatingHandle handle)
        {
            _count = handle.Count;
            _average = handle.Average;
        }

        /// <summary>
        /// Number of users rated for this rating
        /// </summary>
        public int UserCount { get { return _count; } }

        /// <summary>
        /// Average value of user rating
        /// </summary>
        public double Average { get { return _average; } }

        public override string ToString()
        {
            return $"{Average}({UserCount} reviews)";
        }
    }
}
