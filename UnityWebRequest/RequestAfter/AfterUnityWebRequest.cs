using UnityEngine.Networking;
using UnityEngine;

namespace L2
{
    public class AfterUnityWebRequest : AfterUnityWebRequestAbstract
    {
        public AfterUnityWebRequest(IRequestContainer<UnityWebRequest> _rc) : base(_rc)
        {
        }

        public override void Do()
        {
            if (request != null)
            {
                var wwwEnd = request.GetRequest();
                if (string.IsNullOrEmpty(wwwEnd.error))
                {
                    //normal
                    Debug.Log(wwwEnd.downloadHandler.text);
                    
                }
                else
                {
                    //error
                    Debug.LogError(wwwEnd.error);
                }
            }
        }
    }
}

