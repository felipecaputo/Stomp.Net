#region Usings

using System;

#endregion

namespace Stomp.Net.Stomp.Commands
{
    public class ConnectionError : BaseCommand
    {
        #region Properties

        public BrokerError Exception { get; set; }

        private ConnectionId ConnectionId { get; set; }

        #endregion

        /// <summery>
        ///     Get the unique identifier that this object and its own
        ///     Marshaler share.
        /// </summery>
        public override Byte GetDataStructureType()
            => DataStructureTypes.ErrorType;

        /// <summery>
        ///     Returns a string containing the information for this DataStructure
        ///     such as its type and value of its elements.
        /// </summery>
        public override String ToString()
            => GetType()
                   .Name + "[" +
               "Exception=" + Exception +
               "ConnectionId=" + ConnectionId +
               "]";
    }
}