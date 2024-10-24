namespace AXitUnityTemplate.MVC.Sample.Scripts.Camera
{
    using UnityEngine;
    using AXitUnityTemplate.MVC.Interface;

    public class CameraController : IController<CameraModel>
    {
        public CameraModel Model { get; set; }

        public void Move(Transform transform)
        {
            Vector3 desiredPosition = this.Model.Target.position + this.Model.Offset;

            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref this.Model.Velocity, this.Model.SmoothSpeed);

            transform.position = smoothedPosition;
        }
    }
}