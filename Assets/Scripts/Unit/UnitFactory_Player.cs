using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class UnitFactory
{
    public class Bora : Unit
    {
        public override void Init()
        {
            base.Init();
            SetName(GetType().Name);
        }
    }

    public class Uni : Unit
    {
        public override void Init()
        {
            base.Init();
            SetName(GetType().Name);
        }
    }

    public class Arma : Unit
    {
        public override void Init()
        {
            base.Init();
            SetName(GetType().Name);
        }
    }
}
