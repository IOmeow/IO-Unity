using UnityEngine;
using UnityEngine.UI;

namespace IOmeow.Utility
{
    public static class GeneralUI
    {
        public static void FadeGraphic(Graphic graphic, float dstA, float rate)
        {
            Color c = graphic.color;
            float a = Mathf.SmoothStep(c.a, dstA, rate);

            if (a > 0.99f) a = 1;
            else if (a < 0.01f) a = 0;

            c.a = a;
            graphic.color = c;
        }
    }
}