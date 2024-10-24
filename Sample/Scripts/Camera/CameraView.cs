namespace AXitUnityTemplate.MVC.Sample.Scripts.Camera
{
    using UnityEngine;
    using AXitUnityTemplate.MVC.Base;

    public class CameraView : BaseView<CameraModel, CameraController>
    {
        [SerializeField] private Transform target;

        protected override void Init() { this.Model.Target = this.target; }

        private void LateUpdate() { this.Controller.Move(this.transform); }
    }
}