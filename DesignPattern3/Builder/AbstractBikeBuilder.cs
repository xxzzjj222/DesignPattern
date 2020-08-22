using DesignPattern3.Builder.Example;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Builder
{
    abstract class AbstractBikeBuilder
    {
        protected Bike mBike = new Bike();

        public abstract BikeBuilder BuildFrame();

        public abstract BikeBuilder BuildSeat();


        public abstract BikeBuilder BuildTire();


        public abstract Bike Build();
    }
}
