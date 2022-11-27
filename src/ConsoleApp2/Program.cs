using FsHttp;
using FsHttp.CSharp;


using var httpclient = new HttpClient();

using var res = await "https://reqres.in/api/user"
    .Post()
    .CacheControl("no-cache")
    .Configure(config =>
    {
        config.SetHttpClient(httpclient);
        return config;
    })
    .Body()
    .Json("""
    {
        "name": "morpheus",
        "job": "leader"
    }
    """)
    .SendAsync();

Console.WriteLine(await res.ToJsonAsync());
