using UnityEngine;
using UnityEngine.Networking;

namespace L2
{
    public class CreateUnityWebRequestJson<T> : CreateUnityWebRequestAbstract
    {
        readonly string url;
        readonly T dto;
        readonly string method;

        public CreateUnityWebRequestJson(string _url, string _method, T _dto, IRequestContainer<UnityWebRequest> _container) : base(_container)
        {
            url = _url;
            method = _method;
            dto = _dto;
        }

        public override void Do()
        {
            var json = JsonUtility.ToJson(dto);
            var b = System.Text.Encoding.UTF8.GetBytes(json);
            var www = new UnityWebRequest(url, method);
            if (method == UnityWebRequest.kHttpVerbPOST)
                www.uploadHandler = new UploadHandlerRaw(b);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");
            www.SetRequestHeader("Accept", "application/json");
            container.SetRequest(www);
        }
    }
}
