using DesignPattern3.Builder.Example;
using DesignPattern3.Builder.Example.Component.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Builder
{
    class BikeBuilder:AbstractBikeBuilder
    {
        //private Bike mBike = new Bike();

        public override BikeBuilder BuildFrame()
        {
            mBike.frame = new AlloyFrame();
            return this;
        }

        public override BikeBuilder BuildSeat()
        {
            mBike.seat = new DermisSeat();
            return this;
        }

        public override BikeBuilder BuildTire()
        {
            mBike.tire = new SolidTire();
            return this;
        }

        public override Bike Build()
        {
            return mBike;
        }
    }
}
