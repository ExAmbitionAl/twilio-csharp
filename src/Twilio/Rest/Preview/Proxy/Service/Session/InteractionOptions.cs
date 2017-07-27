/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Proxy.Service.Session 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch a specific Interaction.
    /// </summary>
    public class FetchInteractionOptions : IOptions<InteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Interaction.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchInteractionOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Interaction. </param>
        public FetchInteractionOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of all Interactions for a Session.
    /// </summary>
    public class ReadInteractionOptions : ReadOptions<InteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The Inbound Participant Status of this Interaction
        /// </summary>
        public InteractionResource.ResourceStatusEnum InboundParticipantStatus { get; set; }
        /// <summary>
        /// The Outbound Participant Status of this Interaction
        /// </summary>
        public InteractionResource.ResourceStatusEnum OutboundParticipantStatus { get; set; }

        /// <summary>
        /// Construct a new ReadInteractionOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        public ReadInteractionOptions(string pathServiceSid, string pathSessionSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (InboundParticipantStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("InboundParticipantStatus", InboundParticipantStatus.ToString()));
            }

            if (OutboundParticipantStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("OutboundParticipantStatus", OutboundParticipantStatus.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}