#region Usings

using System;

#endregion

namespace Apache.NMS.Stomp.Threads
{
    /// <summary>
    ///     Represents a task that may take a few iterations to complete.
    /// </summary>
    public interface Task
    {
        Boolean Iterate();
    }
}