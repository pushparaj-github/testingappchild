// See https://aka.ms/new-console-template for more information
using OidcAuth;

Console.WriteLine("Hello, World!");
var retval = GetOidcAuth.GetUserDetails();
Console.WriteLine(retval.ToString());