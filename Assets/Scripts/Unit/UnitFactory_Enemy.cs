using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class UnitFactory
{
    public class KaKa : Unit
    {
        public override void Init()
        {
            base.Init();
            SetName(GetType().Name);
        }
    }

    public class Yobin : Unit
    {
        public override void Init()
        {
            base.Init();
            SetName(GetType().Name);
        }
    }

    public class Wobang : Unit
    {
        public override void Init()
        {
            base.Init();
            SetName(GetType().Name);
        }
    }
}
