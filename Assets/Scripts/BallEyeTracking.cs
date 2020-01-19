//========= Copyright 2018, HTC Corporation. All rights reserved. ===========
using UnityEngine;

namespace ViveSR.anipal.Eye
{
    [RequireComponent(typeof(Renderer), typeof(Collider))]
    public class BallEyeTracking : MonoBehaviour {

        public GameObject Kid;
    
        private Renderer Renderer;
        public uint BendCount = 3, PieCount = 10, FrameWidth = 1;

        private void Awake()
        {
            Renderer = GetComponent<Renderer>();
            Focus(Vector3.zero);
            Kid.SetActive(false);
        }

        public void Focus(Vector3 focusPoint)
        {
           
            Debug.Log("Looking at the Sphere");

            Kid.SetActive(true);
    }

        public float SignedAngle(Vector3 v1, Vector3 v2, Vector3 v_forward)
        {
            float dotP = Vector3.Dot(v1, v2);
            float unsignedAngle = Mathf.Acos(dotP) * (180 / 3.14159f);

            float sign = Vector3.Dot(v_forward, Vector3.Cross(v1, v2));
            float signedAngle = unsignedAngle * (sign > 0f ? 1f : -1f) + 180f;
            return signedAngle;
        }
    }
}
