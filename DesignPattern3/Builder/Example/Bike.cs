using DesignPattern3.Builder.Example.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Builder.Example
{
    class Bike
    {
        /// <summary>
        /// 自行车框架
        /// </summary>
        public IFrame frame { set; get; }
        /// <summary>
        /// 自行车座椅
        /// </summary>
        public ISeat seat { set; get; }
        /// <summary>
        /// 自行车 轮胎
        /// </summary>
        public ITire tire { set; get; }

        public Bike()
        {

        }

        public Bike(IFrame frame, ISeat seat, ITire tire)
        {
            this.frame = frame;
            this.seat = seat;
            this.tire = tire;
        }
    }
}
