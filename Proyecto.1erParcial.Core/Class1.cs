﻿namespace Proyecto._1erParcial.Core;

public class Response <T>{
    
    public T Data { get; set; }
    public string Message { get; set; }
    public List<string> Errors { get; set; } = new List<string>();

}