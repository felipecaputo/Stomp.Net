#region Usings

using System;
using System.Runtime.Serialization;

#endregion

namespace Apache.NMS
{
    [Serializable]
    public class ResourceAllocationException : NMSException
    {
        #region Ctor

        public ResourceAllocationException()
        {
        }

        public ResourceAllocationException( String message )
            : base( message )
        {
        }

        public ResourceAllocationException( String message, String errorCode )
            : base( message, errorCode )
        {
        }

        public ResourceAllocationException( String message, Exception innerException )
            : base( message, innerException )
        {
        }

        public ResourceAllocationException( String message, String errorCode, Exception innerException )
            : base( message, errorCode, innerException )
        {
        }

        #region ISerializable interface implementation

#if !NETCF

        /// <summary>
        ///     Initializes a new instance of the ResourceAllocationException class with serialized data.
        ///     Throws System.ArgumentNullException if the info parameter is null.
        ///     Throws System.Runtime.Serialization.SerializationException if the class name is null or System.Exception.HResult is
        ///     zero (0).
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected ResourceAllocationException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }

#endif

        #endregion

        #endregion
    }
}