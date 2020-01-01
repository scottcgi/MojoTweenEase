/*
 * The original algorithms of easing functions come from Robert Penner.
 * The open source licensed under the MIT License and the BSD License.
 *
 * Introduce: http://robertpenner.com/easing
 * License  : http://robertpenner.com/easing_terms_of_use.html
 *
 *----------------------------------------------------------------------------------------------------------------------
 * 
 * Copyright (c) scott.cgi All Rights Reserved.
 *
 * This source code belongs to project MojoTweenEase, which is hosted on GitHub, and licensed under the MIT License.
 *
 * License: https://github.com/scottcgi/MojoTweenEase/blob/master/LICENSE
 * GitHub : https://github.com/scottcgi/MojoTweenEase
 *
 * Since  : 2019-12-23
 * Author : scott.cgi
 * Version: 1.0.0
 */

using System;

public static class TweenEase
{
    private static float Linear(float time)
    {
        return time;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float QuadraticIn(float time)
    {
        return time * time;
    }


    private static float QuadraticOut(float time)
    {
        return time * (2.0f - time);
    }


    private static float QuadraticInOut(float time)
    {
        if (time < 0.5f)
        {
            return time * time * 2.0f;
        }

        return 2.0f * time * (2.0f - time) - 1.0f;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float CubicIn(float time)
    {
        return time * time * time;
    }


    private static float CubicOut(float time)
    {
        time -= 1.0f;
        return time * time * time + 1.0f;
    }


    private static float CubicInOut(float time)
    {
        if (time < 0.5f)
        {
            return 4.0f * (time * time * time);
        }

        time -= 1.0f;
        return time * time * time * 4.0f + 1.0f;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float QuarticIn(float time)
    {
        return time * time * time * time;
    }


    private static float QuarticOut(float time)
    {
        time -= 1.0f;
        return 1.0f - time * time * time * time;
    }


    private static float QuarticInOut(float time)
    {
        if (time < 0.5f)
        {
            return 8.0f * time * time * time * time;
        }

        time -= 1.0f;
        return 1.0f - 8.0f * time * time * time * time;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float QuinticIn(float time)
    {
        return time * time * time * time * time;
    }


    private static float QuinticOut(float time)
    {
        time -= 1.0f;
        return time * time * time * time * time + 1.0f;
    }


    private static float QuinticInOut(float time)
    {
        if (time < 0.5f)
        {
            return 16.0f * time * time * time * time * time;
        }

        time -= 1.0f;
        return 16.0f * time * time * time * time * time + 1.0f;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float SineIn(float time)
    {
        return 1.0f - Mathf.Cos(time * 1.570796f);
    }


    private static float SineOut(float time)
    {
        return Mathf.Sin(time * 1.570796f);
    }


    private static float SineInOut(float time)
    {
        return 0.5f * (1.0f - Mathf.Cos(time * 3.141593f));
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float ExponentialIn(float time)
    {
        if (time <= 0.0)
        {
            return time;
        }

        return Mathf.Pow(2.0f, 10.0f * time - 10.0f);
    }


    private static float ExponentialOut(float time)
    {
        if (time >= 1.0)
        {
            return time;
        }

        return 1.0f - Mathf.Pow(2.0f, -10.0f * time);
    }


    private static float ExponentialInOut(float time)
    {
        if (time <= 0.0 || time >= 1.0)
        {
            return time;
        }

        if (time < 0.5f)
        {
            return 0.5f * Mathf.Pow(2.0f, 20.0f * time - 10.0f);
        }

        return 0.5f * (2.0f - Mathf.Pow(2.0f, 10.0f - 20.0f * time));
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float CircularIn(float time)
    {
        return 1.0f - Mathf.Sqrt(1.0f - time * time);
    }


    private static float CircularOut(float time)
    {
        return Mathf.Sqrt((2.0f - time) * time);
    }


    private static float CircularInOut(float time)
    {
        if (time < 0.5f)
        {
            return 0.5f * (1.0f - Mathf.Sqrt(1.0f - time * time * 4.0f));
        }

        time -= 1.0f;
        return 0.5f * (Mathf.Sqrt(1.0f - time * time * 4.0f) + 1.0f);
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float ElasticIn(float time)
    {
        if (time <= 0.0 || time >= 1.0)
        {
            return time;
        }

        return -Mathf.Pow(2.0f, 10.0f * time - 10.0f) * Mathf.Sin(20.923007f * time - 22.493803f);
    }


    private static float ElasticOut(float time)
    {
        if (time <= 0.0 || time >= 1.0)
        {
            return time;
        }

        return Mathf.Pow(2.0f, -10.0f * time) * Mathf.Sin(20.923007f * time - 1.570796f) + 1.0f;
    }


    private static float ElasticInOut(float time)
    {
        if (time <= 0.0 || time >= 1.0)
        {
            return time;
        }

        if (time < 0.5f)
        {
            return -0.5f * (Mathf.Pow(2.0f, 20.0f * time - 10.0f) * Mathf.Sin(27.960175f * time - 15.550884f));
        }

        return Mathf.Pow(2.0f, -20.0f * time + 10.0f) * Mathf.Sin(27.960175f * time - 15.550884f) * 0.5f + 1.0f;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float BackIn(float time)
    {
        return time * time * (2.70158f * time - 1.70158f);
    }


    private static float BackOut(float time)
    {
        time -= 1.0f;
        return time * time * (2.70158f * time + 1.70158f) + 1.0f;
    }


    private static float BackInOut(float time)
    {
        if (time < 0.5f)
        {
            return time * time * (14.379638f * time - 5.189819f);
        }

        time -= 1.0f;
        return time * time * (14.379638f * time + 5.189819f) + 1.0f;
    }


    private static float BackInExponentialOut(float time)
    {
        if (time < 0.5f)
        {
            return time * time * (14.379638f * time - 5.189819f);
        }

        return 0.5f * (2.0f - Mathf.Pow(2.0f, 10.0f - 20.0f * time));
    }


    private static float BackInElasticOut(float time)
    {
        if (time < 0.5f)
        {
            return time * time * (14.379638f * time - 5.189819f);
        }

        return Mathf.Pow(2.0f, -20.0f * time + 10.0f) * Mathf.Sin(27.960175f * time - 15.550884f) * 0.5f + 1.0f;
    }


//----------------------------------------------------------------------------------------------------------------------


    private static float BounceOut(float time)
    {
        if (time < 0.363636f)
        {
            return time * time * 7.5625f;
        }

        if (time < 0.72727f)
        {
            time -= 0.545454f;
            return time * time * 7.5625f + 0.75f;
        }

        if (time < 0.909091f)
        {
            time -= 0.818182f;
            return time * time * 7.5625f + 0.9375f;
        }

        if (time >= 1.0f)
        {
            return time;
        }

        time -= 0.954545f;
        return time * time * 7.5625f + 0.984375f;
    }


    private static float BounceIn(float time)
    {
        if (time > 0.636364f)
        {
            time = 1.0f - time;
            return 1.0f - time * time * 7.5625f;
        }

        if (time > 0.27273f)
        {
            time = 0.454546f - time;
            return 0.25f - time * time * 7.5625f;
        }

        if (time > 0.090909f)
        {
            time = 0.181818f - time;
            return 0.0625f - time * time * 7.5625f;
        }

        if (time >= 1.0f)
        {
            return time;
        }

        time = 0.045455f - time;
        return 0.015625f - time * time * 7.5625f;
    }


    private static float BounceInOut(float time)
    {
        if (time < 0.5f)
        {
            // bounce in
            if (time > 0.318182f)
            {
                time = 1.0f - time * 2.0f;
                return 0.5f - time * time * 3.78125f;
            }

            if (time > 0.136365f)
            {
                time = 0.454546f - time * 2.0f;
                return 0.125f    - time * time * 3.78125f;
            }

            if (time > 0.045455f)
            {
                time = 0.181818f - time * 2.0f;
                return 0.03125f  - time * time  * 3.78125f;
            }
            
            time = 0.045455f - time * 2.0f;
            return 0.007813f - time * time * 3.78125f;
        }

        // bounce out
        if (time < 0.681818f)
        {
            time = time * 2.0f - 1.0f;
            return time * time * 3.78125f + 0.5f;
        }

        if (time < 0.863635f)
        {
            time = time * 2.0f - 1.545454f;
            return time * time * 3.78125f + 0.875f;
        }

        if (time < 0.954546f)
        {
            time = time * 2.0f - 1.818182f;
            return time * time * 3.78125f + 0.96875f;
        }

        if (time >= 1.0f)
        {
            return time;
        }

        time = time * 2.0f - 1.954545f;
        return time * time * 3.78125f + 0.992188f;
    }
}