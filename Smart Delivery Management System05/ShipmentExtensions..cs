using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Smart_Delivery_Management_System05
{
    public static class ShipmentExtensions
    {

        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {shipment.TrackingStatus}";


        }
    }
}