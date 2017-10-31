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

using System;

namespace Tizen.Multimedia
{
    /// <summary>
    /// Provides data for the <see cref="Recorder.RecordingLimitReached"/> event.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    public class RecordingLimitReachedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingLimitReachedEventArgs"/> class
        /// with the specified type.
        /// </summary>
        /// <param name="type">The type of the limit.</param>
        /// <since_tizen> 3 </since_tizen>
        public RecordingLimitReachedEventArgs(RecordingLimitType type)
        {
            Type = type;
        }

        /// <summary>
        /// Gets the type of the limit.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public RecordingLimitType Type { get; }
    }
}
