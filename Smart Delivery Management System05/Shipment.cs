using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System05
{
    public class Shipment : ICloneable
    {

        string _TackingCode;
        string _Description;
        decimal _Weight;
        decimal _DeliveryFee;

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Static Constructor initialization!");
        }
        public Shipment()
        {
            TotalShipmentsCreated++;
        }
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
            TotalShipmentsCreated++;
        }

        public Shipment(string tackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : this()
        {
            _TackingCode = tackingCode;
            _Description = description;
            _Weight = weight;
            _DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get
            {
                return _TackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _TackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _Description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                if (value > 0)
                    _Weight = value;
            }
        }



        public decimal DeliveryFee
        {
            get
            {
                return _DeliveryFee;
            }
            private set
            {
                if (value > 0)
                    _DeliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost { get; }

        public static int TotalShipmentsCreated { get; set; }
        public override string ToString()
        {
            return
                $"Tracking Code: {TrackingCode}\n" +
                $"Description: {Description}\n" +
                $"Weight: {Weight}\n" +
                $"Delivery Fee: {DeliveryFee}\n" +
                $"Estimated Cost: {EstimatedCost}\n" +
                $"Destination: {Destination.City}, {Destination.Street}, {Destination.Building_Number}" +
                $"\n-------------------------------------------------";
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;

        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}\n" +
               $"Description: {Description}\n" +
               $"Weight: {Weight}\n" +
               $"Delivery Fee: {DeliveryFee}\n" +
               $"Estimated Cost: {EstimatedCost}\n" +
               $"Destination: {Destination.City}, {Destination.Street}, {Destination.Building_Number}" +
               $"\n-------------------------------------------------");
        }


        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {

            Weight = baseWeight + extraPackingWeight;

        }
        public Shipment CopyShipment()
        {
            Shipment copyShipment = new Shipment();
            copyShipment.TrackingCode = this.TrackingCode;
            copyShipment.Description = this.Description;
            copyShipment.Weight = this.Weight;
            copyShipment.DeliveryFee = this.DeliveryFee;
            copyShipment.Destination = this.Destination;
            TotalShipmentsCreated++;

            return copyShipment;

        }

        public Shipment ShallowCopy()
        {

            return (Shipment)this.MemberwiseClone();
        }

        public object Clone()
        {
            return ShallowCopy();
        }

        public Shipment DeepCopy()
        {
            Shipment copyShipment = new Shipment();
            copyShipment.TrackingCode = this.TrackingCode;
            copyShipment.Description = this.Description;
            copyShipment.Weight = this.Weight;
            copyShipment.DeliveryFee = this.DeliveryFee;
            copyShipment.Destination = new DeliveryAddress(this.Destination.City, this.Destination.Street, this.Destination.Building_Number);

            return copyShipment;

        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
    }
}
