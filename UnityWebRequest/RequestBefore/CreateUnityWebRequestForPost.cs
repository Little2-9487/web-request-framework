using UnityEngine.Networking;
using UnityEngine;

namespace L2
{
    public class CreateUnityWebRequestForPost : IRequestBefore
    {
        readonly string url;
        readonly WWWForm form;
        readonly protected IRequestContainer<UnityWebRequest> container;

        public CreateUnityWebRequestForPost(string _url, WWWForm _form, IRequestContainer<UnityWebRequest> _c)
        {
            container = _c;
            url = _url;
            form = _form;
        }

        public virtual void Do()
        {
            var www = UnityWebRequest.Post(url, form);
            container.SetRequest(www);
        }
    }
}
