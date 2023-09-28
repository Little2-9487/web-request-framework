using UnityEngine.Networking;

namespace L2
{
    public abstract class AfterUnityWebRequestAbstract : IRequestAfter
    {
        readonly protected IRequestContainer<UnityWebRequest> request;
        public AfterUnityWebRequestAbstract(IRequestContainer<UnityWebRequest> _c)
        {
            request = _c;
        }


        public abstract void Do();
    }
}
