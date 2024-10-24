namespace AXitUnityTemplate.MVC.Sample.Scripts.Camera
{
    using UnityEngine;
    using AXitUnityTemplate.MVC.Interface;

    public class CameraModel : IModel
    {
        public readonly float     SmoothSpeed = 0.125f;
        public          Transform Target;
        public          Vector3   Offset   = default;
        public          Vector3   Velocity = Vector3.zero;
    }
}