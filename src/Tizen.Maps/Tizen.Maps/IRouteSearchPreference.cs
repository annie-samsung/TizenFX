/*
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


namespace Tizen.Maps
{
    /// <summary>
    /// Preferences for route searches
    /// </summary>
    public interface IRouteSearchPreference
    {
        /// <summary>
        /// Distance unit
        /// </summary>
        DistanceUnit Unit { get; set; }

        /// <summary>
        /// Selected route optimization
        /// </summary>
        RouteOptimization Optimization { get; set; }

        /// <summary>
        /// Route transport mode
        /// </summary>
        TransportMode Mode { get; set; }

        /// <summary>
        /// Route feature weight
        /// </summary>
        RouteFeatureWeight RouteFeatureWeight { get; set; }

        /// <summary>
        /// Route feature
        /// </summary>
        RouteFeature RouteFeature { get; set; }

        /// <summary>
        /// Indicate if search for alternative routes is enabled.
        /// </summary>
        bool SearchAlternativeRoutes { get; set; }
    }
}