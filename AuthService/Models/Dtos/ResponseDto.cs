﻿namespace AuthService;

public class ResponseDto
{
     public string Error {get;set;} =string.Empty;
    public object Result {get;set;} =default!;
    public bool Success {get;set;}= true;

}
