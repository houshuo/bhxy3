﻿namespace MoleMole.Config
{
    using MoleMole;
    using System;

    [GeneratePartialHash(CombineGeneratedFile=true)]
    public class HitExplodeTracePositionBulletMixin : HitExplodeBulletMixin, IHashable
    {
        public float Angle;
        public bool BaseOnTarget;
        public float Distance;
        public float TraceStartDelay = 0.1f;
        public float TracingLerpCoef;
        public float TracingLerpCoefAcc;

        public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier)
        {
            return new AbilityHitExplodeTracingPositionBulletMixin(instancedAbility, instancedModifier, this);
        }

        public void ObjectContentHashOnto(ref int lastHash)
        {
            HashUtils.ContentHashOnto(this.TracingLerpCoef, ref lastHash);
            HashUtils.ContentHashOnto(this.TracingLerpCoefAcc, ref lastHash);
            HashUtils.ContentHashOnto(this.TraceStartDelay, ref lastHash);
            HashUtils.ContentHashOnto(this.Distance, ref lastHash);
            HashUtils.ContentHashOnto(this.Angle, ref lastHash);
            HashUtils.ContentHashOnto(this.BaseOnTarget, ref lastHash);
            HashUtils.ContentHashOnto(base.BulletTypeName, ref lastHash);
            HashUtils.ContentHashOnto((int) base.Targetting, ref lastHash);
            if (base.BulletSpeed != null)
            {
                HashUtils.ContentHashOnto(base.BulletSpeed.isDynamic, ref lastHash);
                HashUtils.ContentHashOnto(base.BulletSpeed.fixedValue, ref lastHash);
                HashUtils.ContentHashOnto(base.BulletSpeed.dynamicKey, ref lastHash);
            }
            HashUtils.ContentHashOnto(base.IgnoreTimeScale, ref lastHash);
            if (base.AliveDuration != null)
            {
                HashUtils.ContentHashOnto(base.AliveDuration.isDynamic, ref lastHash);
                HashUtils.ContentHashOnto(base.AliveDuration.fixedValue, ref lastHash);
                HashUtils.ContentHashOnto(base.AliveDuration.dynamicKey, ref lastHash);
            }
            if (base.HitExplodeRadius != null)
            {
                HashUtils.ContentHashOnto(base.HitExplodeRadius.isDynamic, ref lastHash);
                HashUtils.ContentHashOnto(base.HitExplodeRadius.fixedValue, ref lastHash);
                HashUtils.ContentHashOnto(base.HitExplodeRadius.dynamicKey, ref lastHash);
            }
            HashUtils.ContentHashOnto(base.IsFixedHeight, ref lastHash);
            if (base.BulletEffect != null)
            {
                HashUtils.ContentHashOnto(base.BulletEffect.EffectPattern, ref lastHash);
                HashUtils.ContentHashOnto(base.BulletEffect.AudioPattern, ref lastHash);
            }
            HashUtils.ContentHashOnto(base.ApplyDistinctHitExplodeEffectPattern, ref lastHash);
            if (base.DistinctHitExplodeHeight != null)
            {
                HashUtils.ContentHashOnto(base.DistinctHitExplodeHeight.isDynamic, ref lastHash);
                HashUtils.ContentHashOnto(base.DistinctHitExplodeHeight.fixedValue, ref lastHash);
                HashUtils.ContentHashOnto(base.DistinctHitExplodeHeight.dynamicKey, ref lastHash);
            }
            if (base.HitExplodeEffect != null)
            {
                HashUtils.ContentHashOnto(base.HitExplodeEffect.EffectPattern, ref lastHash);
                HashUtils.ContentHashOnto(base.HitExplodeEffect.AudioPattern, ref lastHash);
            }
            if (base.HitExplodeEffectAir != null)
            {
                HashUtils.ContentHashOnto(base.HitExplodeEffectAir.EffectPattern, ref lastHash);
                HashUtils.ContentHashOnto(base.HitExplodeEffectAir.AudioPattern, ref lastHash);
            }
            if (base.HitExplodeEffectGround != null)
            {
                HashUtils.ContentHashOnto(base.HitExplodeEffectGround.EffectPattern, ref lastHash);
                HashUtils.ContentHashOnto(base.HitExplodeEffectGround.AudioPattern, ref lastHash);
            }
            if (base.SelfExplodeEffect != null)
            {
                HashUtils.ContentHashOnto(base.SelfExplodeEffect.EffectPattern, ref lastHash);
                HashUtils.ContentHashOnto(base.SelfExplodeEffect.AudioPattern, ref lastHash);
            }
            HashUtils.ContentHashOnto(base.MuteSelfHitExplodeActions, ref lastHash);
            HashUtils.ContentHashOnto(base.IsHitChangeTargetDirection, ref lastHash);
            HashUtils.ContentHashOnto(base.HitAnimEventID, ref lastHash);
            HashUtils.ContentHashOnto(base.FaceTarget, ref lastHash);
            HashUtils.ContentHashOnto((int) base.RemoveClearType, ref lastHash);
            HashUtils.ContentHashOnto((int) base.BulletHitType, ref lastHash);
            HashUtils.ContentHashOnto(base.BulletEffectGround, ref lastHash);
            HashUtils.ContentHashOnto(base.ExplodeEffectGround, ref lastHash);
            HashUtils.ContentHashOnto(base.ResetTime, ref lastHash);
            if (base.HitExplodeActions != null)
            {
                foreach (ConfigAbilityAction action in base.HitExplodeActions)
                {
                    if (action is IHashable)
                    {
                        HashUtils.ContentHashOnto((IHashable) action, ref lastHash);
                    }
                }
            }
        }
    }
}

