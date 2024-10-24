namespace AXitUnityTemplate.MVC.Interface
{
    public interface IController<TModel>
    where TModel : IModel
    {
        public TModel Model { get; set; }
    }
}