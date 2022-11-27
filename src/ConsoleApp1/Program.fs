open FsHttp
open System

let res =
    http {
        POST "https://reqres.in/api/users"
        CacheControl "no-cache"
        body
        json """
        {
            "name": "morpheus",
            "job": "leader"
        }
        """
    } |> Request.send

res |> Console.WriteLine
