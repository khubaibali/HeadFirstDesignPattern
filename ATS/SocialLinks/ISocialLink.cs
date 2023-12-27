namespace ATS.SocialLinks;

public interface ISocialLink
{
    string Name { get; set;}
}


public class LinkDin : ISocialLink
{
    public string Name => throw new NotImplementedException();

    string ISocialLink.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public record PortfolioLink : ISocialLink
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
public record BehanceProfileLink : ISocialLink
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
//public string AdobeProfileLink { get; set; } = string.Empty;
//public string VemioProfileLink { get; set; } = string.Empty;
//public string? DribbleProfileLink { get; set; }
//public string? WebsiteLink { get; set; }
//public string? YoutubeLink { get; set; }
//public string? LinkedIn { get; set; }