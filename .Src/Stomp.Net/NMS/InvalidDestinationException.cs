#region Usings

using System;
using System.Runtime.Serialization;

#endregion

namespace Stomp.Net
{
    /// <summary>
    ///     An attempt is made to access an invalid destination
    /// </summary>
    [Serializable]
    public class InvalidDestinationException : StompException
    {
        #region Ctor

        public InvalidDestinationException( String message )
            : base( message )
        {
        }

        public InvalidDestinationException( String message, String errorCode )
            : base( message, errorCode )
        {
        }

        public InvalidDestinationException( String message, Exception innerException )
            : base( message, innerException )
        {
        }

        public InvalidDestinationException( String message, String errorCode, Exception innerException )
            : base( message, errorCode, innerException )
        {
        }

        /// <summary>
        ///     Initializes a new instance of the InvalidDestinationException class with serialized data.
        ///     Throws System.ArgumentNullException if the info parameter is null.
        ///     Throws System.Runtime.Serialization.SerializationException if the class name is null or System.Exception.HResult is
        ///     zero (0).
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected InvalidDestinationException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }

        #endregion
    }
}