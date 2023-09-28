using L2;
using UnityEngine;
using UnityEngine.Networking;

public class APIFrameworkForUnityWebRequest : MonoBehaviour
{
    public void Post()
    {
        IRequestContainer<UnityWebRequest> c = new RequestContainerForUnityWebRequest();
        IRequestBefore rb = new CreateUnityWebRequestForPost("", new WWWForm(), c);
        IRequestAfter re = new AfterUnityWebRequest(c);
        IRequest request = new WebRequestForUnity(this, rb, c);
        request.Request(re);
    }

    public void Get()
    {
        IRequestContainer<UnityWebRequest> c = new RequestContainerForUnityWebRequest();
        IRequestBefore rb = new CreateUnityWebRequestForGet("", c);
        IRequestAfter re = new AfterUnityWebRequest(c);
        IRequest request = new WebRequestForUnity(this, rb, c);
        request.Request(re);
    }

    public class LoginInputDTO { public string Acc; public string Pwd; }
    public void PostWithJson()
    {
        var input = new LoginInputDTO() { Acc = "123", Pwd = "123"};
        IRequestContainer<UnityWebRequest> c = new RequestContainerForUnityWebRequest();
        IRequestBefore rb = new CreateUnityWebRequestJson<LoginInputDTO>("", UnityWebRequest.kHttpVerbPOST, input, c);
        IRequestAfter re = new AfterUnityWebRequest(c);
        IRequest request = new WebRequestForUnity(this, rb, c);
        request.Request(re);
    }
}
