using UnityEngine.Networking;

namespace L2
{
    public class CreateUnityWebRequestForGet : CreateUnityWebRequestAbstract
    {
        readonly string url;

        public CreateUnityWebRequestForGet(string _url, IRequestContainer<UnityWebRequest> _container) : base(_container)
        {
            url = _url;
        }

        public override void Do()
        {
            var www = UnityWebRequest.Get(url);
            container.SetRequest(www);
        }
    }
}
