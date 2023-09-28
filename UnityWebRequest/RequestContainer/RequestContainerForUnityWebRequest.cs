using UnityEngine.Networking;

namespace L2
{
    public class RequestContainerForUnityWebRequest : IRequestContainer<UnityWebRequest>
    {
        private UnityWebRequest rq;

        public UnityWebRequest GetRequest()
        {
            return rq;
        }

        public void SetRequest(UnityWebRequest _data)
        {
            rq = _data;
        }
    }
}
