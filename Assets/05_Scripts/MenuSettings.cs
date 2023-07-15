using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSettings : MonoBehaviour { }

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("QualitySettings")]
    [Tooltip("Shader hardware tier classification for current device.")]
    public class SetGraphicsActiveTier : FsmStateAction
    {
        [Tooltip("The torque forceMode")]
        [ObjectType(typeof(UnityEngine.Rendering.GraphicsTier))]
        public FsmEnum tier;


        public override void OnEnter()
        {
            Graphics.activeTier = (UnityEngine.Rendering.GraphicsTier)tier.Value;
            Finish();
        }
    }
}

