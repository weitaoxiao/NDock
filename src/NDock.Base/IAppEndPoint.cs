﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDock.Base
{
    /// <summary>
    /// The interface which can abtract the absolute address of one application instance in the whole system
    /// </summary>
    public interface IAppEndPoint
    {
        /// <summary>
        /// Gets the identity of one application instance.
        /// </summary>
        /// <value>
        /// The identity.
        /// </value>
        object Identity { get; }
    }
}
