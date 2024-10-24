namespace AXitUnityTemplate.MVC.Sample.Scripts.Player
{
    using UnityEngine;
    using AXitUnityTemplate.MVC.Interface;

    public class PlayerModel : IModel
    {
        public readonly float     MoveDistance  = 3f;
        public readonly float     MoveDuration  = 1f;
        public readonly float     RotationSpeed = 100f;
        public          bool      IsMoving      = false;
        public          Vector3   DefaultPosition;
        public          Coroutine MoveForwardCoroutine;
    }
}