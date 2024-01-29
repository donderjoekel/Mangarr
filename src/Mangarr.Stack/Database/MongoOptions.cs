﻿namespace Mangarr.Stack.Database;

public class MongoOptions
{
    public const string SECTION = "Mongo";

    public string Host { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
