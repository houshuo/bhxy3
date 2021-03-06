﻿namespace MoleMole
{
    using System;
    using System.Runtime.InteropServices;
    using UnityEngine;

    public class LDDropEnhanceCrit : LDDropDataItem
    {
        public string abilityName = "Goods_EnhanceCrit";
        public int dropNum = 1;

        public override void CreateDropGoods(Vector3 initPos, Vector3 initDir, bool actDropAnim = false)
        {
            for (int i = 0; i < this.dropNum; i++)
            {
                Singleton<DynamicObjectManager>.Instance.CreateGood(0x21800001, "Crit", this.abilityName, 0f, initPos, initDir, actDropAnim, false);
            }
        }
    }
}

