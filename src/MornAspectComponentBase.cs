using UnityEngine;

namespace MornLib
{
    [ExecuteAlways]
    internal abstract class MornAspectComponentBase : MonoBehaviour
    {
        protected const float AspectTolerance = 0.001f;

        private void Awake()
        {
            if (Application.isPlaying) AdjustAspect();
        }

        private void Update()
        {
            AdjustAspect();
        }

        protected static bool TryGetGlobal(out MornAspectGlobal global)
        {
            global = MornAspectGlobal.I;
            return global != null;
        }

        protected abstract void AdjustAspect();
    }
}