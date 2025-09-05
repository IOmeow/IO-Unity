using UnityEngine;
using UnityEngine.UI;

namespace IOmeow.UItools
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
        public static Vector2 MaxSizeWithinLimits(Texture image, float minWidth, float maxWidth, float minHeight, float maxHeight)
        {
            if (image == null) return Vector2.zero;

            float texWidth = image.width;
            float texHeight = image.height;
            float aspect = texWidth / texHeight;

            float width = maxWidth;
            float height = width / aspect;

            if (height > maxHeight)
            {
                height = maxHeight;
                width = height * aspect;
            }

            if (height < minHeight)
            {
                height = minHeight;
                width = height * aspect;
                if (width > maxWidth)
                    width = maxWidth;
            }

            return new Vector2(width, height);
        }
    }
}