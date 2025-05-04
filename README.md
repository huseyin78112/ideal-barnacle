# Ideal Barnacle
A basic Telnet client

You can build directly from Visual Studio with .NET 8 installed only. You can build for Windows, macOS or Linux.

You can make HTTP requests like this:
```
ideal-barnacle.exe localhost
Connecting to localhost:80...
Successfully connected to localhost:80.
GET / HTTP/1.1
Host: localhost
Accept: */*

^Z
Your request has been processed. Press Ctrl+C to stop receiving response.
HTTP/1.1 200 OK
Server: nginx/1.28.0
Date: Sun, 04 May 2025 12:23:28 GMT
Content-Type: text/html; charset=utf-8
Content-Length: 27
Last-Modified: Sun, 04 May 2025 12:23:14 GMT
Connection: keep-alive
ETag: "68175c32-1b"
Accept-Ranges: bytes

<p>This is a test page.</p>
```
