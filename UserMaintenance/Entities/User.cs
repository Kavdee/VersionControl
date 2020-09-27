using System;
using System.Security.Cryptography.X509Certificates;

public class User
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public string Fullname 
    {
        get; set;
    }

}

	
