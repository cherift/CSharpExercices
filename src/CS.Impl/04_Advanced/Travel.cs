using System;
using System.Collections.Generic;

namespace CS.Impl._04_Advanced
{
    public class Travel
    {
        public TravelRoadmap BuildTravelRoadmap(City initial, City destination)
        {
            DistanceHelper distanceHelper = new DistanceHelper();

            TravelRoadmap travelRoadmap = new TravelRoadmap();

            List<TransportMode> modes = new List<TransportMode>();

            if (distanceHelper.GetDistance(initial, destination) == Distance.Short)
            {
                modes.Add(TransportMode.Car);
                modes.Add(TransportMode.Foot);
                modes.Add(TransportMode.Train);
            }
            else if (distanceHelper.GetDistance(initial, destination) == Distance.Medium)
            {
                modes.Add(TransportMode.Car);
                modes.Add(TransportMode.Train);
                modes.Add(TransportMode.Plane);
            }
            else
            {
                modes.Add(TransportMode.Boat);
                modes.Add(TransportMode.Plane);
            }

            travelRoadmap.Modes = modes;

            return travelRoadmap;
        }
    }

    public class TravelRoadmap
    {
        public IEnumerable<TransportMode> Modes { get; set; }
    }

    public enum City
    {
        Barcelona,
        London,
        Sydney
    }

    public enum TransportMode
    {
        Foot,
        Car,
        Train,
        Boat,
        Plane
    }

    public class DistanceHelper
    {
        public Distance GetDistance(City initial, City destination)
        {
            if (initial == destination)
            {
                return Distance.Short;
            }
            else if (initial == City.Barcelona && destination == City.London || destination == City.Barcelona && initial == City.London)
            {
                return Distance.Medium;
            }
            else
            {
                return Distance.Long;
            }
        }
    }

    public enum Distance
    {
        Short,
        Medium,
        Long
    }
}