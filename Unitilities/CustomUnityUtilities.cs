/// <summary>
/// Copyright 2022, Loki Alexander Button Hornsby (Loki Hornsby), All rights reserved.
/// Licensed under the BSD 3-Clause "New" or "Revised" License
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

// Version: 28.12.22

public static class Unitilities {
    public static class Probability {
        public static bool Check(int percentage, int range = 100){ // By default this returns a 1 in 100 chance
            int var = UnityEngine.Random.Range(0, range + 1);

            return (var == percentage);
        }
    }

    public static class Enums {
        public static Enum GetRandomEnumValue(Type t){
            return Enum.GetValues(t)          // get values from Type provided
                .OfType<Enum>()               // casts to Enum
                .OrderBy(e => Guid.NewGuid()) // mess with order of results
                .FirstOrDefault();            // take first item in result
        }
    }

    public static class Angles {
        public static float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }

        public static float WrapAngle(float angle){
            angle%=360;
            if(angle >180)
                return angle - 360;

            return angle;
        }

        public static float UnwrapAngle(float angle){
            if(angle >=0)
                return angle;

            angle = -angle%360;

            return 360-angle;
        }
    }

    public static class Distance {
        public static float Between2Floats(float a, float b){
            return Mathf.Abs(Mathf.Abs(a) - Mathf.Abs(b));
        }
    }

    public static class Trigger {
        public static bool IsInLayerMask(int layer, LayerMask layermask){
            // Queries if layer is in selected Layer Mask
            return layermask == (layermask | (1 << layer));
        }
    }

    public static class Maths {
        public static int GCD (int a, int b){
            while (a != 0 && b != 0){
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        public static Vector3 ClampVector3(ref Vector3 value){
            value.x = Mathf.Clamp(value.x, Min.x, Max.x);
            value.y = Mathf.Clamp(value.y, Min.y, Max.y);
            value.z = Mathf.Clamp(value.z, Min.z, Max.z);
            return value;
        }

        public static Vector2 ClampVector2(ref Vector2 value){
            value.x = Mathf.Clamp(value.x, Min.x, Max.x);
            value.y = Mathf.Clamp(value.y, Min.y, Max.y);
            return value;
        }
    }
}
