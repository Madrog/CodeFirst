﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Samples.AspCoreEF.DAL.EF.Models
{
    public enum TaskState : byte {
        /// <summary>
        /// The task is Open.
        /// </summary>
        Open = 0,
        /// <summary>
        /// The task is active.
        /// </summary>
        Active = 1,
        /// <summary>
        /// The task is completed.
        /// </summary>
        Completed = 2,
        /// <summary>
        /// The task is closed.
        /// </summary>
        Closed = 3
    }
}
