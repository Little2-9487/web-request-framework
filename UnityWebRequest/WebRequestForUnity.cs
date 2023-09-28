using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace L2
{
    public class WebRequestForUnity : IRequest
    {
        readonly MonoBehaviour mono;
        readonly IRequestBefore rb;
        readonly IRequestContainer<UnityWebRequest> rc;

        public WebRequestForUnity(MonoBehaviour _mono, IRequestBefore _rb, IRequestContainer<UnityWebRequest> _rc)
        {
            rb = _rb;
            rc = _rc;
            mono = _mono;
        }

        public void Request(IRequestAfter _onEnd)
        {
            if (mono != null)
            {
                mono.StartCoroutine(DoRequest(_onEnd));
            }
        }

        private IEnumerator DoRequest(IRequestAfter _onEnd)
        {
            rb.Do();
            using (UnityWebRequest www = rc.GetRequest())
            {
                yield return www.SendWebRequest();

                if (_onEnd != null) _onEnd.Do();
            }
        }
    }
}
