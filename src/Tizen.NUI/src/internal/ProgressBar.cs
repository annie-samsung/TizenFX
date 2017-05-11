/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI.UIComponents
{

    using System;
    using System.Runtime.InteropServices;
    using Tizen.NUI.BaseComponents;

    /// <summary>
    /// ProgressBar is a control to give the user an indication of the progress of an operation.
    /// </summary>
    public class ProgressBar : View
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal ProgressBar(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.ProgressBar_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            // By default, we do not want the position to use the anchor point
            PositionUsesAnchorPoint = false;
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ProgressBar obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        /// <summary>
        /// To make ProgressBar instance be disposed.
        /// </summary>
        public override void Dispose()
        {
            if (!Window.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_ProgressBar(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }



        /// <summary>
        /// Event arguments that passed via ValueChangedEventArgs
        /// </summary>
        public class ValueChangedEventArgs : EventArgs
        {
            private ProgressBar _progressBar;
            private float _progressValue;
            private float _secondaryProgressValue;

            public ProgressBar ProgressBar
            {
                get
                {
                    return _progressBar;
                }
                set
                {
                    _progressBar = value;
                }
            }

            public float ProgressValue
            {
                get
                {
                    return _progressValue;
                }
                set
                {
                    _progressValue = value;
                }
            }

            public float SecondaryProgressValue
            {
                get
                {
                    return _secondaryProgressValue;
                }
                set
                {
                    _secondaryProgressValue = value;
                }
            }

        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ValueChangedCallbackDelegate(IntPtr progressBar, float progressValue, float secondaryProgressValue);
        private EventHandler<ValueChangedEventArgs> _progressBarValueChangedEventHandler;
        private ValueChangedCallbackDelegate _progressBarValueChangedCallbackDelegate;

        /// <summary>
        /// Event is sent when the ProgressBar value changes.
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ValueChanged
        {
            add
            {
                if (_progressBarValueChangedEventHandler == null)
                {
                    _progressBarValueChangedCallbackDelegate = (OnValueChanged);
                    ValueChangedSignal().Connect(_progressBarValueChangedCallbackDelegate);
                }
                _progressBarValueChangedEventHandler += value;
            }
            remove
            {
                _progressBarValueChangedEventHandler -= value;
                if (_progressBarValueChangedEventHandler == null && ValueChangedSignal().Empty() == false)
                {
                    ValueChangedSignal().Disconnect(_progressBarValueChangedCallbackDelegate);
                }
            }
        }

        // Callback for ProgressBar ValueChanged signal
        private void OnValueChanged(IntPtr progressBar, float progressValue, float secondaryProgressValue)
        {
            ValueChangedEventArgs e = new ValueChangedEventArgs();

            // Populate all members of "e" (ValueChangedEventArgs) with real page
            e.ProgressBar = ProgressBar.GetProgressBarFromPtr(progressBar);
            e.ProgressValue = progressValue;
            e.SecondaryProgressValue = secondaryProgressValue;

            if (_progressBarValueChangedEventHandler != null)
            {
                _progressBarValueChangedEventHandler(this, e);
            }
        }

        /// <summary>
        /// </summary>
        internal static ProgressBar GetProgressBarFromPtr(global::System.IntPtr cPtr)
        {
            ProgressBar ret = new ProgressBar(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }


        internal class Property : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal Property(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            ~Property()
            {
                DisposeQueue.Instance.Add(this);
            }

            public virtual void Dispose()
            {
                if (!Window.IsInstalled()) {
                    DisposeQueue.Instance.Add(this);
                    return;
                }

                lock (this)
                {
                    if (swigCPtr.Handle != global::System.IntPtr.Zero)
                    {
                        if (swigCMemOwn)
                        {
                            swigCMemOwn = false;
                            NDalicPINVOKE.delete_ProgressBar_Property(swigCPtr);
                        }
                        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                    }
                    global::System.GC.SuppressFinalize(this);
                }
            }

            internal Property() : this(NDalicPINVOKE.new_ProgressBar_Property(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            internal static readonly int PROGRESS_VALUE = NDalicPINVOKE.ProgressBar_Property_PROGRESS_VALUE_get();
            internal static readonly int SECONDARY_PROGRESS_VALUE = NDalicPINVOKE.ProgressBar_Property_SECONDARY_PROGRESS_VALUE_get();
            internal static readonly int INDETERMINATE = NDalicPINVOKE.ProgressBar_Property_INDETERMINATE_get();
            internal static readonly int TRACK_VISUAL = NDalicPINVOKE.ProgressBar_Property_TRACK_VISUAL_get();
            internal static readonly int PROGRESS_VISUAL = NDalicPINVOKE.ProgressBar_Property_PROGRESS_VISUAL_get();
            internal static readonly int SECONDARY_PROGRESS_VISUAL = NDalicPINVOKE.ProgressBar_Property_SECONDARY_PROGRESS_VISUAL_get();
            internal static readonly int INDETERMINATE_VISUAL = NDalicPINVOKE.ProgressBar_Property_INDETERMINATE_VISUAL_get();
            internal static readonly int INDETERMINATE_VISUAL_ANIMATION = NDalicPINVOKE.ProgressBar_Property_INDETERMINATE_VISUAL_ANIMATION_get();
            internal static readonly int LABEL_VISUAL = NDalicPINVOKE.ProgressBar_Property_LABEL_VISUAL_get();

        }

        /// <summary>
        /// Creates the ProgressBar.
        /// </summary>
        public ProgressBar() : this(NDalicPINVOKE.ProgressBar_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        internal ProgressBar(ProgressBar handle) : this(NDalicPINVOKE.new_ProgressBar__SWIG_1(ProgressBar.getCPtr(handle)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal ProgressBar Assign(ProgressBar handle)
        {
            ProgressBar ret = new ProgressBar(NDalicPINVOKE.ProgressBar_Assign(swigCPtr, ProgressBar.getCPtr(handle)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Downcasts a handle to ProgressBar handle.<br>
        /// If handle points to a ProgressBar, the downcast produces valid handle.<br>
        /// If not the returned handle is left uninitialized.<br>
        /// </summary>
        /// <param name="handle">Handle to an object</param>
        /// <returns>handle to a ProgressBar or an uninitialized handle</returns>
        public new static ProgressBar DownCast(BaseHandle handle)
        {
            ProgressBar ret = new ProgressBar(NDalicPINVOKE.ProgressBar_DownCast(BaseHandle.getCPtr(handle)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ProgressBarValueChangedSignal ValueChangedSignal()
        {
            ProgressBarValueChangedSignal ret = new ProgressBarValueChangedSignal(NDalicPINVOKE.ProgressBar_ValueChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal enum PropertyRange
        {
            PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
            PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX + 1000
        }

        /// <summary>
        /// The progress value of progress bar, progress runs form 0 to 1.<br>
        /// If Value is set to 0, progress bar will be set to beginning.<br>
        /// If Value is set to 1, progress bar will be set to end.<br>
        /// Any Value outside of the range is ignored.<br>
        /// </summary>
        public float ProgressValue
        {
            get
            {
                float temp = 0.0f;
                GetProperty(ProgressBar.Property.PROGRESS_VALUE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.PROGRESS_VALUE, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The secondary progress value of progress bar, secondary progress runs form 0 to 1.<br>
        /// Optional. If not supplied, the default is 0.<br>
        /// If Value is set to 0, progress bar will be set secondary progress to beginning.<br>
        /// If Value is set to 1, progress bar will be set secondary progress to end.<br>
        /// Any Value outside of the range is ignored.<br>
        /// </summary>
        public float SecondaryProgressValue
        {
            get
            {
                float temp = 0.0f;
                GetProperty(ProgressBar.Property.SECONDARY_PROGRESS_VALUE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.SECONDARY_PROGRESS_VALUE, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// Sets the progress-bar as \e indeterminate state.
        /// </summary>
        public bool Indeterminate
        {
            get
            {
                bool temp = false;
                GetProperty(ProgressBar.Property.INDETERMINATE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.INDETERMINATE, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The track Visual value of progress bar, it's a full progress area and it's shown behind PROGRESS_VISUAL.<br>
        /// Optional. If not supplied, the default track visual will be shown.<br>
        /// </summary>
        public Tizen.NUI.PropertyMap TrackVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(ProgressBar.Property.TRACK_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.TRACK_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The progress Visual value of progress bar, size of the progress visual is changed based on PROGRESS_VALUE.<br>
        /// Optional. If not supplied, the default progress visual will be shown.<br>
        /// </summary>
        public Tizen.NUI.PropertyMap ProgressVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(ProgressBar.Property.PROGRESS_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.PROGRESS_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The secondary progress visual of progress bar, size of the secondary progress visual is changed based on SECONDARY_PROGRESS_VALUE.<br>
        /// Optional. If not supplied, the secondary progress visual will not be shown.<br>
        /// </summary>
        public Tizen.NUI.PropertyMap SecondaryProgressVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(ProgressBar.Property.SECONDARY_PROGRESS_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.SECONDARY_PROGRESS_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The indeterminate visual of progress bar.<br>
        /// Optional. If not supplied, the default inditerminate visual will be shown.<br>
        /// </summary>
        public Tizen.NUI.PropertyMap IndeterminateVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(ProgressBar.Property.INDETERMINATE_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.INDETERMINATE_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The transition data for indeterminate visual animation.<br>
        /// Optional. If not supplied, default animation will be played.<br>
        /// </summary>
        public Tizen.NUI.PropertyArray IndeterminateVisualAnimation
        {
            get
            {
                Tizen.NUI.PropertyArray temp = new Tizen.NUI.PropertyArray();
                GetProperty(ProgressBar.Property.INDETERMINATE_VISUAL_ANIMATION).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.INDETERMINATE_VISUAL_ANIMATION, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// The Label visual of progress bar.
        /// </summary>
        public Tizen.NUI.PropertyMap LabelVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(ProgressBar.Property.LABEL_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(ProgressBar.Property.LABEL_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

    }

}
