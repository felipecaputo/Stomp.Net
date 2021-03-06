#region Usings

using System;
using Extend;

#endregion

namespace Stomp.Net.Util
{
    public static class ExceptionEx
    {
        public static StompException Create( this Exception cause )
        {
            var exception = cause as StompException;
            if ( exception != null )
                return exception;

            var msg = cause.Message;
            if ( msg.IsEmpty() )
                msg = cause.ToString();

            return new StompException( msg, cause );
        }

        public static MessageEofException CreateMessageEofException( this Exception cause )
        {
            var msg = cause.Message;
            if ( msg.IsEmpty() )
                msg = cause.ToString();

            return new MessageEofException( msg, cause );
        }

        public static MessageFormatException CreateMessageFormatException( this Exception cause )
        {
            var msg = cause.Message;
            if ( msg.IsEmpty() )
                msg = cause.ToString();

            var exception = new MessageFormatException( msg, cause );
            return exception;
        }
    }
}