using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Add repeating patterns here!

public static class Unitilities {
    public class Counter {
        float _t;

        public void Update(float input){
            _t += input;
        }

        public void Set(float input){
            _t = input;
        }

        public T t <T>(){
            if (typeof(T) == typeof(int)){
                _t = Mathf.FloorToInt(_t);
            }

            T val = (T) Convert.ChangeType(_t, typeof(T));

            return val;
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
    }
}