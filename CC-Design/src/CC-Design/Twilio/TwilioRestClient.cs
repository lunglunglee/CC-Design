using System;

namespace Twilio
{
    internal class TwilioRestClient
    {
        private object authToken;
        private object sID;

        public TwilioRestClient(object sID, object authToken)
        {
            this.sID = sID;
            this.authToken = authToken;
        }

        internal object SendMessage(object sendNumber, string number, string message)
        {
            throw new NotImplementedException();
        }
    }
}