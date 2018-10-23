using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Youmi.RNYoumi
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNYoumiModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNYoumiModule"/>.
        /// </summary>
        internal RNYoumiModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNYoumi";
            }
        }
    }
}
