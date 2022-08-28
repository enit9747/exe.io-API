# exe.io-API
An unofficial exe.io API for .NET written in C#

Dependencies:
<ul>
  <li><a href="https://www.newtonsoft.com/json">Newtonsoft.Json</a></li>
</ul>

Currently retrieves:
<ul>
  <li>Shortened URL with or without Custom Alias</li>
</ul>

Examples:

**Retrieve shortened url:**
```c#
private static void Main()
{
  shortenUrl sh = new shortenUrl();
  shortenedTxt.Text = sh.Shorten("YOURTOKEN", "DESTINATIONLINK", "CUSTOMALIAS");
}
```
