namespace AXitUnityTemplate.MVC.Sample.Scripts.Player
{
    using System;
    using UnityEngine;
    using System.Collections;
    using AXitUnityTemplate.MVC.Interface;
    using AXitUnityTemplate.MVC.Sample.Scripts.Manager;

    public class PlayerController : IController<PlayerModel>
    {
        public PlayerModel Model { get; set; }

        public void Rotate(Transform transform)
        {
            if (!transform) return;
            transform.Rotate(0, this.Model.RotationSpeed * Time.deltaTime, 0);
        }

        public IEnumerator MoveForwardCoroutine(Transform transform)
        {
            this.Model.IsMoving = true;

            Vector3 startPosition  = transform.position;
            Vector3 targetPosition = transform.position + transform.forward * this.Model.MoveDistance;
            float   elapsedTime    = 0f;

            while (elapsedTime < this.Model.MoveDuration)
            {
                transform.position =  Vector3.Lerp(startPosition, targetPosition, elapsedTime / this.Model.MoveDuration);
                elapsedTime        += Time.deltaTime;

                yield return null;
            }

            transform.position  = targetPosition;
            this.Model.IsMoving = false;
        }

        public void PlayerTriggerWith(Type type) { GameManager.Instance.PlayerTriggerWith(type); }
        
        public void OnResetPositionView(Transform view) { view.position = this.Model.DefaultPosition; }
    }
}