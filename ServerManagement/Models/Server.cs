using System;

namespace ServerManagement.models;

public class Server 
{
    public Server()
    {
        Random random = new Random();
        int rndNmbr = random.Next(0,2);
        IsOnline = rndNmbr == 0 ? false : true;
    }

    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }    
}