using FsHttp;
using FsHttp.CSharp;


var httpclient = new HttpClient();


var res = await "https://reqres.in/api/users".Post()
    .CacheControl("no-cache")
    .Configure(config => config.SetHttpClient(httpclient))
    .Body()
    .Json("""
    {
        "name": "morpheus",
        "job": "leader"
    }
    """)
    
    .SendAsync();

Console.WriteLine(res);
