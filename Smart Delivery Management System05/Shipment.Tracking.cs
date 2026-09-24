using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System05
{
    public partial class Shipment
    {
        public  string TrackingStatus { get; set; }
        public string GetTrackingStatus()
        {
            return this.TrackingStatus;
        }
        public void UpdateTrackingStatus(string trackingStatus)
        {
            TrackingStatus = trackingStatus;
        }
    }
}
