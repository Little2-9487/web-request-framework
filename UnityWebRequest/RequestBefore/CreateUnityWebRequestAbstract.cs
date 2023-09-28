using UnityEngine.Networking;

namespace L2
{
    public abstract class CreateUnityWebRequestAbstract : IRequestBefore
    {
        readonly protected IRequestContainer<UnityWebRequest> container;

        public CreateUnityWebRequestAbstract(IRequestContainer<UnityWebRequest> _container)
        {
            container = _container;
        }
        public abstract void Do();
    }
}
