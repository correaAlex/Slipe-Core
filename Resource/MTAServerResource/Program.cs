﻿using MTAServerWrapper;
using MTASharedWrapper;
using MTASharedWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MTAServerResource
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 v3 = new Vector2(5);
            Vector2 v4 = new Vector2(3);
            Vector2 result = v3 * 2;
            Vector2 result2 = 4 * v4;
            Console.WriteLine(result.X);
            Console.WriteLine(result2.X);
            Console.WriteLine(v3.Length());
            string asdf = "asdf";
            Console.WriteLine(asdf[2]); // will print d ?
            new Program();
        }

        public Program()
        {
            List<Vehicle> vehicles = new List<Vehicle>(); ;
            for (int i = 0; i < 10; i++)
            {
                Vehicle rhino = new Vehicle(VehicleModel.RHINO, new Vector3(i * 15, 0, 3));
                vehicles.Add(rhino);
            }
            vehicles[5].Rotation = new Vector3(0, 0, 45);

            MTAObject dildo = new MTAObject(321, new Vector3(3, 3, 3));
            dildo.Scale = new Vector3(3, 3, 3);
            dildo.Move(5000, new Vector3(3, 3, 10));

            vehicles[4].AttachTo(dildo, new Vector3(0, 0, 3));

            Dictionary<string, Vehicle> vehicleDictionary = new Dictionary<string, Vehicle>();
            vehicleDictionary["best"] = vehicles[3];
            vehicleDictionary["best"].Position = new Vector3(0, 0, 20);
            vehicleDictionary["best"].Frozen = true;

            foreach (Vehicle vehicle in ElementHelper.GetByType<Vehicle>())
            {
                vehicle.Rotation = new Vector3(0, 0, 90);
            }


            Vehicle alpha = new Vehicle(VehicleModel.ALPHA, new Vector3(0, 10, 3));

            Element.Root.AddEventHandler("onVehicleDamage");

            // alpha.AddEventHandler("onVehicleDamage");
            alpha.OnDamage += (float loss) =>
            {
                Console.WriteLine("Vehicle lost " + loss +" health");
            };
        }
    }
}